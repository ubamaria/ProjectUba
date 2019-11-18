using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    class MultiLevelStation
    {
        List<BusStation<ITransport>> stationStages;

        private const int countPlaces = 20;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;

        public MultiLevelStation(int countStages, int pictureWidth, int pictureHeight)
        {
            stationStages = new List<BusStation<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                stationStages.Add(new BusStation<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public BusStation<ITransport> this[int ind]
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
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLeveles:" + stationStages.Count);
                foreach (var level in stationStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var bus = level[i];
                        if (bus != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (bus.GetType().Name == "Bus")
                            {
                                sw.Write(i + ":Bus:");
                            }
                            if (bus.GetType().Name == "Trolleybus")
                            {
                                sw.Write(i + ":Trolleybus:");
                            }
                            sw.WriteLine(bus);
                        }
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            int counter = -1;
            ITransport bus = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string str = sr.ReadLine();
               
                if (str.Contains("CountLeveles"))
                {
                    //считываем количество уровней
                    int count = Convert.ToInt32(str.Split(':')[1]);
                    if (stationStages != null)
                    {
                        stationStages.Clear();
                    }
                    stationStages = new List<BusStation<ITransport>>(count);
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }

                while ((str = sr.ReadLine()) != null)
                {
                    //идем по считанным записям
                    if (str == "Level")
                    {
                        //начинаем новый уровень
                        counter++;
                        stationStages.Add(new BusStation<ITransport>(countPlaces,
        pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }
                    string[] splitStr = str.Split(':');
                    if (splitStr.Length > 2)
                    {
                        if (splitStr[1] == "Bus")
                        {
                            bus = new Bus(splitStr[2]);
                        }
                        else if (splitStr[1] == "Trolleybus")
                        {
                            bus = new Trolleybus(splitStr[2]);
                        }
                        stationStages[counter][Convert.ToInt32(splitStr[0])] = bus;
                    }
                }
                return true;
            }
        }
    }
}

