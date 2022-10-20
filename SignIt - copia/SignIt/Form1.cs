﻿using SignIt.Properties;
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
        public static string path = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Usuarios.accdb";
        public static string imagePath = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Resources\\";
        //public static string path = "C:\\Users\\benjd\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Usuarios.accdb";
        //public static string videosPath = "C:\\Users\\benjd\\source\\repos\\NeoMakesGames\\Sign-It\\SignIt - copia\\SignIt\\Signs\\";

        Image myimage;
        string HS_URL;
        string botonBI;
        int menuX = -332;
        int UserXp;
        int UserLvl;
        int NextLvl = 10;
        int homeSlider = 0;
        double home_slider = 0;
        public static int avance;


        public bool menu = false;
        public bool fullscr = true;
        public static bool externalmenu = false;
        public static bool endTutorial = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
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
            UserXp = DatabaseFunctions.checkXP(DatabaseFunctions.currentUser, path);
            while (UserXp > NextLvl)
            {
                UserLvl += 1;
                UserXp -= NextLvl;
                NextLvl *= 2;
            }
        }
        private void  sliderDeLaHome()
        {
            
             
            
                if (homeSlider > 3)
                {
                    homeSlider = 1;
                }
            
                else if (homeSlider == 1)
                {
                  if (HS_URL != Form1.path.Remove(75, 14) + "\\Resources\\fundasor.PNG")
                  {
                        HS_URL = Form1.path.Remove(75, 14) + "\\Resources\\fundasor.PNG";
                        myimage = new Bitmap(HS_URL);
                        sliderHome.BackgroundImage = myimage;
                  }
                }
            
                else if (homeSlider == 2)
                {
                    if (HS_URL != Form1.path.Remove(75, 14) + "\\Resources\\Logo-CAS.PNG")
                    {
                        HS_URL = Form1.path.Remove(75, 14) + "\\Resources\\Logo-CAS.PNG";
                        myimage = new Bitmap(HS_URL);
                        sliderHome.BackgroundImage = myimage;
                    }
                }
            
                else if (homeSlider == 3)
                {
                    if (HS_URL != Form1.path.Remove(75, 14) + "\\Resources\\logo.PNG")
                    {
                        HS_URL = Form1.path.Remove(75, 14) + "\\Resources\\logo.PNG";
                        myimage = new Bitmap(HS_URL);
                        sliderHome.BackgroundImage = myimage;
                    }
                }
                else if (homeSlider < 1)
                {
                    homeSlider = 3;
                }
        }

        private void tutorial()
        {
            signIt.SelectedTab = Lecciones_y_Ejercicios;
            tuto1.Show();
            DatabaseFunctions.SetAvance(DatabaseFunctions.currentUser, 1, path);
        }

//Comienzo

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            desaparicionDelMenu();
            signIt.SelectedTab = IdS;
            label1CdU.Hide();
            label2IdS.Hide();
        }

//Inicio de Sesión
        private void ComenzarIds_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfNameExists(UserIdS.Text, path) == true)
            {
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserIdS.Text, path);
                avance = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser,"Avance" ,path));

                experiencia();

                timer1.Enabled = true;
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
                    avance = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Avance", path));
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
            if (avance < 2)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                basicoDiccionario.BackgroundImage = myimage;
            }
            if (avance < 3)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                comidaDiccionario.BackgroundImage = myimage;
            }
            if (avance < 4)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                coloresDiccionario.BackgroundImage = myimage;
            }
            if (avance < 5)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                lugaresDiccionario.BackgroundImage = myimage;
            }
            if (avance < 6)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                pronombresDiccionario.BackgroundImage = myimage;
            }
            if (avance < 7)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                verbosDiccionario.BackgroundImage = myimage;
            }
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
            experiencia();
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
            signIt.SelectedTab = Diccionario;
            if (avance < 2)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                basicoDiccionario.BackgroundImage = myimage;
            }
            if (avance < 3)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                comidaDiccionario.BackgroundImage = myimage;
            }
            if (avance < 4)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                coloresDiccionario.BackgroundImage = myimage;
            }
            if (avance < 5)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                lugaresDiccionario.BackgroundImage = myimage;
            }
            if (avance < 6)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                pronombresDiccionario.BackgroundImage = myimage;
            }
            if (avance < 7)
            {
                botonBI = Form1.path.Remove(75, 14) + "\\Resources\\candado.PNG";
                myimage = new Bitmap(botonBI);
                verbosDiccionario.BackgroundImage = myimage;
            }
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
            userNameSett2.Text = DatabaseFunctions.getString(DatabaseFunctions.currentUser,"Nombre",path);
            experienciaSett2.Text = Convert.ToString(UserLvl) + "          " + Convert.ToString(UserXp) + "/" + Convert.ToString(NextLvl);

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
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(avance > 1)
            {
                signIt.SelectedTab = dB1;
            }
        }

        private void comidaDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 2)
            {
                signIt.SelectedTab = dB2;
            }
        }

        private void coloresDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 3)
            {
                signIt.SelectedTab = dB3;
            }
        }

        private void lugaresDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 4)
            {
                signIt.SelectedTab = dB4;
            }
        }

        private void pronombresDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 5)
            {
                signIt.SelectedTab = dB5;
            }
        }

        private void verbosDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 6)
            {
                signIt.SelectedTab = dB6;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            diccionarioBeta.SelectedTab = dBAbecedario;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            diccionarioBeta.SelectedTab = dBNros;
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
                        aparicionDelMenu();
                        UserHome.Text = (DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", path));
                        signIt.SelectedTab = Home;
                    }
                }
                else if (signIt.SelectedTab == Home)
                {
                    home_slider += 0.5;
                    sliderDeLaHome();
                    if (home_slider == 30)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
