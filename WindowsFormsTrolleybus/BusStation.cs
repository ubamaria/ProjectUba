using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public class BusStation<T> where T : class, ITransport 
    {
        /// <summary>
        /// Словарь
        /// </summary>
        private Dictionary<int, T> _places;

        /// <summary>
        /// Максимальное количество мест на стоянке
        /// </summary>
        private int _maxCount;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }

        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>

        private const int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private const int _placeSizeHeight = 80;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест на автовокзале</param>
        /// <param name="pictureWidth">Размер автовокзала - ширина</param>
        /// <param name="pictureHeight">Размер автовокзала - высота</param>
        public BusStation(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на стоянку добавляется автобус
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="trolleybus">Добавляемый автобус</param>
        /// <returns></returns>
        public static int operator +(BusStation<T> p, T trolleybus)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, trolleybus);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь
        ///   объект</param>
        /// <returns></returns>
        public static T operator -(BusStation<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T trolleybus = p._places[index];
                p._places.Remove(index);
                return trolleybus;
            }
            return null;
        }

        /// <summary>
        /// Метод проверки заполнености парковочного места (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в
        ///  массиве)</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawBus(g);
            }

        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
