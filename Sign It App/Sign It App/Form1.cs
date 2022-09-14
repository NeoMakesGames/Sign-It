namespace Sign_It_App
{
    public partial class Form1 : Form
    {
        
        //string path = "C:\\Users\\47436334\\Documents\\GitHub\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        //string path = "C:\\Users\\benjd\\source\\repos\\NeoMakesGames\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        int menuX = -210;
        public int menu = 0;
        public int pantalla;
        bool fullscr = true;
        int UserXp;
        int UserLvl = 0;
        int NextLvl = 10;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IDT();
            noMENU();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            signIt.SelectedTab = IdS;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfNameExists(UserInicioDeSesion.Text, path) == true)
            {
                signIt.SelectedTab = Home;
                MENU();
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserInicioDeSesion.Text, path);
                UserXp = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "XP", path));
                while (UserXp > NextLvl)
                {
                    UserLvl += 1;
                    UserXp -= NextLvl;
                    NextLvl *= 2;
                }
                XPLVL.Text = Convert.ToString(UserLvl);
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
        private async void button1_Click_1(object sender, EventArgs e)
        {
            Menubutton.Enabled = false;
            if (menu == 0)
            {
                panel1.BringToFront();
                while (menuX < 0)
                {
                    panel1.Location = new Point(menuX, 0);
                    menuX += 2;
                }
                Menubutton.BringToFront();
                await Task.Delay(75);
                Menubutton.Enabled = true;
                menu = 1;
            }
            else if (menu == 1)
            {
                while (menuX > -210)
                {
                    panel1.Location = new Point(menuX, 0);
                    menuX -= 2;
                }
                Menubutton.BringToFront();
                await Task.Delay(75);
                Menubutton.Enabled = true;
                menu = 0;
            }
        }
        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            if (!DatabaseFunctions.checkIfThereAreUsers(path))
            {
                DatabaseFunctions.addUser(UserCdU.Text, path);
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserInicioDeSesion.Text, path);
                signIt.SelectedTab = Home;
            }
            else if (DatabaseFunctions.checkIfThereAreUsers(path))
            {
                if (!DatabaseFunctions.checkIfNameExists(UserCdU.Text, path))
                {
                    DatabaseFunctions.addUser(UserCdU.Text, path);
                    DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserInicioDeSesion.Text, path);
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
        private void MenuHomeButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Home;
            pantalla = 1;
            panel1.SendToBack();
            menu = 0;
        }

        private void MenuLectionsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;
            pantalla = 2;
            panel1.SendToBack();
            menu = 0;
        }

        private void MenuDiccionarioButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            pantalla = 3;
            panel1.SendToBack();
            menu = 0;
        }
        private void DiccionarioHome_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            pantalla = 3;
        }

        private void MenuGamesButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = juegos;
            pantalla = 4;
            panel1.SendToBack();
            menu = 0;
        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Ajustes;
            pantalla = 5;
            panel1.SendToBack();
            menu = 0;
            //
            UserNameSett.Text = UserNameSett.Text + " " + DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", path);
            XProgresBarSett.Text = Convert.ToString(UserLvl);
            XProgresBarSett.Maximum = NextLvl;
            XProgresBarSett.Value = UserXp;

        }

        private void FullScrButtonSett_Click(object sender, EventArgs e)
        {
            if (fullscr == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                FullScrButtonSett.Text = "Activado";
                fullscr = true;
            }
            else if (fullscr == true)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                FullScrButtonSett.Text = "Desactivado";
                fullscr = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            race2.Show();
            race2.BringToFront();
        }

        private void MemotestGameButton_Click(object sender, EventArgs e)
        {
            memotest1.Show();
            memotest1.BringToFront();
        }

        private void race2_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void label1CdU_Click(object sender, EventArgs e)
        {

        }
        private void UserCdU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}