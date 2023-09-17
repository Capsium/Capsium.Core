using Capsium.Devices;
using Capsium.Hardware;

namespace Capsium.Simulation
{
    public interface ISimulatedDevice<TPinDefinitions> : ICapsiumDevice
        where TPinDefinitions : IPinDefinitions
    {
        TPinDefinitions Pins { get; }
    }
}
