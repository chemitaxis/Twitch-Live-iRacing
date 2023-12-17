using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch_Live_iRacing;
using Twitch_Live_iRacing.Services.Logger;



namespace Twitch_Live_iRacing.Services.Storage
{
    public class AppSettingsStorageService : IStorageService
    {

        private ILogService _logService;

        public AppSettingsStorageService(ILogService logService) {

            _logService = logService;
        
        }
        public void SaveSetting(string key, string value)
        {
            
            Settings.Default[key] = value;
            Settings.Default.Save();
            _logService.Log("Setting " + key + " saved correctly");
        }

        public void SaveSetting(string key, bool value)
        {

            Settings.Default[key] = value;
            Settings.Default.Save();
            _logService.Log("Setting " + key + " saved correctly");
        }

        public string? LoadSetting(string key)
        {
            return Settings.Default[key]?.ToString();
        }
    }
}
