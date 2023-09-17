﻿using Capsium.Hardware;

namespace Capsium
{
    public class RaspberryPiPlatformOS : LinuxPlatformOS
    {
        public override SerialPortName[] GetSerialPortNames()
        {
            return new SerialPortName[]
            {
                new SerialPortName("serial0", "/dev/serial0", Resolver.Device),
                new SerialPortName("ttyAMA0", "/dev/ttyAMA0", Resolver.Device)
            };
        }
    }
}
