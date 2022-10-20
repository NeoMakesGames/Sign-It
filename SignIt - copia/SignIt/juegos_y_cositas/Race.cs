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
        int segundos, minutos;
        int id_;
        string palabra;
        public Race()
        {
            InitializeComponent();
        }
        private void Race_Load(object sender, EventArgs e)
        {
            Hide();

            TimerRace.Stop();
            TimerRace2.Stop();
            TimerRace.Enabled = false; 
            TimerRace2.Enabled = false;

            reStart();

            endRacePanel.BringToFront();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            endRacePanel.Hide();
        }
        private void reproduccion()
        {
            Random rdn = new Random();
            int id = rdn.Next(0, 60);
            id_ = id;

            OpenFileDialog opf = new OpenFileDialog();
            axWindowsMediaPlayer1.URL = Form1.videosPath + DatabaseFunctions.GetNameOfVideo(id, Form1.path) + ".wmv";
            MessageBox.Show(axWindowsMediaPlayer1.URL);
            axWindowsMediaPlayer1.Ctlcontrols.play();

            palabra = DatabaseFunctions.GetNameOfVideo(id_, Form1.path);
            MessageBox.Show(palabra);
        }
        private void reStart()
        {
            RaceButtonStart.Show();
            RaceTextBox.Hide();
            imagenTimer.Hide();
            axWindowsMediaPlayer1.Hide();
            notraceEndpanel();

            RacePoints.Text = "";
            RaceTextBox.Text = "";
            Contador.Text = "";
            axWindowsMediaPlayer1.URL = "";
        }
        private void exit()
        {
            Hide();
            reStart();

            TimerRace.Stop();
            TimerRace2.Stop();
            TimerRace.Enabled = false;
            TimerRace2.Enabled = false;

            Form1.externalmenu = true;
        }
        private void raceEndpanel()
        {
            endRacePanel.Show();
            if (puntos <= 3)
            {
                finalRaceText.Text = "Mala leche " + DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", Form1.path) + "...Habrá que seguir practicando.";
            }
            else if (puntos > 3 && puntos < 10)
            {
                finalRaceText.Text = "Bien hecho " + DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", Form1.path) + ". Continua estudiando.";
            }
            else if (puntos > 10)
            {
                finalRaceText.Text = "Muy bien " + DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", Form1.path) + "! Continua intentado para conseguir más puntos";
            }
            endRacePoints.Text = "Puntuación: " + Convert.ToString(puntos);
        }
        private void notraceEndpanel()
        {
            endRacePanel.Hide();
            finalRaceText.Text = "";
            endRacePoints.Text = "";
        }

        private void counTer()
        {
            segundos = raceTimer / 1000;
            
            while (segundos >= 60)
            {
                segundos -= 60;
                minutos += 1;
            }

            if (segundos < 10 && minutos < 10)
            {
                Contador.Text = "0" + Convert.ToString(minutos) + ":" + "0" + Convert.ToString(segundos);
            }
            else if (minutos < 10)
            {
                Contador.Text = "0" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            }
            if (segundos < 10)
            {
                Contador.Text = Convert.ToString(minutos) + ":" + "0" + Convert.ToString(segundos);
            }
            else
            {
                Contador.Text = Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            }
        }
        
        //Start

        private void RaceButtonStart_Click(object sender, EventArgs e)
        {
            puntos = 0;

            RacePoints.Text = "Tus puntos: 0";
            Contador.Text = "00:10";

            TimerRace.Start();
            TimerRace2.Start();
            TimerRace.Enabled = true;
            TimerRace2.Enabled = true;

            RaceButtonStart.Hide();
            RaceTextBox.Show();
            axWindowsMediaPlayer1.Show();
            imagenTimer.Show();

            raceTimer = 10000;

            reproduccion();
        }

        //Timers

        private void TimerRace_Tick(object sender, EventArgs e)
        {
            
            //if (RaceTextBox.Text == DatabaseFunctions.GetNameOfVideo(id_, Form1.path))
            {
                raceTimer += 3000;
                reproduccion();
                RaceTextBox.Text = "";
                puntos++;
                RacePoints.Text = "Tus puntos:" + Convert.ToString(puntos);
            }
        }

        private void TimerRace2_Tick(object sender, EventArgs e)
        {
            raceTimer = raceTimer - 1000;
            counTer();

            if (raceTimer < 1)
            {
                TimerRace.Stop();
                TimerRace2.Stop();             
                TimerRace.Enabled = false;
                TimerRace2.Enabled = false;

                raceEndpanel();
                TimerRace2.Stop();
                TimerRace2.Enabled= false;
                axWindowsMediaPlayer1.URL = "";
                endRacePanel.BringToFront();
                endRacePanel.Show();

                axWindowsMediaPlayer1.Hide();
                axWindowsMediaPlayer1.URL = "";

                RacePoints.Text = "";
                RaceTextBox.Text = "";
                Contador.Text = "";                
            }
        }

        //Botones
        private void ExitRace_Click(object sender, EventArgs e)
        {
            exit();
        }
        private void endExitRaceButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RaceButtonStart.Show();
            axWindowsMediaPlayer1.URL = "";
            Form1.externalmenu = true;
            endRacePanel.Hide();
            endRacePanel.SendToBack();
        }

        private void restartEndRaceButton_Click(object sender, EventArgs e)
        {
            reStart();
        }

        //----//

        private void endPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RacePoints_Click(object sender, EventArgs e)
        {

        }
        private void RaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void endRacePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

    }
}