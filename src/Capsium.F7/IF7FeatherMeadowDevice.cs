using Capsium.Hardware;

namespace Capsium
{
    public interface IF7FeatherCapsiumDevice :
        IF7CapsiumDevice,
        IIOController<IF7FeatherPinout>
    {
    }
}
