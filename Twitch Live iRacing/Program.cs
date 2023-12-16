
using Twitch_Live_iRacing.Services.Logger;
using Twitch_Live_iRacing.Services.Storage;
using Twitch_Live_iRacing.Services.TelemetryWrapper;
using Twitch_Live_iRacing.Services.Twitch;
using Twitch_Live_iRacing.Utils;

namespace Twitch_Live_iRacing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ILogService logService = new LogService();
            IStorageService storageService = new AppSettingsStorageService();
            ISeriesConversor seriesConversor = new SeriesConversor();
            ITelemetryWrapperService telemtryWrapperService = new TelemetryWrapperService(logService, seriesConversor);
            ITwitchService twitchService = new TwitchService(logService, storageService, telemtryWrapperService);

            var mainForm = new Form1(logService, storageService,telemtryWrapperService, twitchService );


            Application.Run(mainForm);
        }
    }
}