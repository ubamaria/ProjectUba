using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public class DoorsWithOrnament : IDoor
    {

        public float _startPosX;
        public float _startPosY;
        public DoorsWithOrnament(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void DrawDoors(Graphics g, DoorEnum numberOfDoors, Color color)
        {
            Pen blackpen = new Pen(Color.Black);

            Pen greenPen = new Pen(Color.FromArgb(255, 0, 255, 0),3);
            Pen redPen = new Pen(Color.FromArgb(255, 255, 0, 0), 3);
            Pen bluePen = new Pen(Color.FromArgb(255, 0, 0, 255), 3);

            greenPen.Alignment = PenAlignment.Center;

            g.DrawRectangle(greenPen, _startPosX + 26, _startPosY + 17, 5, 28);
            g.DrawRectangle(blackpen, _startPosX + 26, _startPosY + 17, 5, 28);

            g.DrawRectangle(redPen, _startPosX + 42, _startPosY + 17, 5, 28);
            g.DrawRectangle(blackpen, _startPosX + 42, _startPosY + 17, 5, 28);

            g.DrawRectangle(bluePen, _startPosX + 58, _startPosY + 17, 5, 28);
            g.DrawRectangle(blackpen, _startPosX + 58, _startPosY + 17, 5, 28);

        }
    }
}
