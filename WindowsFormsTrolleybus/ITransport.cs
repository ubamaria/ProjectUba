using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrolleybus
{
    public interface ITransport
    {
        //установка позиций
        void SetPosition(int x, int y, int width, int height);

        //изменение направления перемещения
        void MoveTransport(Direction direction);

        //отрисовка троллейбуса
        void DrawBus(Graphics g);


        void SetMainColor(Color color);

    }
}
