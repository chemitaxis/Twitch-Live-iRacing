using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Live_iRacing.Services.TrayIcon
{
    public class TrayIconService : ITrayIconService
    {
        private readonly NotifyIcon _trayIcon;
        private readonly Form mainForm;

        public TrayIconService(Form mainForm, NotifyIcon notifyIcon)
        {
            this.mainForm = mainForm;
            _trayIcon = notifyIcon;
            _trayIcon.DoubleClick += (sender, args) => RestoreFromTray();
        }

        public void Initialize()
        {
            // Additional initialization if needed
        }

        public void MinimizeToTray()
        {
            mainForm.WindowState = FormWindowState.Minimized;
            mainForm.ShowInTaskbar = false;
            _trayIcon.Visible = true;
        }

        public void RestoreFromTray()
        {
            mainForm.Show();
            mainForm.WindowState = FormWindowState.Normal;
            _trayIcon.Visible = false;
        }
    }
}
