using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public class RestangleDoors : IDoor
    {
        public float _startPosX;
        public float _startPosY;
        public RestangleDoors(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void DrawDoors(Graphics g, DoorEnum numberOfDoors, Color color)
        {
            Pen blackpen = new Pen(Color.Black);
            Brush darkblueBrush = new SolidBrush(Color.DarkBlue);


            g.DrawRectangle(blackpen, _startPosX + 26, _startPosY + 17, 5, 28);
            g.FillRectangle(darkblueBrush, _startPosX + 26, _startPosY + 17, 5, 28);

            g.DrawRectangle(blackpen, _startPosX + 42, _startPosY + 17, 5, 28);
            g.FillRectangle(darkblueBrush, _startPosX + 42, _startPosY + 17, 5, 28);

            g.DrawRectangle(blackpen, _startPosX + 58, _startPosY + 17, 5, 28);
            g.FillRectangle(darkblueBrush, _startPosX + 58, _startPosY + 17, 5, 28);

        }
    }
}
