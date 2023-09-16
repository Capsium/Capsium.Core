using System.Threading.Tasks;

namespace Capsium.Peripherals.Sensors.Image
{
    /// <summary>
    /// Represents a generic camera.
    /// </summary>
    public interface ICamera
    {
        /// <summary>
        /// Takes a picture.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        Task<bool> TakePicture(string filename);
    }
}
