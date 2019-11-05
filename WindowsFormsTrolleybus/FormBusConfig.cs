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
    public partial class FormBusConfig : Form
    {
        ITransport bus = null;

        public FormBusConfig()
        {
            InitializeComponent();
        }

        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {

        }

    }
}
