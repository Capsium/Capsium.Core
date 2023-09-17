namespace Capsium
{
    public class LinuxApp<T> : App<T>
        where T : class, ICapsiumDevice, new()
    {
    }
}
