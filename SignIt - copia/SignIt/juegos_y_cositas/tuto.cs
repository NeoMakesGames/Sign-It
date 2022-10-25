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

        string URL = "a";

        int progreso = 0;
        public tuto()
        {
            InitializeComponent();
            this.Hide();
            endTutorial.Hide();
        }
        private void tuto_Load(object sender, EventArgs e)
        {
           tutoTimer.Enabled = true;
           tutoTimer.Start();
        }
        private void tutoTimer_Tick_1(object sender, EventArgs e)
        {
           switch (progreso)
           {         
                      case 0:
                           if (URL != Form1.imagePath + "\\Group 59.PNG")
                           {//72
                               URL = Form1.imagePath + "\\Group 59.PNG";
                               myimage = new Bitmap(URL);
                               panel1.BackgroundImage = myimage;
                           }
                           tutoReg.Hide();
                           break;
                          
                      case 1:
                          if (URL != Form1.imagePath + "\\Group 61.PNG")
                          {
                              URL = Form1.imagePath + "\\Group 61.PNG";
                              myimage = new Bitmap(URL);
                              panel1.BackgroundImage = myimage;
                          }
                          skipTutorial.Hide();
                          tutoReg.Show();
                          break;
                   
                      case 2:
                          if (URL != Form1.imagePath + "\\Group 62.PNG")
                          {
                              URL = Form1.imagePath + "\\Group 62.PNG";
                              myimage = new Bitmap(URL);
                              panel1.BackgroundImage = myimage;
                          }   
                          tutocont.Show();
                          endTutorial.Hide();
                          break;
                  
                      case 3:
                    //        if (URL != "C:\\Users\\48110679\\Downloads\\5d87d6e6211d5.jpeg")
                    //        {
                    //            URL = "C:\\Users\\48110679\\Downloads\\5d87d6e6211d5.jpeg";
                    //            myimage = new Bitmap(URL);
                    //            panel1.BackgroundImage = myimage;
                    //        }
                              tutocont.Hide();
                              endTutorial.Show();
                              break;
                      
                    }
            }

        private void elprincipiodelfin()
        {
            tutoTimer.Stop();
            tutoTimer.Enabled = false;
            this.Hide();
            Form1.endTutorial = true;
            DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, Form1.path);
            Form1.avance++;
        }

        private void skipTutorial_Click(object sender, EventArgs e)
        {
            elprincipiodelfin();
        }

        private void tutocont_Click_1(object sender, EventArgs e)
        {
            progreso++;
        }

        private void tutoReg_Click_1(object sender, EventArgs e)
        {
                progreso--;
        }

        private void endTutorial_Click(object sender, EventArgs e)
        {
            elprincipiodelfin();
        }
    }
}