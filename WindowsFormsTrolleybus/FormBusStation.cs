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
    public partial class FormBusStation : Form
    {
        BusStation<ITransport> station;
        public FormBusStation()
        {
            InitializeComponent();
            station = new BusStation<ITransport>(20, pictureBoxStation.Width, pictureBoxStation.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxStation.Width, pictureBoxStation.Height);
            Graphics gr = Graphics.FromImage(bmp);
            station.Draw(gr);
            pictureBoxStation.Image = bmp;
        }
        //припарковать автобус
        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new Bus(100, 1000, dialog.Color);
                int place = station + bus;
                Draw();
            }

        }
        //припарковать троллейбус
        private void buttonSetTrolleybus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new Trolleybus(100, 1000, dialog.Color, dialogDop.Color,
                   false, true, true);
                    int place = station + bus;
                    Draw();
                }
            }
        }
        //take
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                int a = Convert.ToInt32(maskedTextBoxPlace.Text) - 1;
                var bus = station - a;
                if (bus != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    bus.SetPosition(5, 5, pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    bus.DrawBus(gr);
                    pictureBoxTakeBus.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    pictureBoxTakeBus.Image = bmp;
                }
                Draw();
            }

        }

    }
}
