using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_It_App.Pantalla
{
    public partial class InicioDeSesión : UserControl
    {
        public InicioDeSesión()
        {
            InitializeComponent();
        }

        private void InicioDeSesión_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
