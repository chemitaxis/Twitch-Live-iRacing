namespace Twitch_Live_iRacing.Services.Storage
{
    public interface IStorageService
    {
        void SaveSetting(string key, string value);
        string? LoadSetting(string key);
    }
}