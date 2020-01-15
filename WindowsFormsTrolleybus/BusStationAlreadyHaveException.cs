using System;

namespace WindowsFormsTrolleybus
{
    class BusStationAlreadyHaveException : Exception
    {
        public BusStationAlreadyHaveException() : base("На стоянке уже есть такой автобус")
        { }
    }
}
