using System;

namespace WindowsFormsTrolleybus
{
    class BusStationOccupiedPlaceException : Exception
    {
        public BusStationOccupiedPlaceException(int i) : base("На месте " + i + "уже стоит автобус")
        { } 
    }
}
