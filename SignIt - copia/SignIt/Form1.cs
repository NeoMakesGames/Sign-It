using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIt
{
    public partial class Form1 : Form
    {
        //public static string path = "C:\\Users\\47436334\\Documents\\GitHub\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        //public static string path = "C:\\Users\\48110679\\source\\repos\\SignIt - copia\\SignIt\\Usuarios.accdb";
        public static string path = "C:\\Users\\benjd\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Usuarios.accdb";
        int menuX = -210;
        //int paneltransition = -1366;
        public bool menu = false;
        public int pantalla;
        public static bool externalmenu = false;
        public bool fullscr = true;
        int UserXp;
        int UserLvl = 0;
        int NextLvl = 10;
        public Form1()
        {
            InitializeComponent();
        }



        //Funciones

        private void noMENU()
        {
            Menubutton.Hide();
            panel1.Hide();
            panel1.Location = new Point(-210, 0);
        }
        private void MENU()
        {
            panel1.Show();
            panel1.BringToFront();
            Menubutton.Show();
            Menubutton.BringToFront();
        }
        private void IDT()
        {
            label1CdU.Hide();
            label2IdS.Hide();
            UserCdU.Text = "";
            UserIdS.Text = "";
        }
        private void X()
        {
            this.Close();
        }

        private void XP()
        {
            while (UserXp > NextLvl)
            {
                UserLvl += 1;
                UserXp -= NextLvl;
                NextLvl *= 2;
            }
        }
        private void buttons()
        {
            SnapBackToReality.FlatStyle = FlatStyle.Flat;
            SnapBackToReality.FlatAppearance.BorderSize = 0;
            Menubutton.FlatStyle = FlatStyle.Flat;
            Menubutton.FlatAppearance.BorderSize = 0;
            MemotestGamesButton.FlatStyle = FlatStyle.Flat;
            MemotestGamesButton.FlatAppearance.BorderSize = 0;
            RaceGamesButton.FlatStyle = FlatStyle.Flat;
            RaceGamesButton.FlatAppearance.BorderSize = 0;
        }
            //Comienzo 
            private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            IDT();
            noMENU();
            signIt.SelectedTab = IdS;
            buttons();
        }

        private void transición()
        {
            Random rdn = new Random();
            int transicion = rdn.Next(0, 3);
            if (transicion == 0)
            {

            }
        }
//mover 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

//Inicio de Sesión
        private async void ComenzarIds_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfNameExists(UserIdS.Text, path) == true)
            {
                signIt.SelectedTab = Home;   
                MENU();
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserIdS.Text, path);
                UserXp = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "XP", path));
                XP();
                UserHome.Text = DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", path);
                await Task.Delay(250);
            }
            else
            {
                label2IdS.Show();
            }
        }

        private void linkLabel1IdS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signIt.SelectedTab = CdU;
            IDT();
        }
        private void SalirIdS_Click(object sender, EventArgs e)
        {
            X();
        }

//Creación de Usuario
        private async void ComenzarCdU_Click(object sender, EventArgs e)
        {
            if (!DatabaseFunctions.checkIfThereAreUsers(path))
            {
                DatabaseFunctions.addUser(UserCdU.Text, path);
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserIdS.Text, path);
                signIt.SelectedTab = Home;
                MENU();
                await Task.Delay(250);
            }
            else if (DatabaseFunctions.checkIfThereAreUsers(path))
            {
                if (!DatabaseFunctions.checkIfNameExists(UserCdU.Text, path))
                {
                    DatabaseFunctions.addUser(UserCdU.Text, path);
                    DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserIdS.Text, path);
                    signIt.SelectedTab = Home;
                    await Task.Delay(250);
                    MENU();
                }
                else
                {
                    label1CdU.Show();
                }
            }
        }
        private void SnapBackToReality_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = IdS;
            IDT();
        }

//Home
        private void DiccionarioHome_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            pantalla = 3;
            panel1.SendToBack();
            menu = false;
        }

        private void LeccionesHome_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;
            pantalla = 2;
            panel1.SendToBack();
            menu = false;
        }

        //Menu

        private void Menubutton_Click(object sender, EventArgs e)
        {
            Menubutton.Enabled = false;
            if (menu == false)
            {
                while (menuX < 0)
                {
                    panel1.BringToFront();
                    panel1.Location = new Point(menuX, 0);
                    menuX += 2;
                    Menubutton.BringToFront();
                }
                //await Task.Delay(50);
                Menubutton.Enabled = true;
                menu = true;
            }
            else if (menu == true)
            {
                while (menuX > -210)
                {
                    panel1.Location = new Point(menuX, 0);
                    menuX -= 10;
                    Menubutton.BringToFront();
                }
                Menubutton.BringToFront();
                //await Task.Delay(50);
                Menubutton.Enabled = true;
                menu = false;
            }
        }

        private void MenuHomeButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Home;
            pantalla = 1;
            Menubutton_Click(sender, e);
            menu = false;
        }
        private void MenuLectionsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;
            pantalla = 1;
            Menubutton_Click(sender, e);
            menu = false;
        }
        private void MenuDiccionarioButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            pantalla = 1;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuGamesButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = juegos;
            pantalla = 1;
            Menubutton_Click(sender, e);
            menu = false;
        }
        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Ajustes;
            UserNameSett.Text = UserNameSett.Text + DatabaseFunctions.getString(DatabaseFunctions.currentUser,"Nombre",path);
            pantalla = 1;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuExitButton_Click(object sender, EventArgs e)
            {
                X();
            }
            
//Ajustes

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
//mover
private void IdS_Click(object sender, EventArgs e){}

//Juegos
        private void RaceGamesButton_Click(object sender, EventArgs e)
        {
            race1.Show();
            race1.BringToFront();
            noMENU();
        }

        private void MemotestGamesButton_Click(object sender, EventArgs e)
        {
            //Memotest.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //constantCheck
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (externalmenu == true)
            {
                MENU();
                externalmenu = false;
            }
            else
            {

            }
        }
    }
}
