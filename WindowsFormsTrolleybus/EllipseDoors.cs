using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public class EllipseDoors : IDoor
    {
        public float _startPosX;
        public float _startPosY;
        public EllipseDoors(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }

        public void DrawDoors(Graphics g, Color color)
        {
            Pen redpen = new Pen(Color.Red);
            Brush redBrush = new SolidBrush(Color.Red);

            g.DrawRectangle(redpen, _startPosX + 26, _startPosY + 20, 5, 20);
            g.DrawEllipse(redpen, _startPosX + 26, _startPosY + 16, 5, 5);
            g.DrawEllipse(redpen, _startPosX + 26, _startPosY + 38, 5, 5);

            g.FillRectangle(redBrush, _startPosX + 26, _startPosY + 20, 5, 20);
            g.FillEllipse(redBrush, _startPosX + 26, _startPosY + 16, 5, 5);
            g.FillEllipse(redBrush, _startPosX + 26, _startPosY + 38, 5, 5);

            g.DrawRectangle(redpen, _startPosX + 42, _startPosY + 20, 5, 20);
            g.DrawEllipse(redpen, _startPosX + 42, _startPosY + 16, 5, 5);
            g.DrawEllipse(redpen, _startPosX + 42, _startPosY + 38, 5, 5);

            g.FillRectangle(redBrush, _startPosX + 42, _startPosY + 20, 5, 20);
            g.FillEllipse(redBrush, _startPosX + 42, _startPosY + 16, 5, 5);
            g.FillEllipse(redBrush, _startPosX + 42, _startPosY + 38, 5, 5);

            g.DrawRectangle(redpen, _startPosX + 58, _startPosY + 20, 5, 20);
            g.DrawEllipse(redpen, _startPosX + 58, _startPosY + 16, 5, 5);
            g.DrawEllipse(redpen, _startPosX + 58, _startPosY + 38, 5, 5);

            g.FillRectangle(redBrush, _startPosX + 58, _startPosY + 20, 5, 20);
            g.FillEllipse(redBrush, _startPosX + 58, _startPosY + 16, 5, 5);
            g.FillEllipse(redBrush, _startPosX + 58, _startPosY + 38, 5, 5);
        }
    }
}
