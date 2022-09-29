using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIt
{
    public partial class Race : UserControl
    {
        bool cambio = true;
        public static bool jugandoRace = false;
        public Race()
        {
            InitializeComponent();
            this.Hide();
        }

        private void Race_Load(object sender, EventArgs e)
        {
            if (jugandoRace = true)
            {
                while (1 == 1)
                {
                    Random rdn = new Random();
                    int id = rdn.Next(19);
                    RaceTextBox.Text = Convert.ToString(id);

                    while (RaceTextBox.Text != "hola")
                    {
                        OpenFileDialog opf = new OpenFileDialog();
                        axWindowsMediaPlayer1.URL = "C:\\Users\\48110679\\Videos\\6v4ik0.wmv";  //DatabaseFunctions.getString(id, "campo1", Form1.path);
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                }
                jugandoRace = false;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
