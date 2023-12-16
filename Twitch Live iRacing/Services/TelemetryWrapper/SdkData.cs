using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch_Live_iRacing.Services.TelemetryWrapper
{
    public class SdkData
    {
        // Properties representing the data you receive
        public string? SerieName { get; set; }
        public string? StrengthOfField { get; set; }
        public string? SessionType { get; set; }
        public string? TrackName { get; set; }

        // Add other properties as needed
    }
}
