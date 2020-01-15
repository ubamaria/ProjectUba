using System;

namespace WindowsFormsTrolleybus
{
    public class BusStationOverflowException : Exception 
    {
        public BusStationOverflowException() : base("На стоянке нет свободных мест")
        { }
    }
}
