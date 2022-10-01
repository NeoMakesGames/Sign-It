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
        public Race()
        {
            InitializeComponent();
            restartEndRaceButton.FlatStyle = FlatStyle.Flat;
            restartEndRaceButton.FlatAppearance.BorderSize = 0;
            endExitRaceButton.FlatAppearance.BorderSize = 0;
            endExitRaceButton.FlatStyle = FlatStyle.Flat;
            ExitRace.FlatStyle = FlatStyle.Flat;
            ExitRace.FlatAppearance.BorderSize = 0;
            imagenTimer.FlatStyle = FlatStyle.Flat;
            imagenTimer.FlatAppearance.BorderSize = 0;
            RaceButtonStart.FlatStyle = FlatStyle.Flat;
            RaceButtonStart.FlatAppearance.BorderSize = 0;
        }
        private void Race_Load(object sender, EventArgs e)
        {
            this.Hide();

            TimerRace.Stop();
            TimerRace2.Stop();

            reStart();

            endRacePanel.BringToFront();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            endRacePanel.Hide();
        }
        //

        //no shit, no pude :(
        private void reproduccion()
        {
            Random rdn = new Random();
            int id = rdn.Next(0, 2);

            OpenFileDialog opf = new OpenFileDialog();
           //axWindowsMediaPlayer1.URL = DatabaseFunctions.getString(id, "Signs", Form1.path)+".wmv";
            //DatabaseFunctions.playVideo(id, axWindowsMediaPlayer1, Form1.path);

            axWindowsMediaPlayer1.URL = "C:\\Users\\benjd\\Videos\\6vbqj6.wmv";
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
            this.Hide();
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

            RaceButtonStart.Hide();
            RaceTextBox.Show();
            axWindowsMediaPlayer1.Show();
            imagenTimer.Show();

            raceTimer = 10000;

            reproduccion();
            TimerRace.Start();
            TimerRace2.Start();
        }

        //Timers

        private void TimerRace_Tick(object sender, EventArgs e)
        {
            //poner palabra
            if (RaceTextBox.Text == "hola")
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

                axWindowsMediaPlayer1.Hide();
                axWindowsMediaPlayer1.URL = "";

                RacePoints.Text = "";
                RaceTextBox.Text = "";
                Contador.Text = "";
                
                raceEndpanel();
                TimerRace2.Stop();
                TimerRace2.Enabled= false;
                axWindowsMediaPlayer1.URL = "";
                endRacePanel.BringToFront();
                endRacePanel.Show();
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
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        //prueba de verificacion

    }
}