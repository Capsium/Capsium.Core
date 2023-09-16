using System;

namespace Capsium.Cloud;

/// <summary>
/// A log message sent to Capsium.Cloud
/// </summary>
public class CloudLog
{
    /// <summary>
    /// The message's severity
    /// </summary>
    public string Severity { get; set; } = default!;
    /// <summary>
    /// The message's text
    /// </summary>
    public string Message { get; set; } = default!;
    /// <summary>
    /// The timestamp of the message
    /// </summary>
    public DateTime Timestamp { get; set; } = default!;
    /// <summary>
    /// Exception body of the message
    /// </summary>
    public string Exception { get; set; } = default!;
}