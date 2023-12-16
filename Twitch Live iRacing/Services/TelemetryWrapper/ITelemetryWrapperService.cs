namespace Twitch_Live_iRacing.Services.TelemetryWrapper
{
    public interface ITelemetryWrapperService
    {
        void StartListeningTelemetry();
        void StopListeningTelemetry();
    }
}