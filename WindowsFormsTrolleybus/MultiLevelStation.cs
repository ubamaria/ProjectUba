using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    class MultiLevelStation
    {
        List<BusStation<ITransport,IDoor>> stationStages;

        private const int countPlaces = 20;

        public MultiLevelStation(int countStages, int pictureWidth, int pictureHeight)
        {
            stationStages = new List<BusStation<ITransport, IDoor>>();
            for (int i = 0; i < countStages; ++i)
            {
                stationStages.Add(new BusStation<ITransport, IDoor>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        public BusStation<ITransport, IDoor> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < stationStages.Count)
                {
                    return stationStages[ind];
                }
                return null;
            }
        }

    }
}