using SignIt.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
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
        public static string path = "Usuarios.accdb";
        public static string imagePath = "Imagenes\\";
        public static string signsPath = "signs\\";
        
        Image myimage;
        string HS_URL;
        string botonBI;
        string botondiseño;
        int menuX = -332;
        int UserXp;
        int UserLvl;
        int NextLvl = 10;
        int homeSlider = 0;
        int vidas = 0;
        double home_slider = 0;
        public static int avance; 
        public static bool continuar = false;

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
        private void sliderDeLaHome()
        {



            if (homeSlider > 3)
            {
                homeSlider = 1;
            }

            else if (homeSlider == 1)
            {
                if (HS_URL != imagePath + "fundasor.PNG")
                {
                    HS_URL = imagePath + "fundasor.PNG";
                    myimage = new Bitmap(HS_URL);
                    sliderHome.BackgroundImage = myimage;
                }
            }

            else if (homeSlider == 2)
            {
                if (HS_URL != imagePath + "Logo-CAS.PNG")
                {
                    HS_URL = imagePath + "Logo-CAS.PNG";
                    myimage = new Bitmap(HS_URL);
                    sliderHome.BackgroundImage = myimage;
                }
            }

            else if (homeSlider == 3)
            {
                if (HS_URL != imagePath + "logo.PNG")
                {
                    HS_URL = imagePath + "logo.PNG";
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
            signIt.SelectedTab = Enseñanza;
            //tuto1.Show();
            DatabaseFunctions.SetAvance(DatabaseFunctions.currentUser, 1, path);
        }

        public async void ensañanza(string tipo)
        {
            signIt.SelectedTab = Enseñanza;
            int z = 0;
            int[] videos = new int[20];
            EnseñanzaPlayer.settings.setMode("loop", true);

            for (int id = 1; id <= 64; id++)
            {
                if (tipo == DatabaseFunctions.GetCategoria(id, path))
                {
                    int a = id;
                    videos[z] = id;
                    z++;
                }
            }
            foreach (int id in videos)
            {
                if (id != null)
                {
                    EnseñanzaPlayer.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                    MessageBox.Show(EnseñanzaPlayer.URL);
                    EnseñanzaPlayer.Ctlcontrols.play();
                    PalabraEns.Text = DatabaseFunctions.GetNameOfVideo(id, path);
                    while (!continuar)
                    {
                        await Task.Delay(250);
                    }
                    continuar = false;
                    EnseñanzaPlayer.Ctlcontrols.stop();
                }
            }
            DatabaseFunctions.addAvance(1 , path);
            avance++;
        }

        public async void ejercicios(string tipo)
        {
            continuar = false;
            signIt.SelectedTab = Enseñanza;
            int z = 0;
            int[] videos = new int[4];
            int xpGanada = 5;
            for (int o = 0; o < 5;)
            {
                Random rdn = new Random();
                int IDs_ = rdn.Next(1, 60);

                if (tipo == DatabaseFunctions.GetCategoria(1, "Usuarios.accdb"))
                {
                    videos[z] = IDs_;
                    z++;
                    o++;
                } 
            }

            z = 0;

            foreach (int id in videos)
            {
                if (z < 2)
                {
                    signIt.SelectedTab = Enseñanza;
                    EnseñanzaPlayer.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                    PalabraEns.Text = DatabaseFunctions.getString(id, "Sign", signsPath);

                    while (!continuar)
                    {
                        await Task.Delay(250);
                    }

                    continuar = false;
                }
                else if (z >= 2)
                {
                    Random rdn = new Random();
                    int TipoDeEjercicio = rdn.Next(0, 2);
                    switch (TipoDeEjercicio)
                    {

                        case 0:
                            ej1palabra.Text = ej1palabra.Text + " " + DatabaseFunctions.getString(id, "Signs", path) + "?";
                            ejercicio1VideoA.settings.setMode("loop", true);
                            ejercicio1VideoB.settings.setMode("loop", true);
                            ejercicio1VideoC.settings.setMode("loop", true);
                            bool rta1 = false;
                            bool rta2 = false;
                            bool rta3 = false;
                            int a = 0;
                            int b = 0;
                            signIt.SelectedTab = ejercicio1;
                            for (int o = 0; o < 2;)
                            {
                                Random random = new Random();
                                int id_ = random.Next(0, 63);

                                if (tipo == DatabaseFunctions.getString(id_, "Categoria", path))
                                {
                                    if (o == 0 && id_ != id)
                                    {
                                        a = id_;
                                    }

                                    if (o == 1)
                                    {
                                        b = id_;
                                    }

                                    z++;
                                    o++;
                                }
                            }
                            Random rm = new Random();
                            int f = rm.Next(0, 2);
                            switch (f)
                            {
                                case 0:
                                    ejercicio1VideoA.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                    ejercicio1VideoB.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoC.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();

                                    while (rta1 == false && rta2 == true && rta3 == false)
                                    {
                                        await Task.Delay(250);
                                    }
                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej01);
                                        xpGanada += 3;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej11);
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej11);
                                    }
                                    break;


                                case 1:
                                    ejercicio1VideoA.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoB.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                    ejercicio1VideoC.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();

                                    while (rta1 == false && rta2 == true && rta3 == false)
                                    {
                                        await Task.Delay(250);
                                    }
                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej11);
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej01);
                                        xpGanada += 1;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej11);
                                    }
                                    break;

                                case 2:
                                    ejercicio1VideoA.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoB.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoC.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();

                                    while (rta1 == false && rta2 == true && rta3 == false)
                                    {
                                        await Task.Delay(250);
                                    }
                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej11);
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej11);
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej01);
                                        xpGanada += 2;
                                    }
                                    break;
                            }
                            ejercicio1VideoA.Ctlcontrols.stop();
                            ejercicio1VideoB.Ctlcontrols.stop();
                            ejercicio1VideoC.Ctlcontrols.stop();
                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }
                            ej01.Hide();
                            ej11.Hide();
                            continuar = false;

                            break;

                        case 1:
                            string respuesta = DatabaseFunctions.getString(id, "Signs", path);

                            ej2player.URL = "C:\\Users\\48110679\\source\\repos\\NeoMakesGames\\Sign - It\\SignIt - copia\\SignIt\\Signs" + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                            ej2player.Ctlcontrols.play();

                            signIt.SelectedTab = ejercicio2;

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }

                            continuar = false;

                            if (respuesta == rtaEj2.Text)
                            {
                                ej01.Show();
                                Random ram = new Random();
                                int xp_ = ram.Next(0, 2);
                                xpGanada += xp_;
                            }

                            else
                            {
                                ej11.Show();
                            }

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }

                            ej2player.Ctlcontrols.stop();
                            ej01.Hide();
                            ej11.Hide();
                            
                            continuar = false;
                            
                            break;


                        case 2:
                            signIt.SelectedTab = ejercicio3;
                            break;
                    }
                }
                z++;
            }
        }

        private void ganar_0_perder(UserControl uc)
        {
            uc.Show();
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
            ej01.Hide();
            ej11.Hide();
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
            UserCdU.Text = "Ingresar nombre";
            UserIdS.Text = "Ingresar Usuario";
            UserAgeCdU.Text = "Ingresar edad";
        }
        private void SalirIdS_Click(object sender, EventArgs e)
        {
            cierre();
        }

//Creación de Usuario
        private void ComenzarCdU_Click(object sender, EventArgs e)
        {   if (UserCdU.Text != "" && UserAgeCdU.Text != "")
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
        }

        private void SnapBackToReality_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = IdS;
            label1CdU.Hide();
            label2IdS.Hide();
            UserCdU.Text = "Ingresar nombre";
            UserIdS.Text = "Ingresar Usuario";
            UserAgeCdU.Text = "Ingresar edad";
        }

//Home

        private void DiccionarioHome_Click_1(object sender, EventArgs e)
        {
           signIt.SelectedTab = Diccionario;
           if (avance < 2)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               basicoDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico";
               myimage = new Bitmap(botonBI);
               basicoDiccionario.BackgroundImage = myimage;
           }

           if (avance < 3)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               comidaDiccionario.BackgroundImage = myimage;
           }
           else
           {
                botonBI = imagePath + "Básico(1).PNG";
                myimage = new Bitmap(botonBI);
                comidaDiccionario.BackgroundImage = myimage;
           }

           if (avance < 4)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               coloresDiccionario.BackgroundImage = myimage;
           }
           else
           {
                botonBI = imagePath + "Básico (2)";
                myimage = new Bitmap(botonBI);
                coloresDiccionario.BackgroundImage = myimage;
            }

           if (avance < 5)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               lugaresDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico (3)";
               myimage = new Bitmap(botonBI);
               lugaresDiccionario.BackgroundImage = myimage;
           }

           if (avance < 6)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               pronombresDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico (4).PNG";
               myimage = new Bitmap(botonBI);
               pronombresDiccionario.BackgroundImage = myimage;
           }

           if (avance < 7)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               verbosDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico (5).PNG";
               myimage = new Bitmap(botonBI);
               verbosDiccionario.BackgroundImage = myimage;
           }

           panel1.SendToBack();
           menu = false;
        }
        private void LeccionesHome_Click_1(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;

            if (avance < 1)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                basicoLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico";
                myimage = new Bitmap(botonBI);
                basicoLecc.BackgroundImage = myimage;
            }

            if (avance < 2)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                comidaLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico(1).PNG";
                myimage = new Bitmap(botonBI);
                comidaLecc.BackgroundImage = myimage;
            }

            if (avance < 3)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                coloresLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (2)";
                myimage = new Bitmap(botonBI);
                coloresLecc.BackgroundImage = myimage;
            }

            if (avance < 4)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                lugaresLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (3)";
                myimage = new Bitmap(botonBI);
                lugaresLecc.BackgroundImage = myimage;
            }

            if (avance < 5)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                pronombresLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (4).PNG";
                myimage = new Bitmap(botonBI);
                pronombresLecc.BackgroundImage = myimage;
            }

            if (avance < 6)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                verbosLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (5).PNG";
                myimage = new Bitmap(botonBI);
                 verbosLecc.BackgroundImage = myimage;
            }
            if (avance < 7)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                examenlecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (5).PNG";
                myimage = new Bitmap(botonBI);
                 examenlecc.BackgroundImage = myimage;
            }

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

            if (avance < 1)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                basicoLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico";
                myimage = new Bitmap(botonBI);
                basicoLecc.BackgroundImage = myimage;
            }

            if (avance < 2)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                comidaLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico(1).PNG";
                myimage = new Bitmap(botonBI);
                comidaLecc.BackgroundImage = myimage;
            }

            if (avance < 3)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                coloresLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (2)";
                myimage = new Bitmap(botonBI);
                coloresLecc.BackgroundImage = myimage;
            }

            if (avance < 4)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                lugaresLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (3)";
                myimage = new Bitmap(botonBI);
                lugaresLecc.BackgroundImage = myimage;
            }

            if (avance < 5)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                pronombresLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (4).PNG";
                myimage = new Bitmap(botonBI);
                pronombresLecc.BackgroundImage = myimage;
            }

            if (avance < 6)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                verbosLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (5).PNG";
                myimage = new Bitmap(botonBI);
                verbosLecc.BackgroundImage = myimage;
            }
            if (avance < 7)
            {
                botonBI = imagePath + "candado.PNG";
                myimage = new Bitmap(botonBI);
                examenlecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (5).PNG";
                myimage = new Bitmap(botonBI);
                examenlecc.BackgroundImage = myimage;
            }

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
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               basicoDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico";
               myimage = new Bitmap(botonBI);
               basicoDiccionario.BackgroundImage = myimage;
           }

           if (avance < 3)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               comidaDiccionario.BackgroundImage = myimage;
           }
           else
           {
                botonBI = imagePath + "Básico(1).PNG";
                myimage = new Bitmap(botonBI);
                comidaDiccionario.BackgroundImage = myimage;
           }

           if (avance < 4)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               coloresDiccionario.BackgroundImage = myimage;
           }
           else
           {
                botonBI = imagePath + "Básico (2)";
                myimage = new Bitmap(botonBI);
                coloresDiccionario.BackgroundImage = myimage;
            }

           if (avance < 5)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               lugaresDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico (3)";
               myimage = new Bitmap(botonBI);
               lugaresDiccionario.BackgroundImage = myimage;
           }

           if (avance < 6)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               pronombresDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico (4).PNG";
               myimage = new Bitmap(botonBI);
               pronombresDiccionario.BackgroundImage = myimage;
           }

           if (avance < 7)
           {
               botonBI = imagePath + "candado.PNG";
               myimage = new Bitmap(botonBI);
               verbosDiccionario.BackgroundImage = myimage;
           }
           else
           {
               botonBI = imagePath + "Básico (5).PNG";
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

//Lecciones

        private void button1_Click(object sender, EventArgs e)
        {
            if (10>1)//(avance >= 1)
            {
                ensañanza("Basico");
            }
            else
            {
                ejercicios("Basico");
            }
        }

        private void contEnseñanza_Click(object sender, EventArgs e)
        {
            continuar = true;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            continuar = true;
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
                if (signIt.SelectedTab == juegos || signIt.SelectedTab == Enseñanza)
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

        private void NumBack_Click(object sender, EventArgs e)
        {
            diccionarioBeta.SelectedTab = dB0;
        }

        private void ComenzarIds_MouseHover(object sender, EventArgs e)
        {

        }
        private void ejercicio1VideoA_Enter(object sender, EventArgs e)
        {

        }

        private void ComenzarIds_MouseClick(object sender, MouseEventArgs e)
        { 
        
        }
        private void UserAgeCdU_TextChanged(object sender, EventArgs e)
        {

        }
        //Botones
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            Image mYimage;
            botondiseño = imagePath + "Botón (1).png";
            mYimage = new Bitmap(botondiseño);
            ComenzarIds.BackgroundImage = mYimage;
        }

        private void ComenzarIds_MouseEnter(object sender, EventArgs e)
        {
            Image mYimage;
            botondiseño = imagePath + "Botón (2).png";
            mYimage = new Bitmap(botondiseño);
            ComenzarIds.BackgroundImage = mYimage;
        }

        private void ComenzarIds_MouseLeave(object sender, EventArgs e)
        {
            Image mYimage;
            botondiseño = imagePath + "Botón.png";
            mYimage = new Bitmap(botondiseño);
            ComenzarIds.BackgroundImage = mYimage;
        }

        private void UserIdS_Click(object sender, EventArgs e)
        {
            UserIdS.Text = "";
        }

        private void UserCdU_Click(object sender, EventArgs e)
        {
            UserCdU.Text = "";
        }

        private void UserAgeCdU_Click(object sender, EventArgs e)
        {
            UserAgeCdU.Text = "";
        }

        private void ComenzarCdU_MouseEnter(object sender, EventArgs e)
        {
            Image mYimage;
            botondiseño = imagePath + "Botón seleccionado.png";
            mYimage = new Bitmap(botondiseño);
            ComenzarCdU.BackgroundImage = mYimage;
        }

        private void ComenzarCdU_MouseLeave(object sender, EventArgs e)
        {
            Image mYimage;
            botondiseño = imagePath + "Botón (3).png";
            mYimage = new Bitmap(botondiseño);
            ComenzarCdU.BackgroundImage = mYimage;
        }
    }
}
