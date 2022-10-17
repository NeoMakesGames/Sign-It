using SignIt.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SignIt
{
    public partial class Form1 : Form
    {
        //public static string path = "C:\\Users\\47436334\\Documents\\GitHub\\Sign-It\\Sign It App\\Sign It App\\Usuarios.accdb";
        //public static string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Usuarios.accdb";
        //public static string videosPath = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Signs\\";
        public static string path = "C:\\Users\\BenjaDBF\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Usuarios.accdb";
        public static string videosPath = "C:\\Users\\BenjaDBF\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Signs\\";

        Image myimage;

        int menuX = -332;
        int UserXp;
        int UserLvl;
        int NextLvl = 10;
        int homeSlider = 0;
        double home_slider = 0;
        int avance;

        public bool menu = false;
        public bool fullscr = true;
        public static bool externalmenu = false;
        public static bool endTutorial = false;
        

        string HS_URL;
        public Form1()
        {
            InitializeComponent();
        }

        //Funciones

        private void desaparicionDelMenu()
        {
            Menubutton.Hide();
            panel1.Hide();
            panel1.Location = new Point(-332, 0);
        }
        
        private void aparicionDelMenu()
        {
            panel1.Show();
            panel1.BringToFront();
            Menubutton.Show();
            Menubutton.BringToFront();
        }
        
        private void cierre()
        {
            this.Close();
        }

        private void experiencia()
        {
            while (UserXp > NextLvl)
            {
                UserLvl += 1;
                UserXp -= NextLvl;
                NextLvl *= 2;
            }
        }

        private void diseñoDeBotones()
        {
            SnapBackToReality.FlatStyle = FlatStyle.Flat;
            SnapBackToReality.FlatAppearance.BorderSize = 0;

            MenuHomeButton.FlatStyle = FlatStyle.Flat;
            MenuHomeButton.FlatAppearance.BorderSize = 0;

            MenuLectionsButton.FlatStyle = FlatStyle.Flat;
            MenuLectionsButton.FlatAppearance.BorderSize = 0;

            MenuDiccionarioButton.FlatStyle = FlatStyle.Flat;
            MenuDiccionarioButton.FlatAppearance.BorderSize = 0;

            MenuGamesButton.FlatStyle = FlatStyle.Flat;
            MenuGamesButton.FlatAppearance.BorderSize = 0;

            MenuSettingsButton.FlatStyle = FlatStyle.Flat;
            MenuSettingsButton.FlatAppearance.BorderSize = 0;

            MenuExitButton.FlatStyle = FlatStyle.Flat;
            MenuExitButton.FlatAppearance.BorderSize = 0;

            Menubutton.FlatStyle = FlatStyle.Flat;
            Menubutton.FlatAppearance.BorderSize = 0;

            MemotestGamesButton.FlatStyle = FlatStyle.Flat;
            MemotestGamesButton.FlatAppearance.BorderSize = 0;

            RaceGamesButton.FlatStyle = FlatStyle.Flat;
            RaceGamesButton.FlatAppearance.BorderSize = 0;

            SalirIdS.FlatStyle = FlatStyle.Flat;
            SalirIdS.FlatAppearance.BorderSize = 0;

            ComenzarIds.FlatStyle = FlatStyle.Flat;
            ComenzarIds.FlatAppearance.BorderSize = 0;

            ComenzarCdU.FlatStyle = FlatStyle.Flat;
            ComenzarCdU.FlatAppearance.BorderSize = 0;

            LeccionesHome.FlatStyle = FlatStyle.Flat;
            LeccionesHome.FlatAppearance.BorderSize = 0;

            DiccionarioHome.FlatStyle = FlatStyle.Flat;
            DiccionarioHome.FlatAppearance.BorderSize = 0;

            sliderHomeIz.FlatStyle = FlatStyle.Flat;
            sliderHomeIz.FlatAppearance.BorderSize = 0;

            sliderHomeDer.FlatStyle = FlatStyle.Flat;
            sliderHomeDer.FlatAppearance.BorderSize = 0;

        }

        //private void  sliderDeLaHome()
        //{
        //    
        //
        //    if (homeSlider > 3)
        //    {
        //        homeSlider = 0;
        //    }
        //
        //    else if (homeSlider == 3)
        //    {
        //        if (HS_URL != "C:\\Users\\48110679\\Downloads\\images-1.jpg")
        //        {
        //            HS_URL = "C:\\Users\\48110679\\Downloads\\images-1.jpg";
        //            myimage = new Bitmap(HS_URL);
        //            sliderHome.BackgroundImage = myimage;
        //        }
        //    }
        //
        //    else if (homeSlider == 2)
        //    {
        //        if (HS_URL != "C:\\Users\\48110679\\Downloads\\a.jpg")
        //        {
        //            HS_URL = "C:\\Users\\48110679\\Downloads\\a.jpg";
        //            myimage = new Bitmap(HS_URL);
        //            sliderHome.BackgroundImage = myimage;
        //        }
        //    }
        //
        //    else if (homeSlider == 1)
        //    {
        //        if (HS_URL != "C:\\Users\\48110679\\Downloads\\5e25ddc5dcbba.jpeg")
        //        {
        //            HS_URL = "C:\\Users\\48110679\\Downloads\\5e25ddc5dcbba.jpeg";
        //            myimage = new Bitmap(HS_URL);
        //            sliderHome.BackgroundImage = myimage;
        //        }
        //    }
        //
        //    else if (homeSlider == 0)
        //    {
        //        if (HS_URL != "C:\\Users\\48110679\\Downloads\\5d87d6e6211d5.jpeg")
        //        {
        //            HS_URL = "C:\\Users\\48110679\\Downloads\\5d87d6e6211d5.jpeg";
        //            myimage = new Bitmap(HS_URL);
        //            sliderHome.BackgroundImage = myimage;
        //        }
        //    }
        //
        //    else if (homeSlider < 0)
        //    {
        //        homeSlider = 3;
        //    }
        //}

        private void tutorial()
        {
            signIt.SelectedTab = Lecciones_y_Ejercicios;
            tuto1.Show();
            DatabaseFunctions.SetAvance(DatabaseFunctions.currentUser, 1, path);
        }

//Comienzo
//
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            desaparicionDelMenu();
            signIt.SelectedTab = IdS;
            diseñoDeBotones();
            label1CdU.Hide();
            label2IdS.Hide();
        }

//Inicio de Sesión
        private void ComenzarIds_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfNameExists(UserIdS.Text, path) == true)
            {
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserIdS.Text, path);
                avance = DatabaseFunctions.CheckAvance(DatabaseFunctions.currentUser, path);

                UserXp = DatabaseFunctions.checkXP(DatabaseFunctions.currentUser, path);
                experiencia();

                UserHome.Text = (DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", path));
                signIt.SelectedTab = Home;
                aparicionDelMenu();
            }
            else
            {
                label2IdS.Show();
            }
        }

        private void linkLabel1IdS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signIt.SelectedTab = CdU;
            label1CdU.Hide();
            label2IdS.Hide();
            UserCdU.Text = "";
            UserIdS.Text = "";
        }
        private void SalirIdS_Click(object sender, EventArgs e)
        {
            cierre();
        }

//Creación de Usuario
        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            if (!DatabaseFunctions.checkIfThereAreUsers(path))
            {
                DatabaseFunctions.addUser(UserCdU.Text, path);
                
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserCdU.Text, path);

                DatabaseFunctions.SetAvance(DatabaseFunctions.currentUser, 0, path);
                avance = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Avance", path));
                
                tutorial();
            }
            else if (DatabaseFunctions.checkIfThereAreUsers(path))
            {
                if (!DatabaseFunctions.checkIfNameExists(UserCdU.Text, path))
                {
                    DatabaseFunctions.addUser(UserCdU.Text, path);

                    DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserCdU.Text, path);

                    DatabaseFunctions.SetAvance(DatabaseFunctions.currentUser, 0, path);
                    Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Avance", path));

                    tutorial();
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
            label1CdU.Hide();
            label2IdS.Hide();
            UserCdU.Text = "";
            UserIdS.Text = "";
        }

//Home

        private void DiccionarioHome_Click_1(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            panel1.SendToBack();
            menu = false;
        }
        private void LeccionesHome_Click_1(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;
            panel1.SendToBack();
            menu = false;
        }
        private void sliderHomeIz_Click(object sender, EventArgs e)
        {
            homeSlider -= 1;
        }
        private void sliderHomeDer_Click(object sender, EventArgs e)
        {
            homeSlider += 1;
        }

//Menu

        private async void Menubutton_Click(object sender, EventArgs e)
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
                await Task.Delay(50);
                Menubutton.Enabled = true;
                menu = true;
            }
            else if (menu == true)
            {
                while (menuX > -332)
                {
                    panel1.Location = new Point(menuX, 0);
                    menuX -= 2;
                    Menubutton.BringToFront();
                }
                Menubutton.BringToFront();
                await Task.Delay(50);
                Menubutton.Enabled = true;
                menu = false;
            }
        }

        private void MenuHomeButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Home;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuLectionsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuDiccionarioButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuGamesButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = juegos;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Ajustes;
            UserNameSett.Text = UserNameSett.Text + DatabaseFunctions.getString(DatabaseFunctions.currentUser,"Nombre",path);
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuExitButton_Click(object sender, EventArgs e)
            {
                cierre();
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

        //Diccionario
        private void button4_Click(object sender, EventArgs e)
        {
            diccionarioBeta1.Show();
            diccionarioBeta.verificacionDeTipo = "basico";

        }

        private void comidaDiccionario_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "comida";
        }

        private void coloresDiccionario_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "colores";
        }

        private void lugaresDiccionario_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "lugares";
        }

        private void pronombresDiccionario_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "pronombres";
        }

        private void verbosDiccionario_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "verbos";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "abecedario";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            diccionarioBeta.verificacionDeTipo = "numeros";
        }

//Juegos

        private void RaceGamesButton_Click(object sender, EventArgs e)
        {
            race1.Show();
            race1.BringToFront();
            desaparicionDelMenu();
        }

        private void MemotestGamesButton_Click(object sender, EventArgs e)
        {
            //Memotest1.Show();
        }

//constantCheck

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (signIt.SelectedTab == juegos || signIt.SelectedTab == Lecciones_y_Ejercicios)
                {
                    if (externalmenu == true)
                    {
                        aparicionDelMenu();
                        externalmenu = false;
                    }
                    else if (endTutorial == true)
                    {
                        signIt.SelectedTab = Home;
                        aparicionDelMenu();
                    }
                }
                else if (signIt.SelectedTab == Home)
                {
                    home_slider += 0.5;
                    //sliderDeLaHome();
                    if (home_slider == 25)
                    {
                        home_slider = 0;
                        homeSlider++;
                    }
                }
            }
        }
//sobras

        private void race2_Load(object sender, EventArgs e)
        {

        }
        private void label2IdS_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void UserIdS_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void IdS_Click(object sender, EventArgs e) {
        }
        private void Chekeos_Tick(object sender, EventArgs e)
        {

        }

        private void LeccionesMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
