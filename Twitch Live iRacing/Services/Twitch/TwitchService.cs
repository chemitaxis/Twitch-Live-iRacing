using Newtonsoft.Json;
using System.Text;
using Twitch_Live_iRacing.Services.Logger;
using Twitch_Live_iRacing.Services.Storage;
using Twitch_Live_iRacing.Services.TelemetryWrapper;

namespace Twitch_Live_iRacing.Services.Twitch
{
    public class TwitchService : ITwitchService
    {

        private readonly ILogService logService;
        private readonly IStorageService storageService;
        private readonly ITelemetryWrapperService iRacingWrapperService;

        public TwitchService(ILogService logService, IStorageService storageService, ITelemetryWrapperService sdkWrapperService)
        {
            this.logService = logService;
            this.storageService = storageService;
            this.iRacingWrapperService = sdkWrapperService;
        }

        private void OnSdkDataChanged(object sender, SdkDataEventArgs e)
        {
            // Logic to call the Twitch API
            UpdateTwitchAPIAsync(e.Data);
        }

        private async Task UpdateTwitchAPIAsync(SdkData data)
        {
            // API update logic
            // Retrieve the stored token and channel name
            var token = storageService.LoadSetting("TwitchToken");
            var channelName = storageService.LoadSetting("TwitchChannelName");
            var clientId = storageService.LoadSetting("TwitchClientId");

            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(channelName) || string.IsNullOrEmpty(clientId))
            {
                logService.Log("Missing required settings: token, channel name, or client ID.");
                return; // Exit the method if any required setting is missing
            }

            var broadcasterId = storageService.LoadSetting("BroadcasterId");
            // Check if the broadcaster ID is available
            if (string.IsNullOrEmpty(broadcasterId))
            {
                // Fetch and store the broadcaster ID
                broadcasterId = await FetchAndStoreBroadcasterId(token, clientId);
            }
            // Format the new title using the SdkData properties
            var newTitle = $"{data.SerieName} - {data.StrengthOfField} - {data.SessionType} - {data.Car}";

            // Update the channel's title
            await UpdateChannelTitle(token, channelName, broadcasterId, newTitle);
        }

        private async Task UpdateChannelTitle(string token, string channelName, string broadcasterId, string newTitle)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                client.DefaultRequestHeaders.Add("Client-Id", "YourClientId");

                var content = new StringContent(JsonConvert.SerializeObject(new { title = newTitle }), Encoding.UTF8, "application/json");
                var response = await client.PatchAsync($"https://api.twitch.tv/helix/channels?broadcaster_id={broadcasterId}", content);

                if (!response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    logService.Log($"Failed to update Twitch channel. Response: {responseBody}");
                }

                if (response.IsSuccessStatusCode)
                {
                    logService.Log($"Twitch channel updated with title: {newTitle}");
                }

            }
        }

        private async Task<string> FetchAndStoreBroadcasterId(string token, string clientId)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                client.DefaultRequestHeaders.Add("Client-Id", clientId);

                var response = await client.GetAsync("https://api.twitch.tv/helix/users");

                if (!response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    logService.Log($"Failed to fetch broadcaster ID. Response: {responseBody}");
                    return null;
                }

                var content = await response.Content.ReadAsStringAsync();
                var userData = JsonConvert.DeserializeObject<TwitchUserData>(content);

                var broadcasterId = userData?.Data?.FirstOrDefault()?.Id;
                if (!string.IsNullOrEmpty(broadcasterId))
                {
                    storageService.SaveSetting("BroadcasterId", broadcasterId);
                }

                return broadcasterId;
            }
        }
    }
}
