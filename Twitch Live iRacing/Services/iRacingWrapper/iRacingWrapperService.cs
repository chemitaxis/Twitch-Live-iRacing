using iRacingSdkWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch_Live_iRacing.Services.Logger;


using static iRacingSdkWrapper.SdkWrapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Twitch_Live_iRacing.Services.iRacingWrapper
{
    internal class iRacingWrapperService :IiRacingWrapperService
    {
        private readonly ILogService logService;
        private SdkWrapper wrapper;
        private SdkData lastSdkData = new SdkData();
        public event EventHandler<SdkDataEventArgs> DataChanged = delegate { };

        // Event declarations...

        public iRacingWrapperService(ILogService logService)
        {
            this.logService = logService;
            
            // Configuration of the wrapper...
            wrapper = new SdkWrapper();
           

            // Tell it to raise events on the current thread (don't worry if you don't know what a thread is)
            wrapper.EventRaiseType = SdkWrapper.EventRaiseTypes.CurrentThread;

            // Only update telemetry 10 times per second
            wrapper.TelemetryUpdateFrequency = 10;

            wrapper.Connected += Wrapper_Connected;
            wrapper.Disconnected += Wrapper_Connected;
            wrapper.SessionInfoUpdated += Wrapper_SessionInfoUpdated;
        }


        

        private void Wrapper_Disconnected(object? sender, EventArgs e)
        {

            logService.Log("Disconnected from iRacing");
        }

        private void Wrapper_Connected(object? sender, EventArgs e)
        {
            logService.Log("Connected to iRacing");
            throw new NotImplementedException();
        }

        private void Wrapper_SessionInfoUpdated(object? sender, SessionInfoUpdatedEventArgs e)
        {
            logService.Log("Updated info session from iRacing");
            var newData = ConvertToSdkData(e); // Convert or map the event args to your data model

            if (!newData.Equals(lastSdkData)) // Implement Equals to correctly compare data
            {
                lastSdkData = newData;
                logService.Log("SDK Data updated");
                DataChanged?.Invoke(this, new SdkDataEventArgs(newData));
            }
        }

        private SdkData ConvertToSdkData(SessionInfoUpdatedEventArgs e)
        {

            var data = new SdkData();

            data.Car = e.SessionInfo.GetValue("");
            data.StrengthOfField = e.SessionInfo.GetValue("");
            data.SerieName = e.SessionInfo.GetValue("");
            data.SessionType = e.SessionInfo.GetValue("");
            return data;
        }
    }
}
