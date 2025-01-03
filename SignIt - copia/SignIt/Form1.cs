﻿using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        public static bool Memotest = false;
        bool turorial;
        bool rtaIncorrecta;
        int size, sizeB;

        public Form1()
        {
            InitializeComponent();

        }





        //Funciones





        private void byeDB()
        {
            diccionarioBeta.SelectedTab = MenuDB;
            dbplayer.Ctlcontrols.stop();
            aparicionDelMenu();
        }   //Devuelve al menu del diccionario.



        private void diccionarioVideos(string palabra)
        {
            palabraDB.Text = palabra;

            dbplayer.URL = signsPath + palabra.Replace("-", " ") + ".wmv";
            dbplayer.settings.setMode("loop", true);
            diccionarioBeta.SelectedTab = videos;
            dbplayer.Ctlcontrols.play();
            desaparicionDelMenu();
        }   //Acciona los videos del dicionario.



        private void diccionarioBetas(System.Windows.Forms.TabPage tipo, string imagen)
        {
            diccionarioBeta.SelectedTab = tipo;
            myimage = new Bitmap (imagePath + imagen + ".PNG");
            videos.BackgroundImage = myimage;
            desaparicionDelMenu();
        }



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
            atrasTutorial.Hide();
            continuarTutorial.Hide();
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
            diccionarioBeta.SelectedTab = MenuDB;
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
        }   //Actualiza los botones del diccionario según tu avance.



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



        private async void ej_1 (int idA, int idB, int idC, int xp, bool rtA, bool rtB, bool rtC)
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
            
   //
   //        while (!continuar)
   //        {
   //            await Task.Delay(250);
   //        }
   //
   //        continuar = false;
   //
   //        if (rtA == true)
   //        {
   //            ganar_0_perder(ej01);
   //            xp += 3;
   //        }
   //        else if (rtB == true)
   //        {
   //            ganar_0_perder(ej11);
   //        }
   //        else if (rtC == true)
   //        {
   //            ganar_0_perder(ej11);
   //        }
        }



        public async void ensañanza(string tipo, int[] videos, int rdnMin, int rdnMax)
        {
            int z = 0;
            EnseñanzaPlayer.settings.setMode("loop", true);

            desaparicionDelMenu();
            signIt.SelectedTab = Enseñanza;
            foreach (int id in videos)
            {
                string palabra = DatabaseFunctions.GetNameOfVideo(id, path);
                EnseñanzaPlayer.URL = signsPath + palabra + ".wmv";
                EnseñanzaPlayer.Ctlcontrols.play();
                await Task.Delay(50);
                PalabraEns.Text = palabra.Replace("-"," ");
                while (!continuar)
                {
                    await Task.Delay(250);
                }
                continuar = false;
                EnseñanzaPlayer.Ctlcontrols.stop();
            }

            int[] videdos = new int[5];
            int xpGanada = 5;
            z = 0;
            for (int o = 0; o < 5;)
            {
                int IDs_ = rdn.Next(rdnMin, rdnMax);

                if (IDs_ != 0)
                {
                    videdos[z] = IDs_;
                    z++;
                    o++;
                }
            }
                
            foreach(int id in videdos)
            {
                panel10.BackColor = Color.Transparent;
                panel11.BackColor = Color.Transparent;
                panel12.BackColor = Color.Transparent;
                ej2RespuestaCorrecta.Text = "La respuesta correcta es: ";
                ej2RespuestaCorrecta.Hide();
                ej01.Hide();
                ej11.Hide();
                ej02.Hide();
                ej12.Hide();
                int TipoDeEjercicio = rdn.Next(0, 2);
                switch (TipoDeEjercicio)
                {
                    
                    case 0:
                        int a = rdn.Next(rdnMin, rdnMax);
                        int b = rdn.Next(rdnMin, rdnMax);
                        ej1palabra.Text = "¿Cual seña corresponde a la palabra: ";
                        ej1palabra.Text = ej1palabra.Text + DatabaseFunctions.GetNameOfVideo(id, path) + "?";
                        int f = rdn.Next(0, 2);
                        for (int i = 0; i < 1;)
                        {
                            a = rdn.Next(rdnMin, rdnMax);
                            if (id != a)
                            {
                                i++;
                            }
                        }
                        for (int i = 0; i < 1;)
                        {
                            b = rdn.Next(rdnMin, rdnMax);
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
                                   ganar_0_perder(ej01, id, "A", panel10);
                                   xpGanada += 3;
                               }
                               else if (rta2 == true)
                                {
                                    rtaIncorrecta = true;
                                    ganar_0_perder(ej11, id, "A", panel10);
                               }
                               else if (rta3 == true)
                                {
                                    rtaIncorrecta = true;
                                    ganar_0_perder(ej11, id, "A", panel10);
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
                                    rtaIncorrecta = true;
                                    ganar_0_perder(ej11, id, "B", panel11);
                               }
                               else if (rta2 == true)
                               {
                                   ganar_0_perder(ej01, id, "B", panel11);
                                   xpGanada += 1;
                               }
                               else if (rta3 == true)
                                {
                                    rtaIncorrecta = true;
                                    ganar_0_perder(ej11, id, "B", panel11);
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
                                    rtaIncorrecta = true;
                                    ganar_0_perder(ej11, id, "C", panel12);
                                }
                                else if (rta2 == true)
                                {
                                    rtaIncorrecta = true;
                                    ganar_0_perder(ej11, id, "C", panel12);
                                }
                                else if (rta3 == true)
                                {
                                    ganar_0_perder(ej01, id, "C", panel12);
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
                        string respuesta = DatabaseFunctions.GetNameOfVideo(id, path).ToLower().Replace("-", " ");

                        ej2player.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                        ej2player.settings.setMode("loop", true);
                        ej2player.Ctlcontrols.play();

                        signIt.SelectedTab = ejercicio2;

                        while (!continuar)
                        {
                            await Task.Delay(250);
                        }

                        continuar = false;

                        if (respuesta.Replace("-", " ") == rtaEj2.Text.ToLower().Replace("-", " "))
                        {
                            ej02.Show();
                            ej02.BringToFront();
                            Random ram = new Random();
                            int xp_ = ram.Next(0, 2);
                            xpGanada += xp_;
                        }
                        else
                        {
                            rtaIncorrecta = true;
                            ganar_0_perder(ej12, id, "", panel11);
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

            DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
            avance++;
            aparicionDelMenu();
            botonesLecciones();
            signIt.SelectedTab = LeccionesMenu;
            caracolEJ1.Hide();
            caracolEJ2.Hide();
            caracolEnsenanza.Hide();
        }   //Muestra todas las señas de una clasificación en especifico (verbos, comidas, etc...) y toma una puequeña actividad; unicamente se utiliza si es la primera vez que se aprende el tipo de señas con la clasificación.



        public async void ejercicios(string tipo, int rdnMin, int rdnMax)
        {
            desaparicionDelMenu();
            continuar = false;
            int errores = 3;
            int z = 0;
            int[] videos = new int[5];
            int xpGanada = 5;
            for (int o = 0; o < 5;)
            {
                int IDs_ = rdn.Next(rdnMin, rdnMax);
                videos[z] = IDs_;
                z++;
                o++;
            }

            z = 0;

            foreach (int id in videos)
            {
                panel10.BackColor = Color.Transparent;
                panel11.BackColor = Color.Transparent;
                panel12.BackColor = Color.Transparent;
                ej2RespuestaCorrecta.Text = "La respuesta correcta es: ";
                ej2RespuestaCorrecta.Hide();
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

                    PalabraEns.Text = DatabaseFunctions.GetNameOfVideo(id, path).Replace("-", " ");
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
                            int a = rdn.Next(rdnMin, rdnMax);
                            int b = rdn.Next(rdnMin, rdnMax);
                            bool abc = false;
                            ej1palabra.Text = "¿Cual seña corresponde a la palabra: ";
                            ej1palabra.Text = ej1palabra.Text + DatabaseFunctions.GetNameOfVideo(id, path).Replace("-", " ") + "?";
                            int f = rdn.Next(0, 2);
                            for (int i = 0; i < 1;)
                            {
                                a = rdn.Next(rdnMin, rdnMax);
                                if (id != a)
                                {
                                    i++;
                                }
                            }
                            for (int i = 0; i < 1;)
                            {
                                b = rdn.Next(rdnMin, rdnMax);
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
                                        ganar_0_perder(ej01, id, "A", panel10);
                                        xpGanada += 3;
                                    }
                                    else if (rta2 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "A", panel10);
                                        errores--;
                                    }
                                    else if (rta3 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "A", panel10);
                                        errores--;
                                    }
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }
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
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "B", panel11);
                                        errores--;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej01, id, "B", panel11);
                                        xpGanada += 1;
                                    }
                                    else if (rta3 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "B", panel11);
                                        errores--;
                                    }
                                    while (!continuar)
                                    {
                                        await Task.Delay(250);
                                    }
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
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "C", panel12);
                                       errores--;
                                   }
                                   else if (rta2 == true)
                                   {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "C", panel12);
                                       errores--;
                                   }
                                   else if (rta3 == true)
                                   {
                                       ganar_0_perder(ej01, id, "C", panel12);
                                       xpGanada += 2;
                                   }
                                   while (!continuar)
                                   {
                                       await Task.Delay(250);
                                   }
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
                            string respuesta = DatabaseFunctions.GetNameOfVideo(id, path).ToLower().Replace("-", " ");

                            ej2player.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
                            ej2player.settings.setMode("loop", true);
                            ej2player.Ctlcontrols.play();

                            signIt.SelectedTab = ejercicio2;

                            while (!continuar)
                            {
                                await Task.Delay(250);
                            }

                            continuar = false;

                            if (respuesta == rtaEj2.Text.ToLower().Replace("-", " "))
                            {
                                ej02.Show();
                                ej02.BringToFront();
                                Random ram = new Random();
                                int xp_ = ram.Next(0, 2);
                                xpGanada += xp_;
                            }
                            else
                            {
                                rtaIncorrecta = true;
                                ganar_0_perder(ej12, id, "", panel10);
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



           private async void examenlecc_Click(object sender, EventArgs e)
        {
            desaparicionDelMenu();
            Life.BringToFront();
            int vidas = 5;

            List<int> videosExamen = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 442, 43, 44, 45, 46, 47, 48, 49, 50, 51, 5253, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64 };
            Random rand = new Random();
            var shuffled = videosExamen.OrderBy(_ => rand.Next(1,64)).ToList();

            foreach (int id in videosExamen)
            {
                switch (vidas)
                {
                    case 0:
                        Life.BackgroundImage = new Bitmap(imagePath + "Vidas0.PNG");
                        Life.SendToBack();
                        signIt.SelectedTab = LeccionesMenu;
                        return;

                    case 1:
                        Life.BackgroundImage = new Bitmap(imagePath + "Vidas1.PNG");
                        break;

                    case 2:
                        Life.BackgroundImage = new Bitmap(imagePath + "Vidas2.PNG");
                        break;

                    case 3:
                        Life.BackgroundImage = new Bitmap(imagePath + "Vidas3.PNG");
                        break;

                    case 4:
                        Life.BackgroundImage = new Bitmap(imagePath + "Vidas4.PNG");
                        break;

                    case 5:
                        Life.BackgroundImage = new Bitmap(imagePath + "Vidas5.PNG");
                        break;
                }
                panel10.BackColor = Color.Transparent;
                panel11.BackColor = Color.Transparent;
                panel12.BackColor = Color.Transparent;
                ej2RespuestaCorrecta.Text = "La respuesta correcta es: ";
                ej2RespuestaCorrecta.Hide();
                ej01.Hide();
                ej11.Hide();
                ej02.Hide();
                ej12.Hide();
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
                            ej1palabra.Text = ej1palabra.Text + DatabaseFunctions.GetNameOfVideo(id, path) + "?";
                            Random rm = new Random();
                            int a = rdn.Next(1, 64);
                            int b = rdn.Next(1, 64);
                            int f = rm.Next(0, 2);
                            switch (f)
                            {

                                case 0:
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
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
                                        ganar_0_perder(ej01, id, "A", panel10);
                                    }
                                    else if (rta2 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "A", panel10);
                                        vidas--;
                                    }
                                    else if (rta3 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "A", panel10);
                                        vidas--;
                                    }
                                    rta1 = false;
                                    rta2 = false;
                                    rta3 = false;
                                    break;


                                case 1:
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
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
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "B", panel1);
                                        vidas--;
                                    }
                                    else if (rta2 == true)
                                    {
                                        ganar_0_perder(ej01, id, "B", panel11);
                                    }
                                    else if (rta3 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "B", panel11);
                                        vidas--;
                                    }
                                    rta1 = false;
                                    rta2 = false;
                                    rta3 = false;
                                    break;

                                case 2:
                                    ejercicio1VideoA.URL = signsPath + DatabaseFunctions.GetNameOfVideo(a, path) + ".wmv";
                                    ejercicio1VideoB.URL = signsPath + DatabaseFunctions.GetNameOfVideo(b, path) + ".wmv";
                                    ejercicio1VideoC.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
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
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "C", panel12);
                                        vidas--;
                                    }
                                    else if (rta2 == true)
                                    {
                                        rtaIncorrecta = true;
                                        ganar_0_perder(ej11, id, "C", panel12);
                                        vidas--;
                                    }
                                    else if (rta3 == true)
                                    {
                                        ganar_0_perder(ej01, id, "C", panel12);
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
                            string respuesta = DatabaseFunctions.GetNameOfVideo(id, path).ToLower().Replace("-", " ");

                            ej2player.URL = signsPath + DatabaseFunctions.GetNameOfVideo(id, path) + ".wmv";
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
                            }
                            else
                            {
                                rtaIncorrecta = true;
                                ganar_0_perder(ej12, id, "", panel10);
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
                }
            }
            aparicionDelMenu();
            DatabaseFunctions.addAvance(DatabaseFunctions.currentUser, path);
            avance++;
            Life.SendToBack();
            signIt.SelectedTab = LeccionesMenu;
        }       //Se escojen 30 señas en total, al azar y de todas las clasificaciones (verbos, comidas, etc...). Luego se realizará una actividad para cada seña. Si el usuario hace mal 5 ejercicios pierde y debe comenzar de nuevo el mismo.



        private void ganar_0_perder(UserControl uc, int ids, string rta, Panel abc)
        {
            if (rtaIncorrecta == true)
            {
                ej2RespuestaCorrecta.Text = ej2RespuestaCorrecta.Text + " " + DatabaseFunctions.GetNameOfVideo(ids, path).Replace("-", " ") + ".";
                abc.BackColor = Color.LightGreen;
                ej2RespuestaCorrecta.Show();
                rtaIncorrecta = false;
            }
            uc.Show();
            uc.BringToFront();
        }   //Define que "cartel" mostrar dependiendo si el usuario hizo bien, o no, la actividad.




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
            caracolExit2.Hide();
            caracolEJ1.Hide();
            caracolEJ2.Hide();
            caracolEnsenanza.Hide();
            continuarTutorial.Hide();
            atrasTutorial.Hide();
            SearchDiccionario.BackColor = Color.FromArgb(235,228,228);
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


                if (avance < 2)
                {
                    myimage = new Bitmap(imagePath + "EmpezarLecciones" + ".PNG");
                    LeccionesHome.BackgroundImage = myimage;
                }
                else
                {
                    myimage = new Bitmap(imagePath + "ContinuarLecciones" + ".PNG");
                    LeccionesHome.BackgroundImage = myimage;
                }


                signIt.SelectedTab = Home;

            }
            else
            {
                label2IdS.Show();
            }
        }
        private void UserIdS_TextChanged(object sender, EventArgs e)
        {
            UserIdS.ForeColor = Color.Black;
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

        private void UserIdS_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                ComenzarIds_Click(sender , e);
            }
        }





//Creación de Usuario





        private void ComenzarCdU_Click(object sender, EventArgs e)
        {
            int sip;

            if (int.TryParse(UserAgeCdU.Text, out sip) && Convert.ToInt32(UserAgeCdU.Text) < 100 && UserAgeCdU.Text != "" && UserCdU.Text != "")
            {
                if (UserCdU.Text != "")
                {
                    if (!DatabaseFunctions.checkIfThereAreUsers(path))
                    {
                        DatabaseFunctions.addUser(UserCdU.Text, path);

                        DatabaseFunctions.currentUser = DatabaseFunctions.getIDFromName(UserCdU.Text, path);

                        DatabaseFunctions.SetAvance(DatabaseFunctions.currentUser, 0, path);
                        avance = Convert.ToInt32(DatabaseFunctions.getString(DatabaseFunctions.currentUser, "Avance", path));

                        tutorial();
                        myimage = new Bitmap(imagePath + "EmpezarLecciones" + ".PNG");
                        LeccionesHome.BackgroundImage = myimage;
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
                            myimage = new Bitmap(imagePath + "EmpezarLecciones" + ".PNG");
                            LeccionesHome.BackgroundImage = myimage;
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
        private void UserCdU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ComenzarCdU_Click(sender, e);
            }
        }

        private void UserAgeCdU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ComenzarCdU_Click(sender, e);
            }
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
            caracolayuda("Presentacion", 3);
        }
        private void sliderHome_Click(object sender, EventArgs e)
        {
            switch(homeSlider)
            {
                case 1:
                    Process.Start("chrome.exe", "https://www.fundasor.org.ar/");
                    return;

                case 2:
                    Process.Start("chrome.exe", "https://cas.org.ar/");
                    return;

                case 3:
                    Process.Start("chrome.exe", "https://www.asamutual.org.ar/");
                    return;
            }
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
            if(avance < 2)
            {
                myimage = new Bitmap(imagePath + "EmpezarLecciones" + ".PNG");
                LeccionesHome.BackgroundImage = myimage;
            }
            else
            {
                myimage = new Bitmap(imagePath + "ContinuarLecciones" + ".PNG");
                LeccionesHome.BackgroundImage = myimage;
            }
            Menubutton_Click(sender, e);
            menu = false;
            signIt.SelectedTab = Home;
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
                int[] basico = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                ensañanza("Basico", basico,1,13);
            }
            else if (avance > 1)
            {
                caracolEJ1.Show();
                caracolEJ2.Show();
                caracolEnsenanza.Show();
                ejercicios("Basico", 1, 13);
            }
        }
        private void comidaLecc_Click(object sender, EventArgs e)
        {
            if (avance == 2)
            {
                int[] comida = { 14, 15, 16, 17, 18, 19, 20, 21 };
                ensañanza("Comida", comida,14,21);
            }
            else if (avance > 2)
            {
                ejercicios("Comida", 14,  21);
            }
        }
        private void coloresLecc_Click(object sender, EventArgs e)
        {
            if (avance == 3)
            {
                int[] colores = { 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
                ensañanza("Colores", colores,22,32);
            }
            else if (avance > 3)
            {
                ejercicios("Colores", 22, 32);
            }
        }
        private void lugaresLecc_Click(object sender, EventArgs e)
        {
            if (avance == 4)
            {
                int[] lugares = { 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64 };
                ensañanza("Lugares", lugares,52,64);
            }
            else if (avance > 4)
            {
                ejercicios("Lugares", 52, 64);
            }
        }

        private void pronombresLecc_Click(object sender, EventArgs e)
        {
            if (avance == 5)
            {
                int[] pronombres = { 33, 34, 35, 36, 37, 38, 39 };
                ensañanza("Pronombres", pronombres,33,39);
            }
            else if (avance > 5)
            {
                ejercicios("Pronombres", 33, 39);
            }
        }

        private void verbosLecc_Click(object sender, EventArgs e)
        {
            if (avance == 6)
            {
                int[] verbos = { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };
                ensañanza("Verbos", verbos,40,51);
            }
            else if (avance > 6)
            {
                ejercicios("Verbos", 40, 51);
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
            Life.SendToBack();
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
                diccionarioBetas(Basico, "basicoDB");
                lastpage = 2;
            }
        }

        private void comidaDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 2)
            {
                diccionarioBetas(Comida, "ComidaDB");
                lastpage = 3;
            }
        }

        private void coloresDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 3)
            {
                diccionarioBetas(Colores, "ComidaDB");
                lastpage = 4;
            }
        }

        private void lugaresDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 4)
            {
                diccionarioBetas(Lugares, "LugaresDB");
                lastpage = 5;
            }
        }

        private void pronombresDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 5)
            {
                diccionarioBetas(Pronombres, "ComidaDB");
                lastpage = 6;
            }
        }

        private void verbosDiccionario_Click(object sender, EventArgs e)
        {
            if (avance > 6)
            {
                diccionarioBetas(Verbos, "ComidaDB");
                lastpage = 7;
            }
        }

        private void AbecedarioDB_Click(object sender, EventArgs e)
        {
            diccionarioBetas(dBAbecedario, "abeceDario");
            lastpage = 9;
        }

        private void Numeros_Click(object sender, EventArgs e)
        {
            diccionarioBetas(dBNros, "fndb");
            lastpage = 8;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            caracolayuda("ADC", 1);
        }

        private void exitDB_Click(object sender, EventArgs e)
        {
            switch (lastpage)
            {
                case 1:
                    diccionarioBeta.SelectedTab = MenuDB;
                    break;

                case 2:
                    diccionarioBeta.SelectedTab = Basico;
                    break;

                case 3:
                    diccionarioBeta.SelectedTab = Comida;
                    break;

                case 4:
                    diccionarioBeta.SelectedTab = Colores;
                    break;

                case 5:
                    diccionarioBeta.SelectedTab = Lugares;
                    break;

                case 6:
                    diccionarioBeta.SelectedTab = Pronombres;
                    break;

                case 7:
                    diccionarioBeta.SelectedTab = Verbos;
                    break;

                case 8:
                    diccionarioBeta.SelectedTab = dBNros;
                    break;

                case 9:
                    diccionarioBeta.SelectedTab = dBAbecedario;
                    break;

            }
            dbplayer.Ctlcontrols.stop();
        }
        private void SearchDiccionario_Click(object sender, EventArgs e)
        {
            SearchDiccionario.ForeColor = Color.Black;
            SearchDiccionario.Text = "";
        }


        private void SearchDiccionario_KeyDown(object sender, KeyEventArgs e)
        {
            string palabraDB = SearchDiccionario.Text;
            if (e.KeyData == Keys.Enter)
            {
                if (DatabaseFunctions.checkIfVideoExists(palabraDB, path))
                {
                    switch (DatabaseFunctions.GetCategoria(DatabaseFunctions.getVIDFromName(palabraDB, path), path))
                    {
                        case "Abecedario":
                            diccionarioBetas(dBAbecedario, "abecedario");
                            break;
                        case "Numeros":
                            diccionarioBetas(dBNros, "numeros");
                            break;
                        case "Basico":
                            diccionarioBetas(MenuDB, "MenuDB");
                            break;
                    }
                    lastpage = 1;
                    diccionarioVideos(palabraDB);
                    SearchDiccionario.Text = "";
                }
                else
                {
                    SearchDiccionario.Text = "Seña no encontrada";
                    SearchDiccionario.ForeColor = Color.Red;
                }
            }
        }

        private void SearchDiccionario_TextChanged(object sender, EventArgs e)
        {
            if(SearchDiccionario.ForeColor == Color.Red)
            {
                SearchDiccionario.ForeColor = Color.Black;
                SearchDiccionario.Text = "";
            }
        }





        //Diccionario_Números





        private void NumBack_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void dBNum0_Click(object sender, EventArgs e)
        {
            diccionarioVideos("0");
        }

        private void dBNum1_Click(object sender, EventArgs e)
        {
            diccionarioVideos("1");
        }

        private void dBNum2_Click(object sender, EventArgs e)
        {
            diccionarioVideos("2");
        }

        private void dBNum3_Click(object sender, EventArgs e)
        {
            diccionarioVideos("3");
        }

        private void dBNum4_Click(object sender, EventArgs e)
        {
            diccionarioVideos("4");
        }

        private void dBNum5_Click(object sender, EventArgs e)
        {
            diccionarioVideos("5");
        }

        private void dBNum6_Click(object sender, EventArgs e)
        {
            diccionarioVideos("6");
        }

        private void dBNum7_Click(object sender, EventArgs e)
        {
            diccionarioVideos("7");
        }

        private void dBNum8_Click(object sender, EventArgs e)
        {
            diccionarioVideos("8");
        }

        private void dBNum9_Click(object sender, EventArgs e)
        {
            diccionarioVideos("9");
        }

        private void dBNum10_Click(object sender, EventArgs e)
        {
            diccionarioVideos("10");
        }





        //Diccionario_Abecedario





        private void abecedarioExit_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void A_Click(object sender, EventArgs e)
        {
            diccionarioVideos("A");
        }

        private void B_Click(object sender, EventArgs e)
        {
            diccionarioVideos("B");
        }

        private void C_Click(object sender, EventArgs e)
        {
            diccionarioVideos("C");
        }

        private void D_Click(object sender, EventArgs e)
        {
            diccionarioVideos("D");
        }

        private void E_Click(object sender, EventArgs e)
        {
            diccionarioVideos("E");
        }

        private void F_Click(object sender, EventArgs e)
        {
            diccionarioVideos("F");
        }

        private void G_Click(object sender, EventArgs e)
        {
            diccionarioVideos("G");
        }

        private void H_Click(object sender, EventArgs e)
        {
            diccionarioVideos("H");
        }

        private void I_Click(object sender, EventArgs e)
        {
            diccionarioVideos("I");
        }

        private void J_Click(object sender, EventArgs e)
        {
            diccionarioVideos("J");
        }

        private void K_Click(object sender, EventArgs e)
        {
            diccionarioVideos("K");
        }

        private void L_Click(object sender, EventArgs e)
        {
            diccionarioVideos("L");
        }

        private void M_Click(object sender, EventArgs e)
        {
            diccionarioVideos("M");
        }
        private void N_Click(object sender, EventArgs e)
        {
            diccionarioVideos("N");
        }

        private void Ñ_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Ñ");
        }

        private void O_Click(object sender, EventArgs e)
        {
            diccionarioVideos("O");
        }

        private void P_Click(object sender, EventArgs e)
        {
            diccionarioVideos("P");
        }

        private void Q_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Q");
        }

        private void R_Click(object sender, EventArgs e)
        {
            diccionarioVideos("R");
        }

        private void S_Click(object sender, EventArgs e)
        {
            diccionarioVideos("S");
        }

        private void T_Click(object sender, EventArgs e)
        {
            diccionarioVideos("T");
        }

        private void U_Click(object sender, EventArgs e)
        {
            diccionarioVideos("U");
        }

        private void V_Click(object sender, EventArgs e)
        {
            diccionarioVideos("V");
        }

        private void W_Click(object sender, EventArgs e)
        {
            diccionarioVideos("W");
        }

        private void X_Click(object sender, EventArgs e)
        {
            diccionarioVideos("X");
        }

        private void Y_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Y");
        }

        private void Z_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Z");
        }





        //Diccionario_Basico





        private void ExitBasicoDB_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void No_Click(object sender, EventArgs e)
        {
            diccionarioVideos("No");
        }

        private void Como_Estas_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Como Estas");
        }

        private void Bien_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Bien");
        }

        private void Por_Favor_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Por favor");
        }

        private void Quién_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Quien");
        }

        private void Qué_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Que");
        }

        private void Como_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Como");
        }

        private void Adios_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Adios");
        }

        private void Gracias_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Gracias");
        }

        private void Dónde_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Donde");
        }

        private void Hola_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Hola");
        }

        private void Si_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Si");
        }

        private void Por_Qué_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Por Que");
        }





        //Diccionario_Comida





        private void ExitComidaDB_Click(object sender, EventArgs e)
        {
            byeDB();
        }
        private void Ensalada_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Ensalada");
        }

        private void Pan_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Pan");
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Pizza");
        }

        private void Agua_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Agua");
        }

        private void Leche_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Leche");
        }

        private void Banana_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Banana");
        }

        private void Carne_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Carne");
        }

        private void Manzana_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Manzana");
        }





        //Diccionario_Colores





       private void ExitColoresDB_Click(object sender, EventArgs e)
        {
            byeDB();
        }

    private void Rosa_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Rosa");
        }

        private void Naranja_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Naranja");
        }

        private void Amarillo_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Amarillo");
        }

        private void Verde_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Verde");
        }

        private void Violeta_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Violeta");
        }

        private void Blanco_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Blanco");
        }

        private void Gris_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Gris");
        }

        private void Celeste_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Celeste");
        }

        private void Negro_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Negro");
        }

        private void Azul_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Azul");
        }

        private void Rojo_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Rojo");
        }





        //Diccionario_Lugares





        private void ExitLugaresDB_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void Libreria_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Libreria");
        }

        private void Taller_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Taller");
        }

        private void Restaurante_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Restaurante");
        }

        private void Farmacia_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Farmacia");
        }

        private void Ciudad_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Lugar");
        }

        private void Teatro_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Teatro");
        }

        private void Confiteria_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Confiteria");
        }

        private void Club_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Club");
        }

        private void Bar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Bar");
        }

        private void Lugar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Lugar");
        }

        private void Cine_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Cine");
        }

        private void Hospital_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Hospital");
        }

        private void Supermercado_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Supermercado");
        }





        //Diccionario_Pronombres





        private void ExitPronombresDB_Click(object sender, EventArgs e)
        {
            byeDB();
        }

        private void Yo_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Yo");
        }

        private void Usted_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Usted");
        }

        private void Ustedes_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Ustedes");
        }

        private void Ellos_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Ellos");
        }

        private void El_Click(object sender, EventArgs e)
        {
            diccionarioVideos("El");
        }

        private void Nosotros_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Nosotros");
        }

        private void Vos_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Vos");
        }




        //Diccionario_Verbos




        private void ExitVerbosDB_Click(object sender, EventArgs e)
        {
            byeDB();
        }
        private void Caminar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Caminar");
        }

        private void Correr_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Correr");
        }

        private void Hablar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Hablar");
        }

        private void Aprender_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Aprender");
        }

        private void Tomar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Tomar");
        }

        private void Escribir_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Escribir");
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Jugar");
        }

        private void Mirar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Mirar");
        }

        private void Escuchar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Escuchar");
        }

        private void Dormir_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Dormir");
        }

        private void Estudiar_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Estudiar");
        }
        private void Comer_Click(object sender, EventArgs e)
        {
            diccionarioVideos("Comer");
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
            Memotest = true;
            memoTest1.Show();
            memoTest1.BringToFront();
            desaparicionDelMenu();
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
                        caracolayuda("T1", 3);
                        caracolExit.Hide();
                        atrasTutorial.Hide();
                        continuarTutorial.Show();
                        break;
                    case 2:
                        caracolayuda("T2", 3);
                        atrasTutorial.Show();
                        continuarTutorial.Show();
                        caracolExit.Hide();
                        break;
                    case 3:
                        caracolayuda("T3", 3);
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        break;
                    case 4:
                        caracolayuda("T4", 3);
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
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
                        continuarTutorial.Hide();
                        atrasTutorial.Hide();
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
                        caracolayuda("T1", 3);
                        caracolExit.Hide();
                        atrasTutorial.Hide();
                        continuarTutorial.Show();
                        break;
                    case 2:
                        caracolayuda("T2", 3);
                        atrasTutorial.Show();
                        continuarTutorial.Show();
                        caracolExit.Hide();
                        break;
                    case 3:
                        caracolayuda("T3", 3);
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        break;
                    case 4:
                        caracolayuda("T4", 3);
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
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
                        caracolayuda("T1", 3);
                        caracolExit.Hide();
                        atrasTutorial.Hide();
                        continuarTutorial.Show();
                        break;
                    case 2:
                        caracolayuda("T2", 3);
                        atrasTutorial.Show();
                        continuarTutorial.Show();
                        caracolExit.Hide();
                        break;
                    case 3:
                        caracolayuda("T3", 3);
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
                        break;
                    case 4:
                        caracolayuda("T4", 3);
                        continuarTutorial.Show();
                        atrasTutorial.Show();
                        caracolExit.Hide();
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

        private void Tipgrafia_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TabPage TB in signIt.Controls)
            {
                foreach (Control Label in TB.Controls.OfType<System.Windows.Forms.Label>())
                {
                    if (tiposDeLetra.SelectedIndex == 0)
                    {
                        size = 30;
                        sizeB = 12;
                    }
                    else if (tiposDeLetra.SelectedIndex == 1)
                    {
                        size = 35;
                        sizeB = 18;
                    }
                    switch (Tipgrafia.SelectedIndex.ToString())
                    {
                        case "1":
                            Label.Font = new Font("Calibri", size);
                            ej2RespuestaCorrecta.Font = new Font("Calibri", size);
                            break;

                        case "2":
                            Label.Font = new Font("Microsoft Sans Serif", size);
                            ej2RespuestaCorrecta.Font = new Font("Microsoft Sans Serif", sizeB);
                            break;

                        case "0":
                            Label.Font = new Font("Arial", size);
                            ej2RespuestaCorrecta.Font = new Font("Arial", sizeB);
                            break;
                    }
                }
            }
        }
        private void tiposDeLetra_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TabPage TB in signIt.Controls)
            {
                foreach (Control Label in TB.Controls.OfType<System.Windows.Forms.Label>())
                {
                    string fontNow = Label.Name;
                    switch (tiposDeLetra.SelectedIndex.ToString())
                    {
                        case "0":
                            Label.Font = new Font(fontNow, 30);
                            ej2RespuestaCorrecta.Font = new Font(fontNow, 12);
                            break;

                        case "1":
                            Label.Font = new Font(fontNow, 35);
                            ej2RespuestaCorrecta.Font = new Font(fontNow, 18);
                            break;
                    }
                }
            }
        }

        private void XpLvlSett_Click(object sender, EventArgs e)
        {

        }

        private void sliderHome_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(sliderHome, "Asociaciones y organizaciones que te podrían ayudar");
        }

        private void PantallaSett_Click(object sender, EventArgs e)
        {

        }





        //Codigo_Sobrante
    }
}
