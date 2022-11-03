using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace SignIt
{
    public partial class Form1 : Form
    {
        Image myimage;
        public static Random rdn = new Random();

        public static bool externalmenu = false;

        public static string path = "Usuarios.accdb";
        public static string imagePath = "Imagenes\\";
        public static string signsPath = "signs\\";
        string HS_URL;
        string botonBI;
        string botondiseño;
        int menuX = -332;
        int UserXp;
        int UserLvl;
        int NextLvl = 10;
        int homeSlider = 0;
        int vidas = 0;
        int lastpage = 0;
        int tipografia = 1;
        int tamano = 1;
        public static int avance;
        double home_slider = 0;
        int tuto = 0;
        public static bool continuar = false;
        public bool menu = false;
        public bool fullscr = true;
        bool rta1 = false;
        bool rta2 = false;
        bool rta3 = false;
        bool turorial;
                        bool respuesta = false;


        public Form1()
        {
            InitializeComponent();
        }





        //Funciones





        private void byeDB()
        {
            diccionarioBeta.SelectedTab = dB0;
            DBeta.SendToBack();
            dbplayer.Ctlcontrols.stop();
            aparicionDelMenu();
        }   //Devuelve al menu del diccionario.



        private void diccionario(string palabra)
        {
            palabraDB.Text = palabra;

            dbplayer.URL = signsPath + palabra + ".wmv";
            dbplayer.settings.setMode("loop", true);
            DBeta.BringToFront();
            dbplayer.Ctlcontrols.play();
            desaparicionDelMenu();
        }   //Acciona los videos del dicionario.



        private void desaparicionDelMenu()
        {
            Menubutton.Hide();
            panel1.Hide();
            panel1.Location = new Point(-332, 0);
        }   //Hace desaparecer el menu de opciones.



        private void aparicionDelMenu()
        {
            panel1.Show();
            panel1.BringToFront();
            Menubutton.Show();
            Menubutton.BringToFront();
        }   //Hace aparecer el menu de opciones.



        private void caracolayuda(string imagen, int page)
        {
            myimage = new Bitmap(imagePath + imagen + ".PNG");
            caracol.BackgroundImage = myimage;
            signIt.SelectedTab = caracol;
            lastpage = page;
            desaparicionDelMenu();
        }   //Muestra las pantallas de ayuda y guia.



        private void botonesLecciones()
        {
            Image yepMyImage;
            if (avance < 1)
            {
                botonBI = imagePath + "BásicoX.PNG";
                yepMyImage = new Bitmap(botonBI);
                basicoLecc.BackgroundImage = yepMyImage;
            }
            else
            {
                botonBI = imagePath + "Básico.PNG";
                yepMyImage = new Bitmap(botonBI);
                basicoLecc.BackgroundImage = yepMyImage;
            }

            if (avance < 2)
            {
                botonBI = imagePath + "ComidaX.PNG";
                yepMyImage = new Bitmap(botonBI);
                comidaLecc.BackgroundImage = yepMyImage;
            }
            else
            {
                botonBI = imagePath + "Básico (1).PNG";
                yepMyImage = new Bitmap(botonBI);
                comidaLecc.BackgroundImage = yepMyImage;
            }

            if (avance < 3)
            {
                botonBI = imagePath + "ColoresX.PNG";
                yepMyImage = new Bitmap(botonBI);
                coloresLecc.BackgroundImage = yepMyImage;
            }
            else
            {
                botonBI = imagePath + "Básico (2).PNG";
                yepMyImage = new Bitmap(botonBI);
                coloresLecc.BackgroundImage = yepMyImage;
            }

            if (avance < 4)
            {
                botonBI = imagePath + "LugaresX.PNG";
                yepMyImage = new Bitmap(botonBI);
                lugaresLecc.BackgroundImage = yepMyImage;
            }
            else
            {
                botonBI = imagePath + "Básico (3).PNG";
                yepMyImage = new Bitmap(botonBI);
                lugaresLecc.BackgroundImage = yepMyImage;
            }

            if (avance < 5)
            {
                botonBI = imagePath + "PronombresX.PNG";
                yepMyImage = new Bitmap(botonBI);
                pronombresLecc.BackgroundImage = yepMyImage;
            }
            else
            {
                botonBI = imagePath + "Básico (4).PNG";
                yepMyImage = new Bitmap(botonBI);
                pronombresLecc.BackgroundImage = yepMyImage;
            }

            if (avance < 6)
            {
                botonBI = imagePath + "VerbosX.PNG";
                myimage = new Bitmap(botonBI);
                verbosLecc.BackgroundImage = myimage;
            }
            else
            {
                botonBI = imagePath + "Básico (5).PNG";
                yepMyImage = new Bitmap(botonBI);
                verbosLecc.BackgroundImage = yepMyImage;
            }
            if (avance < 7)
            {
                botonBI = imagePath + "ExámenX.PNG";
                yepMyImage = new Bitmap(botonBI);
                examenlecc.BackgroundImage = yepMyImage;
            }
            else
            {
                botonBI = imagePath + "Básico (6).PNG";
                yepMyImage = new Bitmap(botonBI);
                examenlecc.BackgroundImage = yepMyImage;
            }
        }   //Actualiza los botones del menu de lecciones según tu avance.



        private void botonesDiccionario()
        {
            diccionarioBeta.SelectedTab = dB0;
            Image notmyimage;
            if (avance < 2)
            {
                botonBI = imagePath + "BásicoX.PNG";
                notmyimage = new Bitmap(botonBI);
                basicoDiccionario.BackgroundImage = notmyimage;
            }
            else
            {
                botonBI = imagePath + "Básico.PNG";
                notmyimage = new Bitmap(botonBI);
                basicoDiccionario.BackgroundImage = notmyimage;
            }

            if (avance < 3)
            {
                botonBI = imagePath + "ComidaX.PNG";
                notmyimage = new Bitmap(botonBI);
                comidaDiccionario.BackgroundImage = notmyimage;
            }
            else
            {
                botonBI = imagePath + "Básico (1).PNG";
                notmyimage = new Bitmap(botonBI);
                comidaDiccionario.BackgroundImage = notmyimage;
            }

            if (avance < 4)
            {
                botonBI = imagePath + "ColoresX.PNG";
                notmyimage = new Bitmap(botonBI);
                coloresDiccionario.BackgroundImage = notmyimage;
            }
            else
            {
                notmyimage = new Bitmap(imagePath + "Básico (2).PNG");
                coloresDiccionario.BackgroundImage = notmyimage;
            }

            if (avance < 5)
            {
                botonBI = imagePath + "LugaresX.PNG";
                notmyimage = new Bitmap(botonBI);
                lugaresDiccionario.BackgroundImage = notmyimage;
            }
            else
            {
                notmyimage = new Bitmap(imagePath + "Básico (3).PNG");
                lugaresDiccionario.BackgroundImage = notmyimage;
            }

            if (avance < 6)
            {
                botonBI = imagePath + "PronombresX.PNG";
                notmyimage = new Bitmap(botonBI);
                pronombresDiccionario.BackgroundImage = notmyimage;
            }
            else
            {
                botonBI = imagePath + "Básico (4).PNG";
                notmyimage = new Bitmap(botonBI);
                pronombresDiccionario.BackgroundImage = notmyimage;
            }

            if (avance < 7)
            {
                botonBI = imagePath + "VerbosX.PNG";
                notmyimage = new Bitmap(botonBI);
                verbosDiccionario.BackgroundImage = notmyimage;
            }
            else
            {
                botonBI = imagePath + "Básico (5).PNG";
                notmyimage = new Bitmap(botonBI);
                verbosDiccionario.BackgroundImage = notmyimage;
            }
        }   //Actualiza los botones del diccionario segú tu avance.



        private void cierre()
        {
            this.Close();
        }   //Cierra la aplicación.



        private void experiencia()
        {
            UserXp = DatabaseFunctions.checkXP(DatabaseFunctions.currentUser, path);
            while (UserXp > NextLvl)
            {
                UserLvl += 1;
                UserXp = UserXp - NextLvl;
                NextLvl *= 2;
            }
        }   //Actualiza tu experiencia.



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
        }   //Muestra, en la home, diferentes imagenes que cambian cada determinado tiempo.



        private void tutorial()
        {
            caracolayuda("Presentacion", 3);
            myimage = new Bitmap(imagePath + "Botón (3).PNG");
            caracolExit.BackgroundImage = myimage;
            turorial = true;
        }   //Muestra la pantalla del tutorial, la primera vez que inicias sesión. 

        private async void ej_2 (int idA, int idB, int idC, int xp, bool rtA, bool rtB, bool rtC)
        {
            ejercicio1VideoA.settings.setMode("loop", true);
            ejercicio1VideoB.settings.setMode("loop", true);
            ejercicio1VideoC.settings.setMode("loop", true);

            signIt.SelectedTab = ejercicio1;
            ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(idA, path) + ".wmv";
            ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(idB, path) + ".wmv";
            ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(idC, path) + ".wmv";

           // MessageBox.Show(ejercicio1VideoA.URL);
            
           // ejercicio1VideoA.Ctlcontrols.play();
           // ejercicio1VideoB.Ctlcontrols.play();
           // ejercicio1VideoC.Ctlcontrols.play();
            

            while (!continuar)
            {
                await Task.Delay(250);
            }

            continuar = false;

            if (rtA == true)
            {
                ganar_0_perder(ej01);
                xp += 3;
            }
            else if (rtB == true)
            {
                ganar_0_perder(ej11);
            }
            else if (rtC == true)
            {
                ganar_0_perder(ej11);
            }
        }



        public async void ensañanza(string tipo)
        {
            ej01.Hide();
            ej11.Hide();
            ej02.Hide();
            ej12.Hide();
            desaparicionDelMenu();
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
            signIt.SelectedTab = Enseñanza;
            foreach (int id in videos)
            {
                if (id != 0)
                {
                    EnseñanzaPlayer.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
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
            DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
            avance++;


            int[] videdos = new int[5];
            int xpGanada = 5;
            z = 0;
            for (int o = 0; o < 5;)
            {
                int IDs_ = rdn.Next(1, 64);

                if (tipo == DatabaseFunctions.GetCategoria(IDs_, path) && IDs_ != 0)
                {
                    videdos[z] = IDs_;
                    z++;
                    o++;
                }
            }
                
            foreach(int id in videdos)
            {
                ej01.Hide();
                ej11.Hide();
                ej02.Hide();
                ej12.Hide();
                int TipoDeEjercicio = rdn.Next(0, 2);
                switch (TipoDeEjercicio)
                {
                    
                    case 0:
                        int a = rdn.Next(1, 64); ;
                        int b = rdn.Next(1, 64);
                        ej1palabra.Text = "¿Cual seña corresponde a la palabra: ";
                        ej1palabra.Text = ej1palabra.Text + DatabaseFunctions.GetNameOfVideo(id, path) + "?";
                        Random rm = new Random();
                        int f = rm.Next(0, 2);
                        for (int i = 0; i < 1;)
                        {
                            a = rdn.Next(1, 64);
                            if (id != a)
                            {
                                i++;
                            }
                        }
                        for (int i = 0; i < 1;)
                        {
                            b = rdn.Next(1, 64);
                            if (id != b && a != b)
                            {
                                i++;
                            }
                        }
                        switch (f)
                        {

                            case 0:
                               ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                               ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                               ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                               ejercicio1VideoA.settings.setMode("loop", true);
                               ejercicio1VideoB.settings.setMode("loop", true);
                               ejercicio1VideoC.settings.setMode("loop", true);
                               ejercicio1VideoA.Ctlcontrols.play();
                               ejercicio1VideoB.Ctlcontrols.play();
                               ejercicio1VideoC.Ctlcontrols.play();
                               ej02.Hide();
                               ej12.Hide();
                               signIt.SelectedTab = ejercicio1;
                                while (!continuar)
                               {
                                   await Task.Delay(250);
                               }
                            
                               continuar = false;
                            
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

                               ej2videoA.Enabled = false;
                               ej2videoB.Enabled = false;
                               ej2videoC.Enabled = false;
                               

                                while (!continuar)
                                {
                                    await Task.Delay(250);
                                }

                                ej2videoA.Enabled = true;
                                ej2videoB.Enabled = true;
                                ej2videoC.Enabled = true;

                                //  ej_2(id, b, a, xpGanada, rta1, rta2, rta3);
                                break;


                            case 1:
                               ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                               ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                               ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                               ejercicio1VideoA.settings.setMode("loop", true);
                               ejercicio1VideoB.settings.setMode("loop", true);
                               ejercicio1VideoC.settings.setMode("loop", true);
                               ejercicio1VideoA.Ctlcontrols.play();
                               ejercicio1VideoB.Ctlcontrols.play();
                               ejercicio1VideoC.Ctlcontrols.play();
                               ej02.Hide();
                               ej12.Hide();
                               signIt.SelectedTab = ejercicio1;
                                while (!continuar)
                               {
                                   await Task.Delay(250);
                               }
                  
                               continuar = false;
                  
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

                                ej2videoA.Enabled = false;
                                ej2videoB.Enabled = false;
                                ej2videoC.Enabled = false;

                                while (!continuar)
                                {
                                    await Task.Delay(250);
                                }

                                ej2videoA.Enabled = true;
                                ej2videoB.Enabled = true;
                                ej2videoC.Enabled = true;
                                //ej_2(a, id, b, xpGanada, rta2, rta1, rta3);
                                break;

                            case 2:
                                ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                ejercicio1VideoA.settings.setMode("loop", true);
                                ejercicio1VideoB.settings.setMode("loop", true);
                                ejercicio1VideoC.settings.setMode("loop", true);
                                ejercicio1VideoA.Ctlcontrols.play();
                                ejercicio1VideoB.Ctlcontrols.play();
                                ejercicio1VideoC.Ctlcontrols.play();
                                signIt.SelectedTab = ejercicio1;
                                while (!continuar)
                                {
                                    await Task.Delay(250);
                                }
                          
                                continuar = false;
                          
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
                                ej2videoA.Enabled = false;
                                ej2videoB.Enabled = false;
                                ej2videoC.Enabled = false;
                                while (!continuar)
                                {
                                    await Task.Delay(250);
                                }
                                ej2videoA.Enabled = true;
                                ej2videoB.Enabled = true;
                                ej2videoC.Enabled = true;
                                //ej_2(a, b, id, xpGanada, rta3, rta2, rta1);
                                break;
                        }
                        ejercicio1VideoA.Ctlcontrols.stop();
                        ejercicio1VideoB.Ctlcontrols.stop();
                        ejercicio1VideoC.Ctlcontrols.stop();
                        while (!continuar)
                        {
                            await Task.Delay(250);
                        }
                        ej02.Hide();
                        ej12.Hide();
                        continuar = false;
                        rta1 = false;
                        rta2 = false;
                        rta3 = false;
                        break;

                    case 1:
                        string respuesta = DatabaseFunctions.GetNameOfVideo(id, path).ToLower();

                        ej2player.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                        ej2player.settings.setMode("loop", true);
                        ej2player.Ctlcontrols.play();

                        signIt.SelectedTab = ejercicio2;

                        while (!continuar)
                        {
                            await Task.Delay(250);
                        }

                        continuar = false;

                        if (respuesta == rtaEj2.Text.ToLower())
                        {
                            ej02.Show();
                            ej02.BringToFront();
                            Random ram = new Random();
                            int xp_ = ram.Next(0, 2);
                            xpGanada += xp_;
                        }
                        else if (respuesta != rtaEj2.Text)
                        {
                            ganar_0_perder(ej12);
                        }

                        while (!continuar)
                        {
                            await Task.Delay(250);
                        }
                        ej02.Hide();
                        ej12.Hide();

                        rtaEj2.Text = "";

                        continuar = false;
                        ej2player.Ctlcontrols.stop();

                        break;
                }
            }

            aparicionDelMenu();
            botonesLecciones();
            signIt.SelectedTab = LeccionesMenu;
            caracolEJ1.Hide();
            caracolEJ2.Hide();
            caracolEnsenanza.Hide();
        }   //Muestra todas las señas de una clasificación en especifico (verbos, comidas, etc...) y toma una puequeña actividad; unicamente se utiliza si es la primera vez que se aprende el tipo de señas con la clasificación.



        public async void ejercicios(string tipo)
        {
            desaparicionDelMenu();
            continuar = false;
            int errores = 3;
            int z = 0;
            int[] videos = new int[5];
            int xpGanada = 5;
            for (int o = 0; o < 5;)
            {
                Random rdn = new Random();
                int IDs_ = rdn.Next(1, 64);

                if (tipo == DatabaseFunctions.GetCategoria(IDs_, "Usuarios.accdb") && IDs_ != 0)
                {
                    videos[z] = IDs_;
                    z++;
                    o++;
                }
            }

            z = 0;

            foreach (int id in videos)
            {
                ej01.Hide();
                ej11.Hide();
                ej02.Hide();
                ej12.Hide();
                ej2player.settings.setMode("loop", true);
                if (z < 2)
                {
                    signIt.SelectedTab = Enseñanza;
                    EnseñanzaPlayer.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                    EnseñanzaPlayer.settings.setMode("loop", true);

                    PalabraEns.Text = DatabaseFunctions.GetNameOfVideo(id, path);
                    EnseñanzaPlayer.Ctlcontrols.play();

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
                            int a = rdn.Next(1, 64);
                            int b = rdn.Next(1, 64);
                            bool abc = false;
                            ej1palabra.Text = "¿Cual seña corresponde a la palabra: ";
                            ej1palabra.Text = ej1palabra.Text + DatabaseFunctions.GetNameOfVideo(id, path) + "?";
                            Random rm = new Random();
                            int f = rm.Next(0, 2);
                            for (int i = 0; i < 1;)
                            {
                                a = rdn.Next(1, 64);
                                if (id != a)
                                {
                                    i++;
                                }
                            }
                            for (int i = 0; i < 1;)
                            {
                                b = rdn.Next(1, 64);
                                if (id != b && a != b)
                                {
                                    i++;
                                }
                            }
                            switch (f)
                            {

                                case 0:
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoA.settings.setMode("loop", true);
                                    ejercicio1VideoB.settings.setMode("loop", true);
                                    ejercicio1VideoC.settings.setMode("loop", true);
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();
                                    ej02.Hide();
                                    ej12.Hide();
                                    signIt.SelectedTab = ejercicio1;
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }
                                  
                                    continuar = false;
                                  
                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej01);
                                        xpGanada += 3;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        errores--;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        errores--;
                                    }
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }

                                    //ej_2(id,b,a,xpGanada, rta1, rta2, rta3);
                                    break;


                                case 1:
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                    ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoA.settings.setMode("loop", true);
                                    ejercicio1VideoB.settings.setMode("loop", true);
                                    ejercicio1VideoC.settings.setMode("loop", true);
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();
                                    ej02.Hide();
                                    ej12.Hide();
                                    signIt.SelectedTab = ejercicio1;
                                   
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }
                                   
                                    continuar = false;
                                   
                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        errores--;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej01);
                                        xpGanada += 1;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        errores--;
                                    }
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }

                                    // ej_2(a,id,b,xpGanada,rta2, rta1, rta3);
                                    break;

                                case 2:
                                   ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                   ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                   ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                                   ejercicio1VideoA.settings.setMode("loop", true);
                                   ejercicio1VideoB.settings.setMode("loop", true);
                                   ejercicio1VideoC.settings.setMode("loop", true);
                                   ejercicio1VideoA.Ctlcontrols.play();
                                   ejercicio1VideoB.Ctlcontrols.play();
                                   ejercicio1VideoC.Ctlcontrols.play();
                                   signIt.SelectedTab = ejercicio1;
                                   while (!continuar)
                                   {
                                       await Task.Delay(250);
                                   }
                          
                                   continuar = false;
                          
                                   if (rta1 == true)
                                   {
                                       ganar_0_perder(ej11);
                                       errores--;
                                   }
                                   else if (rta2 == true)
                                   {
                                       ganar_0_perder(ej11);
                                       errores--;
                                   }
                                   else if (rta3 == true)
                                   {
                                       ganar_0_perder(ej01);
                                       xpGanada += 2;
                                   }
                                    while (!continuar)
                                   {
                                       await Task.Delay(250);
                                   }
                                    //ej_2(a,b,id,xpGanada,rta3, rta2, rta1);
                                    break;
                            }
                            ejercicio1VideoA.Ctlcontrols.stop();
                            ejercicio1VideoB.Ctlcontrols.stop();
                            ejercicio1VideoC.Ctlcontrols.stop();

                            rta1 = false;
                            rta2 = false;
                            rta3 = false;

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }

                            continuar = false;

                            ej02.Hide();
                            ej12.Hide();

                            break;

                        case 1:
                            string respuesta = DatabaseFunctions.GetNameOfVideo(id, path).ToLower();

                            ej2player.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                            ej2player.settings.setMode("loop", true);
                            ej2player.Ctlcontrols.play();

                            signIt.SelectedTab = ejercicio2;

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }

                            continuar = false;

                            if (respuesta == rtaEj2.Text.ToLower())
                            {
                                ej02.Show();
                                ej02.BringToFront();
                                Random ram = new Random();
                                int xp_ = ram.Next(0, 2);
                                xpGanada += xp_;
                            }
                            else if (respuesta != rtaEj2.Text)
                            {
                                ganar_0_perder(ej12);
                                errores--;
                            }

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }
                            ej02.Hide();
                            ej12.Hide();

                            rtaEj2.Text = "";

                            continuar = false;
                            ej2player.Ctlcontrols.stop();

                            break;
                    }
                }
                z++;
            }

            botonesLecciones();
            aparicionDelMenu();
            botonesLecciones();
            signIt.SelectedTab = LeccionesMenu;
            caracolEJ1.Hide();
            caracolEJ2.Hide();
            caracolEnsenanza.Hide();
            experiencia();
        }   //Elige 5 señas, que pueden repetirse más de una vez, al azar de la clasificación elegida (verbos, comidas, etc...). Se enceñaran las dos primeras y se haran actividades del resto. 



        private void ganar_0_perder(UserControl uc)
        {
            uc.Show();
            uc.BringToFront();
        }   //Define que "cartel" mostrar dependiendo si el usuario hizo bien, o no, la actividad.



        private async void examenlecc_Click(object sender, EventArgs e)
        {
            int vidas = 5;

            List<int> videosExamen = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 442, 43, 44, 45, 46, 47, 48, 49, 50, 51, 5253, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64 };
            Random rand = new Random();
            var shuffled = videosExamen.OrderBy(_ => rand.Next()).ToList();

            foreach (int video in videosExamen)
            {
                ej01.Hide();
                ej11.Hide();
                ej02.Hide();
                ej12.Hide();
                ej2player.settings.setMode("loop", true);
                ej2player.settings.setMode("loop", true);
                ejercicio1VideoA.settings.setMode("loop", true);
                ejercicio1VideoB.settings.setMode("loop", true);
                ejercicio1VideoC.settings.setMode("loop", true);
                {
                    Random rdn = new Random();
                    int TipoDeEjercicio = rdn.Next(0, 2);
                    switch (TipoDeEjercicio)
                    {

                        case 0:
                            ej1palabra.Text = "¿Cual seña corresponde a la palabra: ";
                            ej1palabra.Text = ej1palabra.Text + DatabaseFunctions.GetNameOfVideo(video, path) + "?";
                            Random rm = new Random();
                            int a = rdn.Next(1, 64);
                            int b = rdn.Next(1, 64);
                            int f = rm.Next(0, 2);
                            switch (f)
                            {

                                case 0:
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(video, path) + ".wmv";
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();
                                    ej02.Hide();
                                    ej12.Hide();
                                    signIt.SelectedTab = ejercicio1;
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }

                                    continuar = false;

                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej01);
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        vidas--;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        vidas--;
                                    }
                                    rta1 = false;
                                    rta2 = false;
                                    rta3 = false;
                                    break;


                                case 1:
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(video, path) + ".wmv";
                                    ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();
                                    ej02.Hide();
                                    ej12.Hide();
                                    signIt.SelectedTab = ejercicio1;
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }

                                    continuar = false;

                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        vidas--;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej01);
                                        vidas += 1;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        vidas--;
                                    }
                                    rta1 = false;
                                    rta2 = false;
                                    rta3 = false;
                                    break;

                                case 2:
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(video, path) + ".wmv";
                                    ejercicio1VideoA.Ctlcontrols.play();
                                    ejercicio1VideoB.Ctlcontrols.play();
                                    ejercicio1VideoC.Ctlcontrols.play();
                                    signIt.SelectedTab = ejercicio1;
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }

                                    continuar = false;

                                    if (rta1 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        vidas--;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej11);
                                        vidas--;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej01);
                                    }
                                    rta1 = false;
                                    rta2 = false;
                                    rta3 = false;
                                    break;
                            }
                            ejercicio1VideoA.Ctlcontrols.stop();
                            ejercicio1VideoB.Ctlcontrols.stop();
                            ejercicio1VideoC.Ctlcontrols.stop();
                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }
                            ej02.Hide();
                            ej12.Hide();
                            continuar = false;

                            break;

                        case 1:
                            string respuesta = DatabaseFunctions.GetNameOfVideo(video, path);

                            ej2player.URL = signsPath + DatabaseFunctions.GetNameOfVideo(video, path) + ".wmv";
                            ej2player.Ctlcontrols.play();

                            signIt.SelectedTab = ejercicio2;

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }

                            continuar = false;

                            if (respuesta == rtaEj2.Text)
                            {
                                ej02.Show();
                                ej02.BringToFront();
                                Random ram = new Random();
                            }
                            else if (respuesta != rtaEj2.Text)
                            {
                                ganar_0_perder(ej12);
                                vidas--;
                            }

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }
                            ej02.Hide();
                            ej12.Hide();

                            rtaEj2.Text = "";

                            continuar = false;
                            ej2player.Ctlcontrols.stop();

                            break;
                    }
                    if (vidas == 0)
                    {

                    }
                }
            }
            aparicionDelMenu();
            DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
            avance++;
            signIt.SelectedTab = LeccionesMenu;
        }       //Se escojen 30 señas en total, al azar y de todas las clasificaciones (verbos, comidas, etc...). Luego se realizará una actividad para cada seña. Si el usuario hace mal 5 ejercicios pierde y debe comenzar de nuevo el mismo.





        //Comienzo





        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            desaparicionDelMenu();
            signIt.SelectedTab = IdS;
            label1CdU.Hide();
            label2IdS.Hide();
            ej02.Hide();
            ej12.Hide();
            DBeta.SendToBack();
            caracolExit2.Hide();
            caracolEJ1.Hide();
            caracolEJ2.Hide();
            caracolEnsenanza.Hide();
            continuarTutorial.Hide();
            atrasTutorial.Hide();
        }





//Inicio de Sesión
        
        
        
        
        
        private void ComenzarIds_Click(object sender, EventArgs e)
        {
            if (DatabaseFunctions.checkIfNameExists(UserIdS.Text, path) == true)
            {
                DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserIdS.Text, path);
                avance = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Avance", path));

                experiencia();

                timer1.Enabled = true; //sirve para algunas funciones, linea 1495

                aparicionDelMenu();

                signIt.SelectedTab = Home;

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
        //  foreach(Label a in )
        //  {
        //
        //  }
        }

        private void SalirIdS_Click(object sender, EventArgs e)
        {
            cierre();
        }





//Creación de Usuario





        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            int sip;

            if (int.TryParse(UserAgeCdU.Text, out sip) && Convert.ToInt32(UserAgeCdU.Text) < 100)
            {
                if (UserCdU.Text != "" && UserAgeCdU.Text != "")
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
                            label1CdU.Text = "Este nombre de usuario ya existe";
                        }
                    }
                }
            }
            else
            {
                label1CdU.Show();
                label1CdU.Text = "Por favor ingrese una valor coherente";
            }
        }

        private void SnapBackToReality_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = IdS;
            label1CdU.Hide();
            label2IdS.Hide();
            UserAgeCdU.Text = "Ingresar edad";
            UserIdS.ForeColor = Color.Silver;
            UserCdU.Text = "Ingresar nombre";
            UserCdU.ForeColor = Color.Silver;
            UserIdS.Text = "Ingresar Usuario";
            UserAgeCdU.ForeColor = Color.Silver;
        }

//Home

        private void DiccionarioHome_Click_1(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            botonesDiccionario();
            panel1.SendToBack();
            menu = false;
        }
        private void LeccionesHome_Click_1(object sender, EventArgs e)
        {
            signIt.SelectedTab = LeccionesMenu;
            botonesLecciones();
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

        private void button1_Click_6(object sender, EventArgs e)
        {
            caracolayuda("CAB", 3);
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
            botonesLecciones();
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuDiccionarioButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = Diccionario;
            Menubutton_Click(sender, e);
            menu = false;
            signIt.SelectedTab = Diccionario;
            botonesDiccionario();
        }

        private void MenuGamesButton_Click(object sender, EventArgs e)
        {
            signIt.SelectedTab = juegos;
            Menubutton_Click(sender, e);
            menu = false;
        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            experiencia();
            signIt.SelectedTab = Ajustes;
            userNameSett2.Text = DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Nombre", path);
            experiencia();
            xpB.Text = Convert.ToString(UserLvl);
            xProgressBar.Maximum = NextLvl;
            xProgressBar.Value = UserXp;
            progresoSett2.Text = Convert.ToString(avance) + " / 8";
            Menubutton_Click(sender, e);
            menu = false;
            switch(tamano)
            {
                case 1:
                    Tipgrafia.Text = "Inter";
                    break;
            }
        }

        private void MenuExitButton_Click(object sender, EventArgs e)
        {
            cierre();
        }





//Lecciones





        private void button1_Click(object sender, EventArgs e)
        {
            if (avance == 1)
            {
                caracolEJ1.Show();
                caracolEJ2.Show();
                caracolEnsenanza.Show();
                ensañanza("Basico");
            }
            else if (avance > 1)
            {
                caracolEJ1.Show();
                caracolEJ2.Show();
                caracolEnsenanza.Show();
                ejercicios("Basico");
            }
        }
        private void comidaLecc_Click(object sender, EventArgs e)
        {
            if (avance == 2)
            {
                ensañanza("Comida");
            }
            else if (avance > 2)
            {
                ejercicios("Comida");
            }
        }
        private void coloresLecc_Click(object sender, EventArgs e)
        {
            if (avance == 3)
            {
                ensañanza("Colores");
            }
            else if (avance > 3)
            {
                ejercicios("Colores");
            }
        }
        private void lugaresLecc_Click(object sender, EventArgs e)
        {
            if (avance == 4)
            {
                ensañanza("Lugares");
            }
            else if (avance > 4)
            {
                ejercicios("Lugares");
            }
        }

        private void pronombresLecc_Click(object sender, EventArgs e)
        {
            if (avance == 5)
            {
                ensañanza("Pronombres");
            }
            else if (avance > 5)
            {
                ejercicios("Pronombres");
            }
        }

        private void verbosLecc_Click(object sender, EventArgs e)
        {
            if (avance == 6)
            {
                ensañanza("Verbos");
            }
            else if (avance > 6)
            {
                ejercicios("Verbos");
            }
        }

        private void contEnseñanza_Click(object sender, EventArgs e)
        {
            continuar = true;
        }
        private void ej2cont_Click(object sender, EventArgs e)
        {
            continuar = true;
        }
        
        private void ej2videoA_Click(object sender, EventArgs e)
        {
            continuar = true;
            rta1 = true;
        }

        private void ej2videoB_Click_1(object sender, EventArgs e)
        {
            continuar = true;
            rta2 = true;
        }

        private void ej2videoC_Click_1(object sender, EventArgs e)
        {
            continuar = true;
            rta3 = true;
        }

        private void ej2videoB_Click(object sender, EventArgs e)
        {
            continuar = true;
            rta2 = true;
        }

        private void ej2videoC_Click(object sender, EventArgs e)
        {
            continuar = true;
            rta3 = true;
        }

        private void caracolEJ1_Click(object sender, EventArgs e)
        {
            caracolayuda("ACEJ1", 11);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            caracolayuda("ACEJ2", 12);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            caracolayuda("ACE", 10);
        }

        private void caracolLecciones_Click(object sender, EventArgs e)
        {
            caracolayuda("ACL", 2);
        }

        private void endExitRaceButton_Click(object sender, EventArgs e)
        {
            aparicionDelMenu();
            signIt.SelectedTab = LeccionesMenu;
            ej2player.Ctlcontrols.stop();
            ejercicio1VideoA.Ctlcontrols.stop();
            ejercicio1VideoB.Ctlcontrols.stop();
            ejercicio1VideoC.Ctlcontrols.stop();
        }
        private void endExitRaceButton_Click_1(object sender, EventArgs e)
        {
            endExitRaceButton_Click(sender, e);
        }

        private void enseñanzaExit_Click(object sender, EventArgs e)
        {
            endExitRaceButton_Click(sender, e);
        }





//Ajustes





        private void FullScrButtonSett_Click(object sender, EventArgs e)
        {
            if (fullscr == false)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                myimage = new Bitmap(imagePath + "Group 75.PNG");
                FullScrButtonSett.BackgroundImage = myimage;
                fullscr = true;
            }
            else if (fullscr == true)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                myimage = new Bitmap(imagePath + "Group 77.PNG");
                FullScrButtonSett.BackgroundImage = myimage;
                fullscr = false;
            }
        }

        private void caracolsett_Click(object sender, EventArgs e)
        {
            caracolayuda("ASC", 5);
        }





//Diccionario





        private void button4_Click(object sender, EventArgs e)
        {
            if (avance > 1)
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
            myimage = new Bitmap(imagePath + "abecedario.PNG");
            DBeta.BackgroundImage = myimage;
            desaparicionDelMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            diccionarioBeta.SelectedTab = dBNros;
            myimage = new Bitmap(imagePath + "fndb.PNG");
            DBeta.BackgroundImage = myimage;
            desaparicionDelMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            caracolayuda("ADC", 1);
        }

        private void exitDB_Click(object sender, EventArgs e)
        {
            DBeta.SendToBack();
            dbplayer.Ctlcontrols.stop();
        }


        //Diccionario_Números





        private void NumBack_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void dBNum0_Click(object sender, EventArgs e)
        {
            diccionario("0");
        }

        private void dBNum1_Click(object sender, EventArgs e)
        {
            diccionario("1");
        }

        private void dBNum2_Click(object sender, EventArgs e)
        {
            diccionario("2");
        }

        private void dBNum3_Click(object sender, EventArgs e)
        {
            diccionario("3");
        }

        private void dBNum4_Click(object sender, EventArgs e)
        {
            diccionario("4");
        }

        private void dBNum5_Click(object sender, EventArgs e)
        {
            diccionario("5");
        }

        private void dBNum6_Click(object sender, EventArgs e)
        {
            diccionario("6");
        }

        private void dBNum7_Click(object sender, EventArgs e)
        {
            diccionario("7");
        }

        private void dBNum8_Click(object sender, EventArgs e)
        {
            diccionario("8");
        }

        private void dBNum9_Click(object sender, EventArgs e)
        {
            diccionario("9");
        }

        private void dBNum10_Click(object sender, EventArgs e)
        {
            diccionario("10");
        }





//Diccionario_Abecedario






        private void abecedarioExit_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void A_Click(object sender, EventArgs e)
        {
            diccionario("A");
        }

        private void B_Click(object sender, EventArgs e)
        {
            diccionario("B");
        }

        private void C_Click(object sender, EventArgs e)
        {
            diccionario("C");
        }

        private void D_Click(object sender, EventArgs e)
        {
            diccionario("D");
        }

        private void E_Click(object sender, EventArgs e)
        {
            diccionario("E");
        }

        private void F_Click(object sender, EventArgs e)
        {
            diccionario("F");
        }

        private void G_Click(object sender, EventArgs e)
        {
            diccionario("G");
        }

        private void H_Click(object sender, EventArgs e)
        {
            diccionario("H");
        }

        private void I_Click(object sender, EventArgs e)
        {
            diccionario("I");
        }

        private void J_Click(object sender, EventArgs e)
        {
            diccionario("J");
        }

        private void K_Click(object sender, EventArgs e)
        {
            diccionario("K");
        }

        private void L_Click(object sender, EventArgs e)
        {
            diccionario("L");
        }

        private void M_Click(object sender, EventArgs e)
        {
            diccionario("M");
        }
        private void N_Click(object sender, EventArgs e)
        {
            diccionario("N");
        }

        private void Ñ_Click(object sender, EventArgs e)
        {
            diccionario("Ñ");
        }

        private void O_Click(object sender, EventArgs e)
        {
            diccionario("O");
        }

        private void P_Click(object sender, EventArgs e)
        {
            diccionario("P");
        }

        private void Q_Click(object sender, EventArgs e)
        {
            diccionario("Q");
        }

        private void R_Click(object sender, EventArgs e)
        {
            diccionario("R");
        }

        private void S_Click(object sender, EventArgs e)
        {
            diccionario("S");
        }

        private void T_Click(object sender, EventArgs e)
        {
            diccionario("T");
        }

        private void U_Click(object sender, EventArgs e)
        {
            diccionario("U");
        }

        private void V_Click(object sender, EventArgs e)
        {
            diccionario("V");
        }

        private void W_Click(object sender, EventArgs e)
        {
            diccionario("W");
        }

        private void X_Click(object sender, EventArgs e)
        {
            diccionario("X");
        }

        private void Y_Click(object sender, EventArgs e)
        {
            diccionario("Y");
        }

        private void Z_Click(object sender, EventArgs e)
        {
            diccionario("Z");
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

        private void questo2_Click(object sender, EventArgs e)
        {
            desaparicionDelMenu();
            if (menu == true)
            {
                Menubutton_Click(sender, e);
            }
            signIt.SelectedTab = caracol;
            myimage = new Bitmap(imagePath + "CAM.PNG");
            caracol.BackgroundImage = myimage;
            caracolExit.Hide();
            caracolExit2.Show();
            caracol.BackColor = Color.FromArgb(191, 226, 236);
        }

        private void questo_Click(object sender, EventArgs e)
        {
            desaparicionDelMenu();
            if (menu == true)
            {
                Menubutton_Click(sender, e);
            }
            signIt.SelectedTab = caracol;
            myimage = new Bitmap(imagePath + "CAC.PNG");
            caracol.BackgroundImage = myimage;
            caracolExit.Hide();
            caracolExit2.Show();
            caracol.BackColor = Color.FromArgb(191, 226, 236);
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





//Caracol_Ayuda
        
        
        
        
        private void caracolExit_Click(object sender, EventArgs e)
        {
            if (turorial == true)
            {
                tuto++;
                switch (tuto)
                {
                    case 1:
                        caracolExit.Hide();
                        atrasTutorial.Hide();
                        continuarTutorial.Show();
                        caracolayuda("T1", 3);
                        break;
                    case 2:
                        atrasTutorial.Show();
                        continuarTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T2", 3);
                        break;
                    case 3:
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T3", 3);
                        break;
                    case 4:
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T4", 3);
                        break;
                    case 5:
                        aparicionDelMenu();
                        signIt.SelectedTab = Home;
                        DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
                        avance++;
                        myimage = new Bitmap(imagePath + "Botón (4).PNG");
                        caracolExit.BackgroundImage = myimage;
                        caracolExit.Show();
                        turorial = false;
                        break;
                }
            }
            else
            {
                switch (lastpage)
                {
                    case 1:
                        signIt.SelectedTab = Diccionario;
                        aparicionDelMenu();
                        break;

                    case 2:
                        signIt.SelectedTab = LeccionesMenu;
                        aparicionDelMenu();
                        break;

                    case 3:
                        signIt.SelectedTab = Home;
                        aparicionDelMenu();
                        break;

                    case 4:
                        signIt.SelectedTab = juegos;
                        aparicionDelMenu();
                        break;

                    case 5:
                        signIt.SelectedTab = Ajustes;
                        aparicionDelMenu();
                        break;

                    case 10:
                        signIt.SelectedTab = Enseñanza;
                        break;

                    case 11:
                        signIt.SelectedTab = ejercicio1;
                        break;

                    case 12:
                        signIt.SelectedTab = ejercicio2;
                        break;
                }
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            if (turorial == true)
            {
                tuto++;
                switch (tuto)
                {
                    case 1:
                        caracolExit.Hide();
                        atrasTutorial.Hide();
                        continuarTutorial.Show();
                        caracolayuda("T1", 3);
                        break;
                    case 2:
                        atrasTutorial.Show();
                        continuarTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T2", 3);
                        break;
                    case 3:
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T3", 3);
                        break;
                    case 4:
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T4", 3);
                        break;
                    case 5:
                        aparicionDelMenu();
                        signIt.SelectedTab = Home;
                        DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
                        avance++;
                        myimage = new Bitmap(imagePath + "Botón (4).PNG");
                        caracolExit.BackgroundImage = myimage;
                        caracolExit.Show();
                        turorial = false;
                        break;
                }
            }
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            if (turorial == true)
            {
                tuto--;
                switch (tuto)
                {
                    case 1:
                        caracolExit.Hide();
                        atrasTutorial.Hide();
                        continuarTutorial.Show();
                        caracolayuda("T1", 3);
                        break;
                    case 2:
                        atrasTutorial.Show();
                        continuarTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T2", 3);
                        break;
                    case 3:
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T3", 3);
                        break;
                    case 4:
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        caracolayuda("T4", 3);
                        break;
                    case 5:
                        aparicionDelMenu();
                        signIt.SelectedTab = Home;
                        DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
                        avance++;
                        myimage = new Bitmap(imagePath + "Botón (4).PNG");
                        caracolExit.BackgroundImage = myimage;
                        caracolExit.Show();
                        turorial = false;
                        break;
                }
            }
        }

        private void caracolExit2_Click(object sender, EventArgs e)
        {
            aparicionDelMenu();
            signIt.SelectedTab = juegos;
            caracolExit2.Hide();
            caracolExit.Show();
            caracol.BackColor = Color.FromArgb(128, 128, 255);
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
            UserIdS.ForeColor = Color.Black;
        }

        private void UserCdU_Click(object sender, EventArgs e)
        {
            UserCdU.Text = "";
            UserCdU.ForeColor = Color.Black;
        }

        private void UserAgeCdU_Click(object sender, EventArgs e)
        {
            UserAgeCdU.Text = "";
            UserAgeCdU.ForeColor = Color.Black;
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





//Codigo_Sobrante





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
            UserIdS.ForeColor = Color.Black;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void IdS_Click(object sender, EventArgs e)
        {
        }
        private void Chekeos_Tick(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void LeccionesMenu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ComenzarIds_MouseHover(object sender, EventArgs e)
        {

        }
        private void ejercicio1VideoA_Enter(object sender, EventArgs e)
        {

        }
        private void dBNros_Click(object sender, EventArgs e)
        {

        }

        private void ComenzarIds_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void UserAgeCdU_TextChanged(object sender, EventArgs e)
        {

        }


        private void rtaEj2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ejercicio1VideoA_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {

        }

        private void ejercicio1VideoB_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {

        }
        private void ejercicio1VideoC_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {

        }


        

        private void ejercicio1VideoB_Enter(object sender, EventArgs e)
        {

        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void labelDBNum1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ajustes_Click(object sender, EventArgs e)
        {

        }

        private void labelDBNum2_Click(object sender, EventArgs e)
        {

        }

        private void labelDBNum1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDBNum3_Click(object sender, EventArgs e)
        {

        }

        private void labelDBNum6_Click(object sender, EventArgs e)
        {

        }

        private void XpLvlSett_Click(object sender, EventArgs e)
        {

        }

        private void progresoSett_Click(object sender, EventArgs e)
        {

        }

        private void PantallaSett_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void UserCdU_TextChanged(object sender, EventArgs e)
        {

        }

        private void PalabraEns_Click(object sender, EventArgs e)
        {

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sliderHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userpfp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userNameSett2_Click(object sender, EventArgs e)
        {

        }

        private void xpB_Click(object sender, EventArgs e)
        {

        }

        private void xProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void ej12_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ej2player_Enter(object sender, EventArgs e)
        {

        }

        private void ejercicio1VideoC_Enter(object sender, EventArgs e)
        {

        }

        private void Tipgrafia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
