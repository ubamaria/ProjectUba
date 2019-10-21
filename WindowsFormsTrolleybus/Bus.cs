using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public class Bus : PublicTransport
    {
        /// <summary>
        /// Ширина отрисовки троллейбуса
        /// </summary>
        protected const int trolbusWidth = 100;
        /// <summary>
        /// Высота отрисовки троллейбуса
        /// </summary>
        protected const int trolbusHeight = 60;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес троллейбуса</param>
        /// <param name="mainColor">Основной цвет</param>
        public Bus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
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

        public override void DrawBus(Graphics g)
        {
            Pen blackpen = new Pen(Color.Black);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush grayBrush = new SolidBrush(Color.Gray);
            Brush blueBrush = new SolidBrush(Color.LightSkyBlue);
            Brush darkorangeBrush = new SolidBrush(Color.DarkOrange);
            Brush yellowBrush = new SolidBrush(Color.Yellow);
            Brush orangeBrush = new SolidBrush(MainColor);
            Brush darkblueBrush = new SolidBrush(Color.DarkBlue);
            Brush whiteBrush = new SolidBrush(Color.White);

            //кузов
            g.DrawRectangle(blackpen, _startPosX, _startPosY + 10, trolbusWidth - 10, trolbusHeight - 20);
            g.FillRectangle(orangeBrush, _startPosX + 1, _startPosY + 11, trolbusWidth - 11, trolbusHeight - 22);

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
            g.DrawRectangle(blackpen, _startPosX + 18, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 18, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 34, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 34, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 50, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 50, _startPosY + 20, 5, 5);
            g.DrawRectangle(blackpen, _startPosX + 66, _startPosY + 20, 5, 5);
            g.FillRectangle(blueBrush, _startPosX + 66, _startPosY + 20, 5, 5);


            g.DrawRectangle(blackpen, _startPosX + 81, _startPosY + 15, 13, 23);
            g.FillRectangle(blueBrush, _startPosX + 81, _startPosY + 15, 13, 23);

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
