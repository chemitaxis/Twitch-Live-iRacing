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

            this.telemetryWrapperService.DataChanged += this.twitchService.OnSdkDataChanged;

            this.addLinksToLabel();

        }

        private void addLinksToLabel()
        {

            // Add a link to the LinkLabel.
            LinkLabel.Link linToHelpk = new LinkLabel.Link
            {
                LinkData = "https://www.twitch.tv/chema_sr",
                Start = 0,
                Length = LinkLabelHelpMe.Text.Length
            };

            LinkLabelHelpMe.Links.Add(linToHelpk);

            // Add a link to the LinkLabel.
            LinkLabel.Link linkSettings = new LinkLabel.Link
            {
                LinkData = "https://github.com/chemitaxis/Twitch-Live-iRacing/blob/master/README.md",
                Start = 0,
                Length = LinkLabelSettings.Text.Length
            };

            LinkLabelSettings.Links.Add(linkSettings);


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



        private void LinkLabelHelpMe_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            var psi = new ProcessStartInfo
            {
                FileName = e.Link.LinkData as string,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            var psi2 = new ProcessStartInfo
            {
                FileName = e.Link.LinkData as string,
                UseShellExecute = true
            };
            Process.Start(psi2);
        }

        private void CheckBoxEnabledLogs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxStartMinified_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxStartApplication_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSaveChannelName_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClientIdTwitch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveClientIdTwitch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonShowTokenTwitch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveTokenTwitch_Click(object sender, EventArgs e)
        {

        }
    }
}
