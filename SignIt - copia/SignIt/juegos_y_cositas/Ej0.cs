using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIt
{
    public partial class Ej0 : UserControl
    {
        public Ej0()
        {
            InitializeComponent();
        }

        private void ej0cont_Click(object sender, EventArgs e)
        {
            Form1.continuar = true;
        }
    }
}
