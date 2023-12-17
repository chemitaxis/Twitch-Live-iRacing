namespace Twitch_Live_iRacing.Services.TelemetryWrapper
{
    public interface ITelemetryWrapperService
    {
       

        event EventHandler<SdkDataEventArgs> DataChanged;
    }
}