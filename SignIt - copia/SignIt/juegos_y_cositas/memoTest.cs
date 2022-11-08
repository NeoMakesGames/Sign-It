using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIt
{
    public partial class memoTest : UserControl
    {
        int[]idMemo = new int[9];
        int[] botones = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        public memoTest()
        {
            InitializeComponent();
            MemoTimerA.Enabled = true;
            MemoTimerA.Start();
        }

        private void memoTest_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitEj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.externalmenu = true;
        }

        private void MemoTimerA_Tick(object sender, EventArgs e)
        {
            if (Form1.Memotest == true)
            {
                Form1.Memotest = false;
                comenzar();
            }
        }

        private void comenzar()
        {
            this.Show();
            for (int i = 0; i < 9; )
            {
                bool trueId = true;
                int a = Form1.rdn.Next(1, 64);
                if (i < 1 && a != 0)
                {
                    idMemo[i] = a;
                    i++;
                    MessageBox.Show(a.ToString());
                }
                else
                {
                    foreach(int id in idMemo)
                    {
                        if (a == 0 || a == id)
                        {
                            trueId = false;
                        }
                    }
                    if (trueId == true)
                    {
                        MessageBox.Show(a.ToString() + i.ToString());
                        idMemo[i] = a;
                        i++;
                    }
                }
            }
            //termina de crear la lista de videos.
            foreach(int id in idMemo)
            {
                int b = Form1.rdn.Next(0, botones.Length);
                int c = Form1.rdn.Next(0, botones.Length);
                
                switch(b)
                {
                    case 1:
                        break;
                }
            }
        }
    }
}
