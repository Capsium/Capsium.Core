﻿namespace Capsium.Hardware
{
    /// <summary>
    /// Represents the communication channel information for an SPI channel.
    /// </summary>
    public interface ISpiChannelInfo : IDigitalChannelInfo
    {
        /// <summary>
        /// Gets the line types supported by the SPI channel.
        /// </summary>
        SpiLineType LineTypes { get; }
    }
}