﻿using Capsium.Hardware;
using System;
using System.Collections.Generic;

namespace Capsium;

public class WakeUpOptions
{
    public DateTime SleepUntil { get; set; }
    public TimeSpan SleepDuration { get; set; }
    public bool WakeOnNetwork { get; set; }
    public List<IDigitalInterruptPort> WakeOnInterruptPorts { get; } = new List<IDigitalInterruptPort>();

    public WakeUpOptions()
    {
    }
}
