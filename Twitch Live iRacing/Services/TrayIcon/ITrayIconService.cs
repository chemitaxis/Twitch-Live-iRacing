namespace Twitch_Live_iRacing.Services.TrayIcon
{
    public interface ITrayIconService
    {
        void Initialize();
        void MinimizeToTray();
        void RestoreFromTray();
    }
}