using System;

namespace Capsium.Hardware;

/// <summary>
/// Describes the direction of a port.
/// </summary>
[Flags]
public enum PortDirectionType : byte
{
    /// <summary>
    /// Can write.
    /// </summary>
    Output = 0,
    /// <summary>
    /// Can read.
    /// </summary>
    Input = 1
}