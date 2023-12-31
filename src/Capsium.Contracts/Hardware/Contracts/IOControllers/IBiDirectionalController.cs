﻿using System;
namespace Capsium.Hardware
{
    /// <summary>
    /// Contract for devices that expose `IBiDirectionPort(s)`.
    /// </summary>
    public interface IBiDirectionalController : IPinController
    {
        /// <summary>
        /// Creates an `IBiDirectionPort` on the specified pin.
        /// </summary>
        /// <param name="pin"></param>
        /// <param name="initialState"></param>
        /// <param name="interruptMode"></param>
        /// <param name="resistorMode"></param>
        /// <param name="initialDirection"></param>
        /// <param name="debounceDuration"></param>
        /// <param name="glitchDuration"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        IBiDirectionalInterruptPort CreateBiDirectionalInterruptPort(
            IPin pin,
            bool initialState,
            InterruptMode interruptMode,
            ResistorMode resistorMode,
            PortDirectionType initialDirection,
            TimeSpan debounceDuration,
            TimeSpan glitchDuration,
            OutputType output = OutputType.PushPull
        );

        IBiDirectionalInterruptPort CreateBiDirectionalInterruptPort(
            IPin pin)
        {
            return CreateBiDirectionalInterruptPort(pin, false, InterruptMode.None, ResistorMode.Disabled, PortDirectionType.Input, TimeSpan.Zero, TimeSpan.Zero);
        }

        IBiDirectionalPort CreateBiDirectionalPort(
            IPin pin,
            bool initialState);

    }
}
