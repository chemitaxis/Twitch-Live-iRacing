
namespace Twitch_Live_iRacing.Services.Logger
{
    public interface ILogService
    {
        event EventHandler<LogEventArgs> LogUpdated;
        void Log(string message);
    }
}