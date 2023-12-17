using iRacingSdkWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch_Live_iRacing.Services.Logger;
using Twitch_Live_iRacing.Utils;
using static iRacingSdkWrapper.SdkWrapper;


namespace Twitch_Live_iRacing.Services.TelemetryWrapper
{
    public class TelemetryWrapperService : ITelemetryWrapperService
    {
        private readonly ILogService logService;
        private readonly ISeriesConversor seriesConversor;
        private SdkWrapper wrapper;
        private SdkData lastSdkData = new SdkData();
        public event EventHandler<SdkDataEventArgs> DataChanged = delegate { };

        // Event declarations...

        public TelemetryWrapperService(ILogService logService, ISeriesConversor seriesConversor)
        {
            this.logService = logService;
            this.seriesConversor = seriesConversor;
            
            // Configuration of the wrapper...
            wrapper = new SdkWrapper();
           

            // Tell it to raise events on the current thread (don't worry if you don't know what a thread is)
            wrapper.EventRaiseType = SdkWrapper.EventRaiseTypes.CurrentThread;

            // Only update telemetry 10 times per second
            //wrapper.TelemetryUpdateFrequency = 10;

            wrapper.TelemetryUpdateFrequency = 0.2;

            wrapper.Connected += TelemetryWrapperConnected;
            wrapper.Disconnected += TelemetryWrapperDisconnected;
            wrapper.SessionInfoUpdated += TelemetryWrapperSessionInfoUpdated;

            wrapper.Start();


        }

       


        private void TelemetryWrapperDisconnected(object? sender, EventArgs e)
        {

            logService.Log("Disconnected from iRacing");
        }

        private void TelemetryWrapperConnected(object? sender, EventArgs e)
        {
            logService.Log("Connected to iRacing");
          
        }

        private void TelemetryWrapperSessionInfoUpdated(object? sender, SessionInfoUpdatedEventArgs e)
        {
            logService.Log("Updated info session from iRacing");
            var newData = ConvertToSdkData(e); // Convert or map the event args to your data model

            if (!newData.Equals(lastSdkData)) // Implement Equals to correctly compare data
            {
                lastSdkData = newData;
                logService.Log("SDK Data updated");
                DataChanged?.Invoke(this, new SdkDataEventArgs(newData));
            }
        }

        private SdkData ConvertToSdkData(SessionInfoUpdatedEventArgs e)
        {

            var data = new SdkData();

            data.SessionType = e.SessionInfo["WeekendInfo"]["EventType"].GetValue(); 
            data.SerieName = convertToNameSerieId(e.SessionInfo["WeekendInfo"]["SeriesID"].GetValue());
            data.TrackName = e.SessionInfo["WeekendInfo"]["TrackDisplayName"].GetValue();
            data.StrengthOfField = getStrenghtOfField(e.SessionInfo);
            return data;
        }

        private string? getStrenghtOfField(SessionInfo sessionInfo)
        {
            var sof = 0;
            var drivers = 0;
            for (var id = 0; id < 60; id++)
            {
                string? irating;
                if (sessionInfo["DriverInfo"]["Drivers"]["CarIdx", id]["IRating"].TryGetValue(out irating))
                {
                    // Success
                    drivers++;
                    sof += Int16.Parse(irating);
                }
            }


            return (sof / drivers).ToString();
        }

        private string? convertToNameSerieId(string id)
        {
            return this.seriesConversor.ConvertFromIdToName(id);
        }
    }
}
