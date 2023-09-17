using Capsium.Hardware;

namespace Capsium
{
    public interface IF7CoreComputeCapsiumDevice :
        IF7CapsiumDevice,
        IIOController<IF7CoreComputePinout>
    {
    }
}
