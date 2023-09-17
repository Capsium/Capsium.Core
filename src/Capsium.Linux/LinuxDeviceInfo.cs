﻿using Capsium.Hardware;
using System;
using System.IO;

namespace Capsium;

public class LinuxDeviceInfo : IDeviceInformation
{
    public string DeviceName { get; set; }
    public CapsiumPlatform Platform => CapsiumPlatform.CapsiumForLinux;
    public string UniqueID { get; private set; }

    internal LinuxDeviceInfo()
    {
        // unique id is at /var/lib/dbus/machine-id
        UniqueID = File.ReadAllText("/var/lib/dbus/machine-id").Trim();
        DeviceName = File.ReadAllText("/etc/hostname").Trim();

        ParseLsb();
    }

    private void ParseLsb()
    {
        // TODO:

        // /etc/os-release
    }

    public string Model => "[TBD]";

    public string ProcessorType => "[TBD]";

    public string ProcessorSerialNumber => "[TBD]";

    public string CoprocessorType => "[TBD]";

    public string? CoprocessorOSVersion => "[TBD]";

    public string OSVersion => throw new NotImplementedException();
}
