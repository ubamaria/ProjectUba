using System.Drawing;

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
