﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hackland.AccessControl.Data.Enums
{
    public enum DoorStatus
    {
        Unknown,
        Open, //!MagneticBond && !Reed
        Closed, //!MagneticBond && Reed
        Locked, //MagneticBond && Reed
        Fault //MagneticBond && !Reed
    }
}
