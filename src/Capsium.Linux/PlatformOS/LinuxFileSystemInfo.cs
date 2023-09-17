using System;
using System.Collections.Generic;
using System.IO;

namespace Capsium;

public class LinuxFileSystemInfo : IPlatformOS.FileSystemInfo
{
    public override IEnumerable<IExternalStorage> ExternalStorage => throw new NotImplementedException();

    public override string FileSystemRoot => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".Capsium");

    internal LinuxFileSystemInfo()
    {
    }
}
