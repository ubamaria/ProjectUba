using System;
using System.Drawing;

namespace WindowsFormsTrolleybus
{
    public class Trolleybus : Bus
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

            base (maxSpeed, weight, mainColor)

        {
            DopColor = dopColor;
            Number = num;
            Antenna = antenna;
            Windows = windows;

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
    }
}
