using Capsium.Gateways;

namespace Capsium
{
    /// <summary>
    /// A contract for Capsium devices built on the STM32F7 hardware
    /// </summary>
    public interface IF7CapsiumDevice : ICapsiumDevice
    {
        IBluetoothAdapter? BluetoothAdapter { get; }
        ICoprocessor? Coprocessor { get; }
    }
}
