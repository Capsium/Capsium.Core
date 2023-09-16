using System;

namespace Capsium.Hardware
{
    public class InterruptGroupInUseException : Exception
    {
        public int Group { get; }

        public InterruptGroupInUseException(int group)
            : base($"Interrupt group {group} is already in use")
        {
        }
    }
}
