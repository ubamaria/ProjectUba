using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public abstract class PublicTransport : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки троллейбуса 
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая координата отрисовки троллейбуса
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth; //ширина
        /// <summary>
        /// высота окна отрисовки
        /// </summary>
        protected int _pictureHeight; //высота
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

        public abstract void DrawBus(Graphics g);
        public abstract void MoveTransport(Direction direction);
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
    }
}
