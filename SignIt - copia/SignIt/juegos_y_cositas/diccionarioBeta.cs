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
        bool basico, comida, colores, lugares, pronombres, verbos = false;
        public static string verificacionDeTipo;
        int[] idCorrectas = new int[20];
        int a = 0;
        public diccionarioBeta()
        {
            InitializeComponent();
        }

        private void diccionarioBeta_Load(object sender, EventArgs e)
        {

        }

        private void diccionariobeta()
        {
            for (int i = 0; i < 100; i++)
            {
                if (verificacionDeTipo == DatabaseFunctions.getString(i, "Signs", Form1.path))
                {
                    idCorrectas[a] = i;
                }
            }
            
            for (int i = 0; i <= idCorrectas.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign", Form1.path);
                        DatabaseFunctions.GetURL(idCorrectas[i], Form1.path);
                        break;

                    case 1:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign", Form1.path);
                        break;

                    case 2:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign" , Form1.path);
                        break;

                    case 3:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign" , Form1.path);
                        break;

                    case 4:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign" , Form1.path);
                        break;

                    case 5:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign" , Form1.path);
                        break;
                {
                    case 6:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign" , Form1.path);
                        break;

                    case 7:
                        diccionarioButton1.Show();
                        diccionarioButton1.Text = DatabaseFunctions.getString(idCorrectas[i], "Sign" , Form1.path);
                        break;
                }
            }
            verificacionDeTipo = "";
        }
    }
}
