using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Live_iRacing.Services.TrayIcon
{
    public class TrayIconService : ITrayIconService
    {
        private readonly NotifyIcon trayIcon;
        private readonly Form mainForm;

        public TrayIconService(Form mainForm)
        {
            this.mainForm = mainForm;
            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Application, // Use your application's icon
                Visible = false
            };
            trayIcon.DoubleClick += (sender, args) => RestoreFromTray();
        }

        public void Initialize()
        {
            // Additional initialization if needed
        }

        public void MinimizeToTray()
        {
            mainForm.WindowState = FormWindowState.Minimized;
            mainForm.ShowInTaskbar = false;
            trayIcon.Visible = true;
        }

        public void RestoreFromTray()
        {
            mainForm.Show();
            mainForm.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }
    }
}
