namespace Sign_It_App
{
    public partial class Form1 : Form
    {
        public int menu = 0;
        string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        public Form1()
        {
            InitializeComponent();
            clear();
            IdS();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfThereAreUsers(path) == true)
            {
                if (DatabaseFunctions.checkIfNameExists(UserInicioDeSesion.Text, path) == true)
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
            noIdS();
            CdU();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (menu == 0)
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
        private void CdU()
        {
            creacionDeUsuario1.Show();
            ComenzarCdU.Show();
            UserCdU.Show();
        }
        private void noCdU()
        {
            creacionDeUsuario1.Show();
            ComenzarCdU.Show();
            UserCdU.Show();
            label1CdU.Hide();
        }
        private void MENU()
        {
            Menubutton.Show();
            panel1.Show();
            panel1.SendToBack();
        }
        private void noMENU()
        {
            Menubutton.Hide();
            panel1.Hide();
        }

        private void clear ()
        {
            noIdS();
            noCdU();
            noMENU();
        }
        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfThereAreUsers(path) == false)
            {

            }
            else
            {
                label1CdU.Show();
            }
        }

        private void label1CdU_Click(object sender, EventArgs e)
        {

        }

        private void UserCdU_TextChanged(object sender, EventArgs e)
        {

        }

        private void creacionDeUsuario1_Load(object sender, EventArgs e)
        {

        }
    }
}