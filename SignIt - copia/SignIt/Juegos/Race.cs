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
    public partial class Race : UserControl
    {
        public static bool jugandoRace = false;
        public Race()
        {
            InitializeComponent();
            this.Hide();
        }

        private void reproduccion()
        {
            //GetID
            Random rdn = new Random();
            int id = rdn.Next(0, 20);
            OpenFileDialog opf = new OpenFileDialog();
            //reproductor
            axWindowsMediaPlayer1.URL = "C:\\Users\\48110679\\Videos\\6v4ik0.wmv";//DatabaseFunctions.getString(id, "campo1", Form1.path);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private async void Race_Load(object sender, EventArgs e)
        {
            //Comienzo
            if (jugandoRace = true)
            {
                reproduccion();

            }
        }
    }
}
