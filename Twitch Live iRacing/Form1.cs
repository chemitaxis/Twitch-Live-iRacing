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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (WindowState == FormWindowState.Minimized)
            {
                trayIconService.MinimizeToTray();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        public Form1(ILogService logService, IStorageService storageService, ITelemetryWrapperService telemetryWrapperService, ITwitchService twitchService)
        {
            InitializeComponent();

            this.logService = logService;
            this.storageService = storageService;
            this.telemetryWrapperService = telemetryWrapperService;
            this.twitchService = twitchService;

            InputClientIdTwitch.UseSystemPasswordChar = true;
            InputTokenTwitch.UseSystemPasswordChar = true;
            trayIconService = new TrayIconService(this, tryIconLive);
            trayIconService.Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.logService.LogUpdated += LogService_LogUpdated;           

            this.telemetryWrapperService.DataChanged += this.twitchService.OnSdkDataChanged;

            

            this.addLinksToLabel();

            this.loadInitialDataAndSettings();

            logService.Log("Application started... waiting to iRacing");

        }

        private void loadInitialDataAndSettings()
        {
            CheckBoxEnabledLogs.Checked = storageService.LoadSettingBool("EnableLogs");
            CheckBoxStartWithWindows.Checked = storageService.LoadSettingBool("StartWithWindows");
           
            InputTokenTwitch.Text = storageService.LoadSetting("TwitchToken");
            InputClientIdTwitch.Text = storageService.LoadSetting("TwitchClientId");
            InputChannelNameTwitch.Text = storageService.LoadSetting("TwitchChannelName");
            var minifiedWithWindows = storageService.LoadSettingBool("StartMinified");
            CheckBoxStartMinified.Checked = minifiedWithWindows;
            if (minifiedWithWindows)
            {
                trayIconService.MinimizeToTray();
            }

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

            if (storageService.LoadSettingBool("EnableLogs")) { 

                InputLogs.AppendText(e.message + Environment.NewLine);

                // Optionally, scroll to the bottom of the TextBox
                InputLogs.SelectionStart = InputLogs.Text.Length;
                InputLogs.ScrollToCaret();
            }

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
            
            storageService.SaveSetting("EnableLogs", CheckBoxEnabledLogs.Checked);
        }

        private void CheckBoxStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {

            var registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey
                      ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (CheckBoxStartWithWindows.Checked)
            {
                registryKey.SetValue("TwitchLiveIRacing", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("TwitchLiveIRacing", false);
            }

            storageService.SaveSetting("StartWithWindows", CheckBoxStartWithWindows.Checked);


        }

        private void CheckBoxStartMinified_CheckedChanged(object sender, EventArgs e)
        {
            storageService.SaveSetting("StartMinified", CheckBoxStartMinified.Checked);
        }


        private void ButtonSaveChannelName_Click(object sender, EventArgs e)
        {
            storageService.SaveSetting("TwitchChannelName", InputChannelNameTwitch.Text);
        }

        private void ButtonClientIdTwitch_Click(object sender, EventArgs e)
        {
            // SHOW AND HIDE
            

            // Check if the password characters are currently hidden
            if (InputClientIdTwitch.UseSystemPasswordChar)
            {
                // Show the characters
                InputClientIdTwitch.UseSystemPasswordChar = false;
                ButtonClientIdTwitch.Text = "Hide";
            }
            else
            {
                // Hide the characters
                InputClientIdTwitch.UseSystemPasswordChar = true;
                ButtonClientIdTwitch.Text = "Show";
            }
        }

        private void ButtonSaveClientIdTwitch_Click(object sender, EventArgs e)
        {
            storageService.SaveSetting("TwitchClientId", InputClientIdTwitch.Text);
        }

        private void ButtonShowTokenTwitch_Click(object sender, EventArgs e)
        {
            // SHOW AND HIDE

            // Check if the password characters are currently hidden
            if (InputTokenTwitch.UseSystemPasswordChar)
            {
                // Show the characters
                InputTokenTwitch.UseSystemPasswordChar = false;
                ButtonShowTokenTwitch.Text = "Hide";
            }
            else
            {
                // Hide the characters
                InputTokenTwitch.UseSystemPasswordChar = true;
                ButtonShowTokenTwitch.Text = "Show";
            }
        }

        private void ButtonSaveTokenTwitch_Click(object sender, EventArgs e)
        {
            storageService.SaveSetting("TwitchToken", InputTokenTwitch.Text);
        }
    }
}
