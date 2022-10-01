using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SignIt
{
    public partial class Race : UserControl
    {
        int raceTimer;
        public static bool jugandoRace;
        int puntos;
        public Race()
        {
            InitializeComponent();
        }
        private void Race_Load(object sender, EventArgs e)
        {
            this.Hide();
            RaceButtonStart.Show();
            axWindowsMediaPlayer1.URL = "";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            TimerRace.Stop();
            TimerRace2.Stop();
        }
        //no shit, no pude :(
        private void reproduccion()
        {
            Random rdn = new Random();
            int id = rdn.Next(0, 2);
            OpenFileDialog opf = new OpenFileDialog();
            //axWindowsMediaPlayer1.URL = DatabaseFunctions.getString(id, "Signs", Form1.path);
            //DatabaseFunctions.playVideo(id, axWindowsMediaPlayer1, Form1.path);

            axWindowsMediaPlayer1.URL = "C:\\Users\\benjd\\Videos\\6vbqj6.wmv";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void RaceButtonStart_Click(object sender, EventArgs e)
        {
            puntos = 0;
            RaceButtonStart.Hide();
            raceTimer = 10000;
            reproduccion();
            TimerRace.Start();
            TimerRace2.Start();
        }

        private void TimerRace2_Tick(object sender, EventArgs e)
        {
            raceTimer = raceTimer - 1000;
            RacePoints.Text = Convert.ToString(puntos);
            if (raceTimer < 1)
            {
                TimerRace.Stop();
                TimerRace.Enabled = false;
                TimerRace2.Stop();
                TimerRace2.Enabled= false;
                exit();
                //mostrar rtados
            }
        }
        private void TimerRace_Tick(object sender, EventArgs e)
        {
            //poner palabra
            if(RaceTextBox.Text == "hola")
            {
                raceTimer += 3000;
                reproduccion();
                puntos++;
            }
        }

        private void ExitRace_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            this.Hide();
            RaceButtonStart.Show();
            axWindowsMediaPlayer1.URL = "";
            Form1.externalmenu = true;
        }
    }
}