using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTrolleybus
{
    public partial class FormTrolleybus : Form
    {
        private Trolleybus trolleybus;

        public FormTrolleybus()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            trolleybus.DrawTrolleybus(gr);
            pictureBoxTrolleybus.Image = bmp;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            trolleybus = new Trolleybus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true);

            trolleybus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    trolleybus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    trolleybus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    trolleybus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    trolleybus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }


        private void buttonAddDoor_Click(object sender, EventArgs e)
        {
            trolleybus.FuncAddDoor();
            Draw();
        }

        private void buttonDeleteDoor_Click(object sender, EventArgs e)
        {
            trolleybus.FuncDeleteDoor();
            Draw();
        }

    }
}
