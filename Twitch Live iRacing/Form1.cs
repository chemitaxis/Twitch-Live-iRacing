using Twitch_Live_iRacing.Services.TelemetryWrapper;
using Twitch_Live_iRacing.Services.Logger;
using Twitch_Live_iRacing.Services.Storage;
using Twitch_Live_iRacing.Services.TrayIcon;
using Twitch_Live_iRacing.Services.Twitch;
using System.Diagnostics;

namespace Twitch_Live_iRacing
{
    public partial class Form1 : Form
    {
        private ILogService logService;
        private IStorageService storageService;
        private ITrayIconService trayIconService;
        private ITelemetryWrapperService telemetryWrapperService;
        private ITwitchService twitchService;

        

        public Form1(ILogService logService, IStorageService storageService, ITelemetryWrapperService telemetryWrapperService, ITwitchService twitchService)
        {
            InitializeComponent();

            this.logService = logService;
            this.storageService = storageService;            
            this.telemetryWrapperService = telemetryWrapperService;
            this.twitchService = twitchService;

           

            trayIconService = new TrayIconService(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.logService.LogUpdated += LogService_LogUpdated;
            telemetryWrapperService.StartListeningTelemetry();
        }

        private void LogService_LogUpdated(object sender, LogEventArgs e)
        {
            // Thread safety check
            if (InvokeRequired)
            {
                Invoke(new Action(() => LogService_LogUpdated(sender, e)));
                return;
            }

            // Update the log text box
            Debug.WriteLine(e.message);
           
        }
    }
}
