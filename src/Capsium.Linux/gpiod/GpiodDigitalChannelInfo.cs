﻿using Capsium.Hardware;

namespace Capsium
{
    public class GpiodDigitalChannelInfo : DigitalChannelInfoBase
    {
        public GpiodDigitalChannelInfo(
            string name)
            : base(name, true, true, true, true, true, false, null)
        {
        }
    }
}
