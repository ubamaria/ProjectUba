using System;
using System.Drawing;

namespace WindowsFormsTrolleybus
{
    public class Trolleybus : Bus
    {
        private int TypeDoor;
        public Color DopColor { private set; get; }
        public bool Antenna { private set; get; }
        public bool Windows { private set; get; }
        public bool Number { private set; get; }

        public DoorEnum numberOfDoors { private set; get; }
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
            TypeDoor = new Random().Next(0, 3);
        }
       
        public override void DrawTrolleybus(Graphics g)
        {
            Pen blackpen = new Pen(Color.Black);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush grayBrush = new SolidBrush(Color.Gray);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush blueBrush = new SolidBrush(Color.LightSkyBlue);
            Brush darkorangeBrush = new SolidBrush(Color.DarkOrange);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Brush whiteBrush = new SolidBrush(Color.White);
            Brush darkblueBrush = new SolidBrush(Color.DarkBlue);

            IDoor door;
            switch (TypeDoor)
            {
                case 0:
                    door = new RestangleDoors(_startPosX, _startPosY);
                    break;
                case 1:
                    door = new EllipseDoors(_startPosX, _startPosY);
                    break;
                case 2:
                    door = new DoorsWithOrnament(_startPosX, _startPosY);
                    break;

                default:
                    door = new RestangleDoors(_startPosX, _startPosY);
                    break;
            }


            //кузов
            g.DrawRectangle(blackpen, _startPosX, _startPosY + 10, trolbusWidth - 10, trolbusHeight - 20);
            g.FillRectangle(whiteBrush, _startPosX + 1, _startPosY + 11, trolbusWidth - 12, trolbusHeight - 22);

            door.DrawDoors(g, numberOfDoors, DopColor);

            //kolesa
            g.DrawEllipse(blackpen, _startPosX, _startPosY + 48, 15, 15);
            g.FillEllipse(brownBrush, _startPosX, _startPosY + 48, 15, 15);
            g.DrawEllipse(blackpen, _startPosX + 75, _startPosY + 48, 15, 15);
            g.FillEllipse(brownBrush, _startPosX + 75, _startPosY + 48, 15, 15);

            g.DrawEllipse(blackpen, _startPosX + 4, _startPosY + 51, 7, 7);
            g.DrawEllipse(blackpen, _startPosX + 80, _startPosY + 51, 7, 7);
            g.FillEllipse(grayBrush, _startPosX + 4, _startPosY + 51, 7, 7);
            g.FillEllipse(grayBrush, _startPosX + 80, _startPosY + 51, 7, 7);

            //нижняя часть кузова
            g.DrawRectangle(blackpen, _startPosX - 5, _startPosY + 45, 90, 5);
            g.FillRectangle(darkblueBrush, _startPosX - 5, _startPosY + 45, 100, 5);

            //window
            g.DrawRectangle(blackpen, _startPosX + 2, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 2, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 10, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 10, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 18, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 18, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 34, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 34, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 50, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 50, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 66, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 66, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 74, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 74, _startPosY + 20, 5, 5);

            g.DrawRectangle(blackpen, _startPosX + 81, _startPosY + 15, 13, 23);
            g.FillRectangle(blueBrush, _startPosX + 81, _startPosY + 15, 13, 23);

            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);

            //antenna
            g.DrawRectangle(blackpen, _startPosX + 25, _startPosY + 8, 40, 2);
            g.FillRectangle(blackBrush, _startPosX + 25, _startPosY + 8, 40, 2);
            g.DrawLine(blackPen, _startPosX + 40, _startPosY + 8, _startPosX - 10, _startPosY - 2);
            g.DrawLine(blackPen, _startPosX + 40, _startPosY + 8, _startPosX - 10, _startPosY + 3);

            //fari
            g.DrawRectangle(blackpen, _startPosX - 3, _startPosY + 40, 4, 2);
            g.FillRectangle(darkorangeBrush, _startPosX - 3, _startPosY + 40, 4, 2);

            g.DrawRectangle(blackpen, _startPosX + 88, _startPosY + 40, 4, 2);
            g.FillRectangle(yellowBrush, _startPosX + 88, _startPosY + 40, 4, 2);

            Pen redpen = new Pen(Color.Red);

            //number
            g.DrawRectangle(blackpen, _startPosX + 84, _startPosY + 44, 10, 7);
            g.FillRectangle(whiteBrush, _startPosX + 84, _startPosY + 45, 10, 6);
            g.DrawLine(redpen, _startPosX + 87, _startPosY + 45, _startPosX + 87, _startPosY + 50);
            g.DrawLine(redpen, _startPosX + 87, _startPosY + 45, _startPosX + 85, _startPosY + 47);
            g.DrawLine(redpen, _startPosX + 91, _startPosY + 45, _startPosX + 91, _startPosY + 50);
            g.DrawLine(redpen, _startPosX + 91, _startPosY + 45, _startPosX + 89, _startPosY + 47);

            
        }
    }
}
