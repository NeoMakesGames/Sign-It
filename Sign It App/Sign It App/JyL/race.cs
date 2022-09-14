using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_It_App
{
    public partial class race : UserControl
    {
        public static int startmemo = 0;
        public race()
        {
            InitializeComponent();
            this.Hide();
        }

        private async void race_Load(object sender, EventArgs e)
        {
            for (int i = 3; i > 0; i++)
            {
                await Task.Delay(100);
                CounterRace.Text = Convert.ToString(i);
            }
        }
        private void racegame()
        {
           // ImagenesRace.Image = DatabaseFunctions.Get
        }
    }
}
