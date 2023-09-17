using Capsium.Hardware;

namespace Capsium.Simulation
{
    internal class SimulationInformation : IDeviceInformation
    {
        public string DeviceName { get; set; } = "Capsium Simulator";
        public string Model { get; set; }
        public CapsiumPlatform Platform => CapsiumPlatform.CapsiumSimulation;
        public string ProcessorType => "Unknown";
        public string ProcessorSerialNumber => "SIMULATOR";
        public string ChipID => "SIM";
        public string CoprocessorType => "None";
        public string? CoprocessorOSVersion => null;
        public string UniqueID => "SIM";
        public string OSVersion => "SIM";
    }
}