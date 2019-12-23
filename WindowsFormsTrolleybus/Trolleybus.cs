using System;
using System.Drawing;

namespace WindowsFormsTrolleybus
{
    public class Trolleybus : Bus, IComparable<Trolleybus>, IEquatable<Trolleybus>
    {
        public Color DopColor { private set; get; }
        public bool Antenna { private set; get; }
        public bool Windows { private set; get; }
        public bool Number { private set; get; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес троллейбуса</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public Trolleybus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool num, bool antenna, bool windows) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Number = num;
            Antenna = antenna;
            Windows = windows;

        }
        public Trolleybus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Number = Convert.ToBoolean(strs[4]);
                Antenna = Convert.ToBoolean(strs[5]);
                Windows = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawBus(Graphics g)
        {

            Pen blackpen = new Pen(Color.Black);

            base.DrawBus(g);

            //window
            if (Windows)
            {
                Brush blueBrush = new SolidBrush(Color.LightSkyBlue);

                g.DrawRectangle(blackpen, _startPosX + 10, _startPosY + 20, 5, 5);
                g.FillRectangle(blueBrush, _startPosX + 10, _startPosY + 20, 5, 5);


                g.DrawRectangle(blackpen, _startPosX + 74, _startPosY + 20, 5, 5);
                g.FillRectangle(blueBrush, _startPosX + 74, _startPosY + 20, 5, 5);

                g.DrawRectangle(blackpen, _startPosX + 81, _startPosY + 15, 13, 23);
                g.FillRectangle(blueBrush, _startPosX + 81, _startPosY + 15, 13, 23);
            }

            //antenna
            if (Antenna)
            {
                Pen blackPen = new Pen(DopColor, 3);
                Brush blackBrush = new SolidBrush(DopColor);


                g.DrawRectangle(blackpen, _startPosX + 25, _startPosY + 8, 40, 2);
                g.FillRectangle(blackBrush, _startPosX + 25, _startPosY + 8, 40, 2);
                g.DrawLine(blackPen, _startPosX + 40, _startPosY + 8, _startPosX - 10, _startPosY - 2);
                g.DrawLine(blackPen, _startPosX + 40, _startPosY + 8, _startPosX - 10, _startPosY + 3);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Number + ";" +
           Antenna + ";" + Windows;
        }

        public int CompareTo(Trolleybus other)
        {
            var res = (this is Bus).CompareTo(other is Bus);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Number != other.Number)
            {
                return Number.CompareTo(other.Number);
            }
            if ( Antenna != other.Antenna)
            {
                return Antenna.CompareTo(other.Antenna);
            }
            if (Windows != other.Windows)
            {
                return Windows.CompareTo(other.Windows);
            }
            return 0;
        }

        public bool Equals(Trolleybus other)
        {
            var res = (this as Bus).Equals(other as Bus);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Number != other.Number)
            {
                return false;
            }
            if (Antenna != other.Antenna)
            {
                return false;
            }
            if (Windows != other.Windows)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Trolleybus busObj))
            {
                return false;
            }
            else
            {
                return Equals(busObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
