﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    class BusStationOccupiedPlaceException : Exception
    {
        public BusStationOccupiedPlaceException(int i) : base("На месте " + i + "уже стоит автобус")
        { } 
    }
}
