using Capsium.Update;
using System.Collections.Generic;
using Capsium.Cloud;

namespace Capsium;

internal class MeadowAppSettings : IAppSettings
{
    public ILoggingSettings LoggingSettings { get; set; } = new MeadowLoggingSettings();
    public ILifecycleSettings LifecycleSettings { get; set; } = new MeadowLifecycleSettings();
    public IUpdateSettings UpdateSettings { get; set; } = new MeadowUpdateSettings();
    public IMeadowCloudSettings MeadowCloudSettings { get; set; } = new MeadowCloudSettings();
    public Dictionary<string, string> Settings { get; set; } = new();
}
