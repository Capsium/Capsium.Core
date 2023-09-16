using System;
namespace Capsium.Hardware
{
    /// <summary>
    /// Provides data from serial communication errors.
    /// </summary>
    public class SerialErrorReceivedEventArgs
    {
        public SerialErrorType EventType { get; }
    }
}
