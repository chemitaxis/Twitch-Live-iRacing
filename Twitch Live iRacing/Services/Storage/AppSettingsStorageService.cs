using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch_Live_iRacing;



namespace Twitch_Live_iRacing.Services.Storage
{
    public class AppSettingsStorageService : IStorageService
    {
        public void SaveSetting(string key, string value)
        {
            
            Settings.Default[key] = value;
            Settings.Default.Save();
        }

        public string? LoadSetting(string key)
        {
            return Settings.Default[key]?.ToString();
        }
    }
}
