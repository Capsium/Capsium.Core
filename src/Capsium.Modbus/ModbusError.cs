using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Capsium.ModBus.Unit.Tests")]

namespace Capsium.ModBus
{
    public class ModbusException : Exception
    {
        internal ModbusException(ModbusErrorCode errorCode, ModbusFunction function)
        {
            ErrorCode = errorCode;
            Function = function;
        }

        public ModbusErrorCode ErrorCode { get; private set; }
        public ModbusFunction Function { get; private set; }
    }
}
