using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIt
{
    public partial class tuto : UserControl
    {
        Image myimage;

        string URL;

        int avance;
        public tuto()
        {
            InitializeComponent();
            this.Hide();
        }
        private void tuto_Load(object sender, EventArgs e)
        {

        }

        private void tutotimer_Tick(object sender, EventArgs e)
        {
            switch (avance)
            {
                case 0:
                    if (URL != "C:\\Users\\benjd\\Pictures\\a.jpg")
                    {
                        URL = "";
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    tutoReg.Hide();
                    break;

                case 1:
                    if (URL != "C:\\Users\\benjd\\Pictures\\aa.jpg")
                    {
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    tutoReg.Show();
                    break;

                case 2:
                    if (URL != "C:\\Users\\benjd\\Pictures\\a.jpeg")
                    {
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    tutocont.Show();
                    break;

                case 3:
                    if (URL != "C:\\Users\\benjd\\Pictures\\a.jpg")
                    {
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    tutocont.Hide();
                    break;

                case 4:
                    elprincipiodelfin();
                    break;
            }
        }
        private void elprincipiodelfin()
        {
            this.Hide();
            Form1.endTutorial = true;
            DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, Form1.path);
        }

        private void skipTutorial_Click(object sender, EventArgs e)
        {
            elprincipiodelfin();
        }

        private void tutocont_Click_1(object sender, EventArgs e)
        {
            if (avance < 11)
            {
                avance++;
            }
        }

        private void tutoReg_Click_1(object sender, EventArgs e)
        {
            if (avance > 1)
            {
                avance--;
            }
        }
    }
}