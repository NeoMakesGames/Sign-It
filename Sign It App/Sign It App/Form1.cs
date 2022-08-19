namespace Sign_It_App
{
    public partial class Form1 : Form
    {
        public int menu = 0;
        string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IdS();
            panel1.Hide();
            Menubutton.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfThereAreUsers(path) == true)
            {
                if (DatabaseFunctions.checkIfNameExists(path) == true)
                {
                    noIdS();
                }
                else
                {
                    label2Ids.Show();
                }
                
            }
            else
            {
                label2Ids.Show();
            }
        }

        private void linkLabel1IdS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void IdS()
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
            creacionDeUsuario1.Show();

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