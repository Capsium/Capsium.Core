namespace Capsium
{
    public interface ILifecycleSettings
    {
        bool RestartOnAppFailure { get; set; }
        int AppFailureRestartDelaySeconds { get; set; }
    }
}
