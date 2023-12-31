﻿using Capsium.Hardware;
using System;
using System.Net.NetworkInformation;

namespace Capsium.Devices;

/// <summary>
/// Represents a wired Ethernet network adapter
/// </summary>
public class WiredNetworkAdapter : NetworkAdapterBase, IWiredNetworkAdapter
{
    /// <summary>
    /// Creates an instance of a WiredNetworkAdapter
    /// </summary>
    /// <param name="ni">The associated native interface</param>
    public WiredNetworkAdapter(NetworkInterface ni)
        : base(ni)
    {
        if (ni.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
        {
            throw new ArgumentException();
        }
    }

    /// <summary>
    /// Creates an instance of a WiredNetworkAdapter
    /// </summary>
    public WiredNetworkAdapter()
        : base(NetworkInterfaceType.Ethernet)
    {
    }

    // TODO: determine a way to detect this
    /// <summary>
    /// Returns <b>true</b> if the adapter is connected, otherwise <b>false</b>
    /// </summary>
    public override bool IsConnected => true;
}
