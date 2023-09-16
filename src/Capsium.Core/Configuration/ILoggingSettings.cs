namespace Capsium
{
    public interface ILoggingSettings
    {
        bool ShowTicks { get; set; }
        ILogLevelSettings LogLevel { get; }
    }
}
