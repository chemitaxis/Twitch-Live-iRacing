using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Live_iRacing.Services.Logger
{
    public class LogService : ILogService
    {
        public event EventHandler<LogEventArgs> LogUpdated = delegate { };


        public void Log(string message)
        {
            string timestampedMessage = $"[{DateTime.Now}] {message}";
            OnLogUpdated(timestampedMessage);
        }

        protected virtual void OnLogUpdated(string message)
        {
            LogUpdated?.Invoke(this, new LogEventArgs(message));
        }
    }
}
