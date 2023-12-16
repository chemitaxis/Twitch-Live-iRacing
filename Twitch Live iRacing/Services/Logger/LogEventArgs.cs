namespace Twitch_Live_iRacing.Services.Logger
{
    public class LogEventArgs
    {
        public string message;

        public LogEventArgs(string message)
        {
            this.message = message;
        }
    }
}