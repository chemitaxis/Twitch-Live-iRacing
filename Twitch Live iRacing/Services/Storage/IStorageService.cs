namespace Twitch_Live_iRacing.Services.Storage
{
    public interface IStorageService
    {
        void SaveSetting(string key, string value);
        void SaveSetting(string key, bool value);
        string? LoadSetting(string key);

        bool LoadSettingBool(string key);
    }
}