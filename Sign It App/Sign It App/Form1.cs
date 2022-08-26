namespace Sign_It_App
{
    public partial class Form1 : Form
    {
        public int menu = 0;
        public int pantalla = 0;
        public bool border = true;
        string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        public Form1()
        {
            DatabaseFunctions.currentUser = 0;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            clear();
            IdS();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (DatabaseFunctions.checkIfNameExists(UserInicioDeSesion.Text, path) == true)
                {
                    noIdS();
                    Home();
                    DatabaseFunctions.currentUser = DatabaseFunctions.getID(UserInicioDeSesion.Text, path);
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
        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            if (!DatabaseFunctions.checkIfThereAreUsers(path))
            {
                DatabaseFunctions.addUser(UserCdU.Text, path);
                DatabaseFunctions.currentUser = DatabaseFunctions.getID(UserInicioDeSesion.Text, path);
                Home();
                noCdU();
            }
            else if (DatabaseFunctions.checkIfThereAreUsers(path))
            {
                if (!DatabaseFunctions.checkIfNameExists(UserCdU.Text, path))
                {
                    DatabaseFunctions.addUser(UserCdU.Text, path);
                    DatabaseFunctions.currentUser = DatabaseFunctions.getID(UserInicioDeSesion.Text, path);
                    Home();
                    noCdU();
                }
                else
                {
                    label1CdU.Show();
                }
            }
        }
        private void IdS()
        {
            inicioDeSesión1.Show();
            ComenzarIds.Show();
            UserInicioDeSesion.Show();
            linkLabel1IdS.Show();
            noCdU();

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
            SnapBackToReality.Show();
            noIdS();
        }
        private void noCdU()
        {
            creacionDeUsuario1.Hide();
            ComenzarCdU.Hide();
            UserCdU.Hide();
            label1CdU.Hide();
            SnapBackToReality.Hide();
        }
        private void MENU()
        {
            Menubutton.Show();
            Menubutton.BringToFront();
            
        }
        private void noMENU()
        {
            Menubutton.Hide();
            panel1.Hide();
        }
        private void Home()
        {
            home1.Show();
            MENU();
        }
        private void noHome()
        {
            home1.Hide();
        }

        private void clear ()
        {
            noIdS();
            noCdU();
            noMENU();
            noHome();
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

        private void home2_Load(object sender, EventArgs e)
        {

        }

        private void MenuExitButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            noCdU();
            IdS();
        }
    }
}