﻿namespace Capsium.ModBus
{
    public sealed class ModbusWriteResult : IModbusResult
    {
        public short ItemsWritten { get; }

        public ModbusWriteResult(short itemsWritten)
        {
            ItemsWritten = itemsWritten;
        }
    }
}
