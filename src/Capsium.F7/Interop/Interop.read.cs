using System;
using System.Runtime.InteropServices;

namespace Capsium.Core
{
    internal static partial class Interop
    {
        public static partial class Nuttx
        {
            [DllImport(LIBRARY_NAME, SetLastError = true)]
            public static extern int read(IntPtr handle, byte[] buf, int n);
        }
    }
}
