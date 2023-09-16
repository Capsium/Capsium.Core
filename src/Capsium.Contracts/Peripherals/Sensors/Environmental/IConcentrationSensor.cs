using Capsium.Units;
using System;

namespace Capsium.Peripherals.Sensors.Environmental
{
    /// <summary>
    /// Light sensor interface requirements.
    /// </summary>
    public interface IConcentrationSensor : ISamplingSensor<Concentration>
    {
        /// <summary>
        /// Last value read from the Concentration sensor.
        /// </summary>
        Concentration? Concentration { get; }

        /// <summary>
        /// Raised when a change in C=concentration is detected.
        /// </summary>
        event EventHandler<IChangeResult<Concentration>> ConcentrationUpdated;
    }
}