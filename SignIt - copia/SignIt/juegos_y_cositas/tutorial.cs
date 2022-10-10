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
    public partial class tutorial : UserControl
    {
        Image myimage;

        string URL;

        int avance;
        public tutorial()
        {
            InitializeComponent();
            this.Hide();
        }

        private void tutorial_Load(object sender, EventArgs e)
        {
            tutotimer.Enabled = true;
            tutotimer.Start();
        }

        private void tutotimer_Tick(object sender, EventArgs e)
        {
            switch (avance)
            {
                case 0:
                    if (URL != "D:\\Images\\myImage1.jpg")
                    {
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    break;

                case 1:
                    if (URL != "D:\\Images\\myImage1.jpg")
                    {
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    break;

                case 2:
                    if (URL != "D:\\Images\\myImage1.jpg")
                    {
                        myimage = new Bitmap(URL);
                        this.BackgroundImage = myimage;
                    }
                    break;
            }
        }

        private void tutoreg_Click(object sender, EventArgs e)
        {
            if (avance == 1)
            {
                avance--;
            }    
        }

        private void tutocont_Click(object sender, EventArgs e)
        {
            if (avance == 1)
            {
                avance++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avance = 11;
        }
    }
}
