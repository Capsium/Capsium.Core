namespace Capsium.Cloud;

/// <summary>
/// An abstraction for connection settings for the Capsium.Cloud service
/// </summary>
public interface ICapsiumCloudSettings
{
    /// <summary>
    /// The host name to use for authentication
    /// </summary>
    string Hostname { get; set; }
    /// <summary>
    /// The host name used for data exchange
    /// </summary>
    string DataHostname { get; set; }
    /// <summary>
    /// Enable to send health metrics to Capsium.Cloud
    /// </summary>
    bool EnableHealthMetrics { get; set; }
    /// <summary>
    /// Interval (in mins) to send health metrics
    /// </summary>
    int HealthMetricsInterval { get; set; }
}