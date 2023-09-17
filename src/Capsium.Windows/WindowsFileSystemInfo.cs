using System;
using System.Collections.Generic;
using System.IO;

namespace Capsium
{
    public class WindowsFileSystemInfo : IPlatformOS.FileSystemInfo
    {
        public override IEnumerable<IExternalStorage> ExternalStorage => throw new NotImplementedException();

        public override string FileSystemRoot { get; }

        internal WindowsFileSystemInfo()
        {
            // create the Capsium root folder
            var di = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capsium"));
            if (!di.Exists)
            {
                di.Create();
            }

            FileSystemRoot = di.FullName;
        }
    }
}
