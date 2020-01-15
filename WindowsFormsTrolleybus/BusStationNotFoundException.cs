using System;

namespace WindowsFormsTrolleybus
{
    class BusStationNotFoundException : Exception
    {
        public BusStationNotFoundException(int i) : base("Не найден автобус по месту " + i)
        { }
    }
}
