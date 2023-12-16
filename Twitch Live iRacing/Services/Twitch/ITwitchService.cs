using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch_Live_iRacing.Services.TelemetryWrapper;

namespace Twitch_Live_iRacing.Services.Twitch
{
    public interface ITwitchService
    {
        void OnSdkDataChanged(object sender, SdkDataEventArgs e);
    }
}
