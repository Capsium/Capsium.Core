using Capsium.Hardware;
using System.IO;

namespace Capsium;

/// <summary>
/// A convenience class to retrieve information about the current runtime
/// </summary>
public static class RuntimeInformation
{
    private static CapsiumPlatform? _platform;

    /// <summary>
    /// Convenince method to check the current platform
    /// </summary>
    /// <param name="platform">The MeadowPlatform to check against</param>
    public static bool IsPlatform(CapsiumPlatform platform)
    {
        if (!_platform.HasValue)
        {
            // this is not a great way to do this, but for now....
            if (Directory.Exists("/meadow0"))
            {
                // we're an F7
                _platform = CapsiumPlatform.F7FeatherV1;
            }
            else
            {
                _platform = CapsiumPlatform.MeadowForLinux;
            }
        }

        return platform == _platform.Value;
    }
}
