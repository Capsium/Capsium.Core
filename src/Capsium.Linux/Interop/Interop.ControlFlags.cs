﻿using System;

namespace Capsium
{
    internal static partial class Interop
    {
        [Flags]
        public enum ControlFlags : uint
        {
            CSIZE = 0x30,
            CS5 = 0x00,
            CS6 = 0x10,
            CS7 = 0x20,
            CS8 = 0x30,
            PARENB = 0x100,
            CREAD = 0x80,
            CLOCAL = 0x800,
            PARODD = 0x200,
            CSTOPB = 0x40,

            /* c_cflag bit meaning */
            // **** THESE NUMBERS ARE IN OCTAL ****
            /*
            CBAUD = 0010017,
            B0 = 00000000,      
            B50 = 00000001,
            B75 = 00000002,
            B110 = 00000003,
            B134 = 00000004,
            B150 = 00000005,
            B200 = 00000006,
            B300 = 00000007,
            B600 = 00000010,
            B1200 = 00000011,
            B1800 = 00000012,
            B2400 = 00000013,
            B4800 = 00000014,
            B9600 = 00000015,
            B19200 = 00000016,
            B38400 = 00000017,
            EXTA = B19200,
            EXTB = B38400,
            
            
            HUPCL = 00002000,
            
            CBAUDEX = 00010000,
            BOTHER = 00010000,
            B57600 = 00010001,
            B115200 = 00010002,
            B230400 = 00010003,
            B460800 = 00010004,
            B500000 = 00010005,
            B576000 = 00010006,
            B921600 = 00010007,
            B1000000 = 00010010,
            B1152000 = 00010011,
            B1500000 = 00010012,
            B2000000 = 00010013,
            B2500000 = 00010014,
            B3000000 = 00010015,
            B3500000 = 00010016,
            B4000000 = 00010017,
            CIBAUD = 002003600000, 
            CMSPAR = 010000000000, 
            */
            CRTSCTS = 0x80000000	/* flow control */

        }
    }
}
