using Capsium.Cloud;
using Capsium.Update;
using System.Collections.Generic;

namespace Capsium
{
    /// <summary>
    /// Represents the IApp settings
    /// </summary>
    public interface IAppSettings
    {
        /// <summary>
        /// Gets the settings for Logging
        /// </summary>
        public ILoggingSettings LoggingSettings { get; }
        /// <summary>
        /// Gets the settings for the application lifecycle
        /// </summary>
        public ILifecycleSettings LifecycleSettings { get; }
        /// <summary>
        /// Gets the settings for the update service
        /// </summary>
        public IUpdateSettings UpdateSettings { get; }
        /// <summary>
        /// Gets the settings for Capsium.Cloud
        /// </summary>
        public ICapsiumCloudSettings MeadowCloudSettings { get; }
        /// <summary>
        /// Gets a dictionary of user supplied settings
        /// </summary>
        public Dictionary<string, string> Settings { get; }
    }
}
