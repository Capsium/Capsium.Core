using Capsium.Peripherals.Sensors.Buttons;

namespace Capsium.Peripherals.Sensors.Rotary
{
    /// <summary>
    /// Digital rotary encoder that uses two-bit Gray Code to encode rotation and has an integrated push button.
    /// </summary>
    public interface IRotaryEncoderWithButton : IRotaryEncoder, IButton
    {
    }
}
