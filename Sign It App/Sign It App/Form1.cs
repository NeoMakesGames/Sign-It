namespace Sign_It_App
{
    public partial class Form1 : Form
    {
        public int menu = 0;
        public int pantalla = 0;
        public bool border = true;
        public static int currUser;
        string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IDT();
            noMENU();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            signIt.SelectedTab = IdS;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (DatabaseFunctions.checkIfNameExists(UserInicioDeSesion.Text, path) == true)
                {
                    signIt.SelectedTab = Home;
                    MENU();
                    currUser = DatabaseFunctions.getID(UserInicioDeSesion.Text, path);
                }
                else
                {
                    label2Ids.Show();
                }
        }

        private void linkLabel1IdS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signIt.SelectedTab = CdU;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (menu == 0)
            {
                panel1.BringToFront();
                menu = 1;
                Menubutton.BringToFront();
            }
            else if (menu == 1)
            {
                panel1.SendToBack();
                menu = 0;
            }
        }
        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            if (!DatabaseFunctions.checkIfThereAreUsers(path))
            {
                DatabaseFunctions.addUser(UserCdU.Text, path);
                DatabaseFunctions.currentUser = DatabaseFunctions.getID(UserInicioDeSesion.Text, path);
                signIt.SelectedTab = Home;
            }
            else if (DatabaseFunctions.checkIfThereAreUsers(path))
            {
                if (!DatabaseFunctions.checkIfNameExists(UserCdU.Text, path))
                {
                    DatabaseFunctions.addUser(UserCdU.Text, path);
                    DatabaseFunctions.currentUser = DatabaseFunctions.getID(UserInicioDeSesion.Text, path);
                    signIt.SelectedTab = Home;
                    MENU();
                }
                else
                {
                    label1CdU.Show();
                }
            }
        }
       
        private void noMENU()
        {
            Menubutton.Hide();
            panel1.Hide();
        }
        private void MENU()
        {
            Menubutton.Show();
            Menubutton.BringToFront();
            panel1.Show();
            panel1.SendToBack();
        }
        private void IDT()
        {
            label1CdU.Hide();
            label2Ids.Hide();
        }
        private void label1CdU_Click(object sender, EventArgs e)
        {

        }

        private void UserCdU_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            signIt.SelectedTab = IdS;
        }

        private void SalirIdS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MenuHomeButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Home;
            pantalla = 1;
        }

        private void MenuLectionsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Lecciones;
            pantalla = 2;
        }

        private void MenuDiccionarioButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            pantalla = 3;
        }

        private void MenuGamesButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Juegos;
            pantalla = 4;
        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Ajustes;
            pantalla = 5;
        }
    }
}