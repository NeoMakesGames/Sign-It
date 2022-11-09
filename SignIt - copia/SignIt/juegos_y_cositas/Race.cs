using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
        bool jugando;
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
            panelrace.Hide();
            reStart();

            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
        private void reproduccion()
        {
            Random rdn = new Random();
            int id = rdn.Next(1, 60);
            id_ = id;

            OpenFileDialog opf = new OpenFileDialog();
            axWindowsMediaPlayer1.URL = Form1.signsPath + DatabaseFunctions.GetNameOfVideo(id, Form1.path) + ".wmv";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void reStart()
        {
            RaceButtonStart.Show();
            RaceTextBox.Hide();
            imagenTimer.Hide();
            axWindowsMediaPlayer1.Hide();
            panelrace.Hide();
            finalRaceText.Hide();
            endRacePoints.Hide();
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
            else if (minutos < 10 && segundos > 10)
            {
                Contador.Text = "0" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            }
            else if (segundos < 10 && minutos > 10)
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
            jugando = true;
            finalRaceText.Text = "¡Buen intento";
            endRacePoints.Text = "Puntuación";
            puntos = 0;

            RacePoints.Text = "Tus puntos:  0";
            Contador.Text = "00:15";
            raceTimer = 15000;

            RaceButtonStart.Hide();
            finalRaceText.Hide();
            endRacePoints.Hide();
            panelrace.Show();
            RaceTextBox.Show();
            axWindowsMediaPlayer1.Show();
            imagenTimer.Show();
            panelrace.Show();

            reproduccion();
            
            TimerRace.Start();
            TimerRace2.Start();
            TimerRace.Enabled = true;
            TimerRace2.Enabled = true;

        }

        //Timers

        private void TimerRace_Tick(object sender, EventArgs e)
        {
            if (jugando == true)
            {
                if (RaceTextBox.Text.ToLowerInvariant() == DatabaseFunctions.GetNameOfVideo(id_, Form1.path).ToLowerInvariant())
                {
                    raceTimer += 3000;
                    RaceTextBox.Text = "";
                    reproduccion();
                    puntos++;
                    RacePoints.Text = "Tus puntos:" + Convert.ToString(puntos);
                }
            }
        }

        private void TimerRace2_Tick(object sender, EventArgs e)
        {
            if (jugando == true)
            {
                raceTimer = raceTimer - 1000;
                counTer();

                if (raceTimer < 1000)
                {
                    jugando = false;    
                    
                    finalRaceText.Text = finalRaceText.Text + ": " + DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", Form1.path) + "!";
                    endRacePoints.Text = endRacePoints.Text + ": " + Convert.ToString(puntos);
                    
                    finalRaceText.Show();
                    endRacePoints.Show();
                    imagenTimer.Hide();
                    panelrace.Hide();
                    TimerRace.Stop();
                    TimerRace2.Stop();
                    TimerRace.Enabled = false;
                    TimerRace2.Enabled = false;

                    TimerRace2.Stop();
                    TimerRace2.Enabled = false;
                    axWindowsMediaPlayer1.URL = "";
                    RaceTextBox.Hide();

                    RaceButtonStart.Show();

                    axWindowsMediaPlayer1.Hide();
                    axWindowsMediaPlayer1.URL = "";

                    RacePoints.Text = "";
                    RaceTextBox.Text = "";
                    Contador.Text = "";
                }
            }
        }

        //Botones
        private void ExitRace_Click(object sender, EventArgs e)
        {
            exit();
            RaceTextBox.Text = "Escribe la definición antes de que se acabe el tiempo";
            RaceTextBox.ForeColor = Color.Silver;
        }
        private void endExitRaceButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RaceButtonStart.Show();
            axWindowsMediaPlayer1.URL = "";
            Form1.externalmenu = true;
            finalRaceText.Hide();
            endRacePoints.Hide();
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

        private void endRacePoints_Click(object sender, EventArgs e)
        {

        }

        private void finalRaceText_Click(object sender, EventArgs e)
        {

        }

        private void RaceTextBox_Click(object sender, EventArgs e)
        {
            RaceTextBox.Text = "";
            RaceTextBox.ForeColor = Color.Black;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

    }
}