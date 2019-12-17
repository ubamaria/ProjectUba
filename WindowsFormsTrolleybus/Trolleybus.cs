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

        public DoorEnum DoorType { private set; get; }

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


            base.DrawBus(g);

            Pen blackpen = new Pen(Color.Black);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush blueBrush = new SolidBrush(Color.LightSkyBlue);
            Brush whiteBrush = new SolidBrush(Color.White);

            switch (new Random().Next(0, 3))
            {
                case 0:
                    DoorType = DoorEnum.One;
                    break;
                case 1:
                    DoorType = DoorEnum.Two;
                    break;
                case 2:
                    DoorType = DoorEnum.Three;
                    break;
                default:
                    DoorType = DoorEnum.One;
                    break;
            }

            IDoor door;
            switch (DoorType)
            {
                case DoorEnum.One:
                    door = new RectangleDoors(_startPosX, _startPosY);
                    break;
                case DoorEnum.Two:
                    door = new EllipseDoors(_startPosX, _startPosY);
                    break;
                case DoorEnum.Three:
                    door = new DoorsWithOrnament(_startPosX, _startPosY);
                    break;
                default:
                    door = new RectangleDoors(_startPosX, _startPosY);
                    break;
            }

            door.DrawDoors(g, DopColor);



            //window
            if (Windows)
            {


                g.DrawRectangle(blackpen, _startPosX + 10, _startPosY + 20, 5, 5);
                g.FillRectangle(blueBrush, _startPosX + 10, _startPosY + 20, 5, 5);

                g.DrawRectangle(blackpen, _startPosX + 74, _startPosY + 20, 5, 5);
                g.FillRectangle(blueBrush, _startPosX + 74, _startPosY + 20, 5, 5);


                g.DrawRectangle(blackpen, _startPosX + 81, _startPosY + 15, 13, 23);
                g.FillRectangle(blueBrush, _startPosX + 81, _startPosY + 15, 13, 23);
            }


            //window
            if (Windows)
            {

                g.DrawRectangle(blackpen, _startPosX + 10, _startPosY + 20, 5, 5);
                g.FillRectangle(blueBrush, _startPosX + 10, _startPosY + 20, 5, 5);


                g.DrawRectangle(blackpen, _startPosX + 74, _startPosY + 20, 5, 5);
                g.FillRectangle(blueBrush, _startPosX + 74, _startPosY + 20, 5, 5);
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

            Pen redpen = new Pen(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);

            if (Number)
            {
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
}
