﻿using Capsium.Units;
using System;

namespace Capsium.Peripherals.Sensors
{
    /// <summary>
    /// Pressure sensor interface requirements.
    /// </summary>
    public interface IBarometricPressureSensor : ISamplingSensor<Pressure>
    {
        /// <summary>
        /// Last value read from the Pressure sensor.
        /// </summary>
        Pressure? Pressure { get; }

        /// <summary>
        /// Raised when a new reading has been made. Events will only be raised
        /// while the driver is updating. To start, call the `StartUpdating()`
        /// method.
        /// </summary>
        event EventHandler<IChangeResult<Pressure>> PressureUpdated;
    }
}