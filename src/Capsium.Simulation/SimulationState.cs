using System.Collections.Generic;

namespace Capsium.Simulation
{
    public class SimulationState
    {
        public Dictionary<string, double> PinStates { get; set; } = new Dictionary<string, double>();
    }
}
