using Twitch_Live_iRacing.Services.TelemetryWrapper;
using Twitch_Live_iRacing.Services.Logger;
using Twitch_Live_iRacing.Services.Storage;
using Twitch_Live_iRacing.Services.TrayIcon;
using Twitch_Live_iRacing.Services.Twitch;

namespace Twitch_Live_iRacing
{
    public partial class Form1 : Form
    {
        private ILogService logService;
        private IStorageService storageService;
        private ITrayIconService trayIconService;
        private ITelemetryWrapperService telemtryWrapperService;
        private ITwitchService twitchService;

        

        public Form1(ILogService logService, IStorageService storageService, ITelemetryWrapperService telemtryWrapperService, ITwitchService twitchService)
        {
            InitializeComponent();

            this.logService = logService;
            this.storageService = storageService;            
            this.telemtryWrapperService = telemtryWrapperService;
            this.twitchService = twitchService;

            trayIconService = new TrayIconService(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
