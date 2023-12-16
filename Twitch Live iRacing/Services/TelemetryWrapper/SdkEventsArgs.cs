using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Live_iRacing.Services.TelemetryWrapper
{
    public class SdkDataEventArgs : EventArgs
    {
        public SdkData Data { get; private set; }

        public SdkDataEventArgs(SdkData data)
        {
            Data = data;
        }
    }
}
