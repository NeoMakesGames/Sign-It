namespace Sign_It_App
{
    public partial class Form1 : Form
    {
        public int menu = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IdS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (2==2)
            {
                noIdS();
            }
            else
            {
                label2Ids.Show();
            }

            if()
        }

        private void linkLabel1IdS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void IdS ()
        {
            inicioDeSesión1.Show();
            ComenzarIds.Show();
            UserInicioDeSesion.Show();
            linkLabel1IdS.Show();

        }
        private void noIdS()
        {
            inicioDeSesión1.Hide();
            ComenzarIds.Hide();
            UserInicioDeSesion.Hide();
            linkLabel1IdS.Hide();
            label2Ids.Hide();

        }
        private void CdS ()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (menu ==  0)
            {
                panel1.Show();
                menu = 1;
            }
            else if (menu == 1)
            {
                panel1.Hide();
                menu = 0;
            }
        }
    }
}