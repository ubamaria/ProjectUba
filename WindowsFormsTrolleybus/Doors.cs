using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    class Doors
    {

        int count = 1;

        public void AddDoor()
        {
            if (count < 3)
            {
                count++;
            }
        }
        public void DeleteDoor()
        {
            if (count > 1)
            {
                count--;
            }
        }

        public void DrawDoors(Graphics g, float _startPosX, float _startPosY)
        {
            Pen blackpen = new Pen(Color.Black);
            Brush darkblueBrush = new SolidBrush(Color.DarkBlue);
            int sizedoor = 8;

            for (int i = 0; i < count; i++)
            {
                g.DrawRectangle(blackpen, _startPosX + 26 + 2 * sizedoor * i, _startPosY + 17, 5, 28);
                g.FillRectangle(darkblueBrush, _startPosX + 26 + 2 * sizedoor * i, _startPosY + 17, 5, 28);
            }
        }
    }
}
