using System.Threading.Tasks;

namespace Capsium.Cloud;

/// <summary>
/// An abstraction for the Capsium.Cloud service
/// </summary>
public interface ICapsiumCloudService
{
    /// <summary>
    /// The current JWT
    /// </summary>
    string? CurrentJwt { get; }

    /// <summary>
    /// Authenticates with the Capsium.Cloud service
    /// </summary>
    Task<bool> Authenticate();

    /// <summary>
    /// Sends a log message to the Capsium.Cloud service
    /// </summary>
    /// <param name="cloudLog">The log entry to send</param>
    Task<bool> SendLog(CloudLog cloudLog);

    /// <summary>
    /// Sends a CloudEvent to the Capsium.Cloud service
    /// </summary>
    /// <param name="cloudEvent"></param>
    /// <returns></returns>
    Task<bool> SendEvent(CloudEvent cloudEvent);
}