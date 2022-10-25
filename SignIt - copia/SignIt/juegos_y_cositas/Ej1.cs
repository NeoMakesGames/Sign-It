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
    public partial class Ej1 : UserControl
    {
        public Ej1()
        {
            InitializeComponent();
        }

        private void ej0cont_Click(object sender, EventArgs e)
        {
            Form1.continuar = true;
        }
    }
}
