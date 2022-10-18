using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIt
{
    public partial class diccionarioBeta : UserControl
    {
        public static bool DB = false;
        public static string verificacionDeTipo;
        string a, b, c, d, e, f, g, h, i, j, k, l;


        int[] idCorrectas = new int[20];
        int z = 0;
        public diccionarioBeta()
        {
            InitializeComponent();
            Hide();
            panel1.Hide();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void diccionarioBeta_Load(object sender, EventArgs e)
        {

        }

         void diccionariobeta()
        {
            a = "";
            b = "";
            c = "";
            d = "";
            e = "";
            f = "";
            g = "";
            h = "";
            i = "";
            j = "";
            k = "";
            l = "";

            for (int x = 0; x < 100; x++)
            {
                if (verificacionDeTipo == DatabaseFunctions.getString(x, "Signs", Form1.path))
                {
                    idCorrectas[z] = x;
                    z++;
                }
            }
            
            for (int y = 0; y <= idCorrectas.Length; y++)
            {
                switch (y)
                {
                    case 0:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign", Form1.path);
                        a = DatabaseFunctions.GetURL(idCorrectas[y], Form1.path);
                        break;

                    case 1:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign", Form1.path);
                        break;

                    case 2:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign" , Form1.path);
                        break;

                    case 3:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign" , Form1.path);
                        break;

                    case 4:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign" , Form1.path);
                        break;

                    case 5:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign" , Form1.path);
                        break;
                
                    case 6:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign" , Form1.path);
                        break;

                    case 7:
                        dD1.Show();
                        dD1.Text = DatabaseFunctions.getString(idCorrectas[y], "Sign" , Form1.path);
                        break;
                }
            }

            verificacionDeTipo = "";
        }
        private void dD1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = a;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void dbPanelExit_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void diccionarioBetaExit_Click(object sender, EventArgs e)
        {
            dbPanelExit_Click(sender, e);
            Hide();
            verificacionDeTipo = "";
        }
        private void timerDB_Tick(object sender, EventArgs e)
        {
            if (DB == true)
            {
                diccionariobeta();
                DB = false;
            }
        }
    }
}
