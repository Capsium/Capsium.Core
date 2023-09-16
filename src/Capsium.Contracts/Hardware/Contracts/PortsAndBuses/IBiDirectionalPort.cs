namespace Capsium.Hardware
{
    public interface IBiDirectionalPort : IDigitalInputPort, IDigitalOutputPort
    {
        PortDirectionType Direction { get; set; }
    }
}
