using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    class Trolleybus
    {
        /// <summary>
        /// Левая координата отрисовки троллейбуса 
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая координата отрисовки троллейбуса
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth; //ширина
        /// <summary>
        /// высота окна отрисовки
        /// </summary>
        private int _pictureHeight; //высота
        /// <summary>
        /// Ширина отрисовки троллейбуса
        /// </summary>
        private const int trolbusWidth = 100;
        /// <summary>
        /// Высота отрисовки троллейбуса
        /// </summary>
        private const int trolbusHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес троллейбуса
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { protected set; get; }
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

        private Doors doors;

        public Trolleybus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool num, bool antenna, bool windows)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Number = num;
            Antenna = antenna;
            Windows = windows;
            doors = new Doors();                           

        }
        //установка позиций
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - trolbusWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - trolbusHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
 public void FuncAddDoor()
        {
            doors.AddDoor();
        }
        public void FuncDeleteDoor()
        {
            doors.DeleteDoor();
        }
        public void DrawTrolleybus(Graphics g)
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

            //кузов
            g.DrawRectangle(blackpen, _startPosX, _startPosY + 10, trolbusWidth - 10, trolbusHeight - 20);
            g.FillRectangle(whiteBrush, _startPosX + 1, _startPosY + 11, trolbusWidth - 12, trolbusHeight - 22);

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

            //door

            doors.DrawDoors(g, _startPosX, _startPosY);

            //g.DrawRectangle(blackpen, _startPosX + 10, _startPosY + 17, 5, 28);
            //g.FillRectangle(darkblueBrush, _startPosX + 10, _startPosY + 17, 5, 28);


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
