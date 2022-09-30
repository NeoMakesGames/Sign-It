namespace SignIt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.signIt = new System.Windows.Forms.TabControl();
            this.LeccionesMenu = new System.Windows.Forms.TabPage();
            this.Diccionario = new System.Windows.Forms.TabPage();
            this.juegos = new System.Windows.Forms.TabPage();
            this.MemotestGamesButton = new System.Windows.Forms.Button();
            this.RaceGamesButton = new System.Windows.Forms.Button();
            this.Ajustes = new System.Windows.Forms.TabPage();
            this.FullScrButtonSett = new System.Windows.Forms.Button();
            this.PantallaSett = new System.Windows.Forms.Label();
            this.SonidoSett = new System.Windows.Forms.Label();
            this.UserNameSett = new System.Windows.Forms.Label();
            this.XProgresBarSett = new CircularProgressBar.CircularProgressBar();
            this.Lecciones_y_Ejercicios = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.MenuSettingsButton = new System.Windows.Forms.Button();
            this.MenuGamesButton = new System.Windows.Forms.Button();
            this.MenuDiccionarioButton = new System.Windows.Forms.Button();
            this.MenuLectionsButton = new System.Windows.Forms.Button();
            this.MenuHomeButton = new System.Windows.Forms.Button();
            this.race1 = new SignIt.Race();
            this.CdU = new System.Windows.Forms.TabPage();
            this.UserCdU = new System.Windows.Forms.TextBox();
            this.label1CdU = new System.Windows.Forms.Label();
            this.ComenzarCdU = new System.Windows.Forms.Button();
            this.SnapBackToReality = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.TabPage();
            this.UserHome = new System.Windows.Forms.Label();
            this.LeccionesHome = new System.Windows.Forms.Button();
            this.DiccionarioHome = new System.Windows.Forms.Button();
            this.IdS = new System.Windows.Forms.TabPage();
            this.label2IdS = new System.Windows.Forms.Label();
            this.SalirIdS = new System.Windows.Forms.Button();
            this.ComenzarIds = new System.Windows.Forms.Button();
            this.linkLabel1IdS = new System.Windows.Forms.LinkLabel();
            this.UserIdS = new System.Windows.Forms.TextBox();
            this.Menubutton = new System.Windows.Forms.Button();
            this.signIt.SuspendLayout();
            this.juegos.SuspendLayout();
            this.Ajustes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CdU.SuspendLayout();
            this.Home.SuspendLayout();
            this.IdS.SuspendLayout();
            this.SuspendLayout();
            // 
            // signIt
            // 
            this.signIt.Controls.Add(this.CdU);
            this.signIt.Controls.Add(this.Home);
            this.signIt.Controls.Add(this.LeccionesMenu);
            this.signIt.Controls.Add(this.Diccionario);
            this.signIt.Controls.Add(this.juegos);
            this.signIt.Controls.Add(this.Ajustes);
            this.signIt.Controls.Add(this.Lecciones_y_Ejercicios);
            this.signIt.Controls.Add(this.IdS);
            this.signIt.Location = new System.Drawing.Point(-35, 61);
            this.signIt.Name = "signIt";
            this.signIt.SelectedIndex = 0;
            this.signIt.Size = new System.Drawing.Size(1437, 831);
            this.signIt.TabIndex = 0;
            // 
            // LeccionesMenu
            // 
            this.LeccionesMenu.Location = new System.Drawing.Point(4, 22);
            this.LeccionesMenu.Name = "LeccionesMenu";
            this.LeccionesMenu.Size = new System.Drawing.Size(1429, 805);
            this.LeccionesMenu.TabIndex = 3;
            this.LeccionesMenu.Text = "LeccionesMenu";
            this.LeccionesMenu.UseVisualStyleBackColor = true;
            // 
            // Diccionario
            // 
            this.Diccionario.Location = new System.Drawing.Point(4, 22);
            this.Diccionario.Name = "Diccionario";
            this.Diccionario.Size = new System.Drawing.Size(1429, 805);
            this.Diccionario.TabIndex = 4;
            this.Diccionario.Text = "Diccioinario";
            this.Diccionario.UseVisualStyleBackColor = true;
            // 
            // juegos
            // 
            this.juegos.Controls.Add(this.MemotestGamesButton);
            this.juegos.Controls.Add(this.RaceGamesButton);
            this.juegos.Controls.Add(this.race1);
            this.juegos.Location = new System.Drawing.Point(4, 22);
            this.juegos.Name = "juegos";
            this.juegos.Size = new System.Drawing.Size(1429, 805);
            this.juegos.TabIndex = 6;
            this.juegos.Text = "juegos";
            this.juegos.UseVisualStyleBackColor = true;
            // 
            // MemotestGamesButton
            // 
            this.MemotestGamesButton.Location = new System.Drawing.Point(439, 203);
            this.MemotestGamesButton.Name = "MemotestGamesButton";
            this.MemotestGamesButton.Size = new System.Drawing.Size(75, 23);
            this.MemotestGamesButton.TabIndex = 1;
            this.MemotestGamesButton.Text = "Memotest";
            this.MemotestGamesButton.UseVisualStyleBackColor = true;
            this.MemotestGamesButton.Click += new System.EventHandler(this.MemotestGamesButton_Click);
            // 
            // RaceGamesButton
            // 
            this.RaceGamesButton.Location = new System.Drawing.Point(184, 203);
            this.RaceGamesButton.Name = "RaceGamesButton";
            this.RaceGamesButton.Size = new System.Drawing.Size(75, 23);
            this.RaceGamesButton.TabIndex = 0;
            this.RaceGamesButton.Text = "Race";
            this.RaceGamesButton.UseVisualStyleBackColor = true;
            this.RaceGamesButton.Click += new System.EventHandler(this.RaceGamesButton_Click);
            // 
            // Ajustes
            // 
            this.Ajustes.Controls.Add(this.FullScrButtonSett);
            this.Ajustes.Controls.Add(this.PantallaSett);
            this.Ajustes.Controls.Add(this.SonidoSett);
            this.Ajustes.Controls.Add(this.UserNameSett);
            this.Ajustes.Controls.Add(this.XProgresBarSett);
            this.Ajustes.Location = new System.Drawing.Point(4, 22);
            this.Ajustes.Name = "Ajustes";
            this.Ajustes.Size = new System.Drawing.Size(1429, 805);
            this.Ajustes.TabIndex = 5;
            this.Ajustes.Text = "Ajustes";
            this.Ajustes.UseVisualStyleBackColor = true;
            // 
            // FullScrButtonSett
            // 
            this.FullScrButtonSett.Location = new System.Drawing.Point(494, 322);
            this.FullScrButtonSett.Name = "FullScrButtonSett";
            this.FullScrButtonSett.Size = new System.Drawing.Size(75, 23);
            this.FullScrButtonSett.TabIndex = 4;
            this.FullScrButtonSett.Text = "Activado";
            this.FullScrButtonSett.UseVisualStyleBackColor = true;
            this.FullScrButtonSett.Click += new System.EventHandler(this.FullScrButtonSett_Click);
            // 
            // PantallaSett
            // 
            this.PantallaSett.AutoSize = true;
            this.PantallaSett.Location = new System.Drawing.Point(393, 327);
            this.PantallaSett.Name = "PantallaSett";
            this.PantallaSett.Size = new System.Drawing.Size(95, 13);
            this.PantallaSett.TabIndex = 3;
            this.PantallaSett.Text = "Pantalla Completa:";
            // 
            // SonidoSett
            // 
            this.SonidoSett.AutoSize = true;
            this.SonidoSett.Location = new System.Drawing.Point(428, 276);
            this.SonidoSett.Name = "SonidoSett";
            this.SonidoSett.Size = new System.Drawing.Size(40, 13);
            this.SonidoSett.TabIndex = 2;
            this.SonidoSett.Text = "Sonido";
            // 
            // UserNameSett
            // 
            this.UserNameSett.AutoSize = true;
            this.UserNameSett.Location = new System.Drawing.Point(393, 226);
            this.UserNameSett.Name = "UserNameSett";
            this.UserNameSett.Size = new System.Drawing.Size(104, 13);
            this.UserNameSett.TabIndex = 1;
            this.UserNameSett.Text = "Nombre de Usuario: ";
            // 
            // XProgresBarSett
            // 
            this.XProgresBarSett.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.XProgresBarSett.AnimationSpeed = 500;
            this.XProgresBarSett.BackColor = System.Drawing.Color.Transparent;
            this.XProgresBarSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.XProgresBarSett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.XProgresBarSett.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.XProgresBarSett.InnerMargin = 2;
            this.XProgresBarSett.InnerWidth = -1;
            this.XProgresBarSett.Location = new System.Drawing.Point(629, 90);
            this.XProgresBarSett.MarqueeAnimationSpeed = 2000;
            this.XProgresBarSett.Name = "XProgresBarSett";
            this.XProgresBarSett.OuterColor = System.Drawing.Color.Gray;
            this.XProgresBarSett.OuterMargin = -25;
            this.XProgresBarSett.OuterWidth = 26;
            this.XProgresBarSett.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.XProgresBarSett.ProgressWidth = 25;
            this.XProgresBarSett.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.XProgresBarSett.Size = new System.Drawing.Size(320, 320);
            this.XProgresBarSett.StartAngle = 270;
            this.XProgresBarSett.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.XProgresBarSett.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.XProgresBarSett.SubscriptText = "";
            this.XProgresBarSett.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.XProgresBarSett.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.XProgresBarSett.SuperscriptText = "";
            this.XProgresBarSett.TabIndex = 0;
            this.XProgresBarSett.Text = "0";
            this.XProgresBarSett.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.XProgresBarSett.Value = 68;
            // 
            // Lecciones_y_Ejercicios
            // 
            this.Lecciones_y_Ejercicios.Location = new System.Drawing.Point(4, 22);
            this.Lecciones_y_Ejercicios.Name = "Lecciones_y_Ejercicios";
            this.Lecciones_y_Ejercicios.Size = new System.Drawing.Size(1429, 805);
            this.Lecciones_y_Ejercicios.TabIndex = 7;
            this.Lecciones_y_Ejercicios.Text = "Lecciones y Ejercicios";
            this.Lecciones_y_Ejercicios.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.MenuExitButton);
            this.panel1.Controls.Add(this.MenuSettingsButton);
            this.panel1.Controls.Add(this.MenuGamesButton);
            this.panel1.Controls.Add(this.MenuDiccionarioButton);
            this.panel1.Controls.Add(this.MenuLectionsButton);
            this.panel1.Controls.Add(this.MenuHomeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 775);
            this.panel1.TabIndex = 2;
            // 
            // MenuExitButton
            // 
            this.MenuExitButton.Location = new System.Drawing.Point(3, 438);
            this.MenuExitButton.Name = "MenuExitButton";
            this.MenuExitButton.Size = new System.Drawing.Size(194, 64);
            this.MenuExitButton.TabIndex = 5;
            this.MenuExitButton.Text = "Salir";
            this.MenuExitButton.UseVisualStyleBackColor = true;
            this.MenuExitButton.Click += new System.EventHandler(this.MenuExitButton_Click);
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.Location = new System.Drawing.Point(3, 368);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(194, 64);
            this.MenuSettingsButton.TabIndex = 4;
            this.MenuSettingsButton.Text = "Ajustes";
            this.MenuSettingsButton.UseVisualStyleBackColor = true;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuGamesButton
            // 
            this.MenuGamesButton.Location = new System.Drawing.Point(3, 298);
            this.MenuGamesButton.Name = "MenuGamesButton";
            this.MenuGamesButton.Size = new System.Drawing.Size(194, 64);
            this.MenuGamesButton.TabIndex = 3;
            this.MenuGamesButton.Text = "Juegos";
            this.MenuGamesButton.UseVisualStyleBackColor = true;
            this.MenuGamesButton.Click += new System.EventHandler(this.MenuGamesButton_Click);
            // 
            // MenuDiccionarioButton
            // 
            this.MenuDiccionarioButton.Location = new System.Drawing.Point(3, 228);
            this.MenuDiccionarioButton.Name = "MenuDiccionarioButton";
            this.MenuDiccionarioButton.Size = new System.Drawing.Size(194, 64);
            this.MenuDiccionarioButton.TabIndex = 2;
            this.MenuDiccionarioButton.Text = "Diccionario";
            this.MenuDiccionarioButton.UseVisualStyleBackColor = true;
            this.MenuDiccionarioButton.Click += new System.EventHandler(this.MenuDiccionarioButton_Click);
            // 
            // MenuLectionsButton
            // 
            this.MenuLectionsButton.Location = new System.Drawing.Point(3, 158);
            this.MenuLectionsButton.Name = "MenuLectionsButton";
            this.MenuLectionsButton.Size = new System.Drawing.Size(194, 64);
            this.MenuLectionsButton.TabIndex = 1;
            this.MenuLectionsButton.Text = "Lecciones";
            this.MenuLectionsButton.UseVisualStyleBackColor = true;
            this.MenuLectionsButton.Click += new System.EventHandler(this.MenuLectionsButton_Click);
            // 
            // MenuHomeButton
            // 
            this.MenuHomeButton.Location = new System.Drawing.Point(3, 88);
            this.MenuHomeButton.Name = "MenuHomeButton";
            this.MenuHomeButton.Size = new System.Drawing.Size(194, 64);
            this.MenuHomeButton.TabIndex = 0;
            this.MenuHomeButton.Text = "Home";
            this.MenuHomeButton.UseVisualStyleBackColor = true;
            this.MenuHomeButton.Click += new System.EventHandler(this.MenuHomeButton_Click);
            // 
            // race1
            // 
            this.race1.Location = new System.Drawing.Point(1, 0);
            this.race1.Name = "race1";
            this.race1.Size = new System.Drawing.Size(1361, 745);
            this.race1.TabIndex = 2;
            this.race1.Visible = false;
            // 
            // CdU
            // 
            this.CdU.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.CdU.Controls.Add(this.UserCdU);
            this.CdU.Controls.Add(this.label1CdU);
            this.CdU.Controls.Add(this.ComenzarCdU);
            this.CdU.Controls.Add(this.SnapBackToReality);
            this.CdU.Location = new System.Drawing.Point(4, 22);
            this.CdU.Name = "CdU";
            this.CdU.Padding = new System.Windows.Forms.Padding(3);
            this.CdU.Size = new System.Drawing.Size(1429, 805);
            this.CdU.TabIndex = 1;
            this.CdU.Text = "Creación de usuario";
            this.CdU.UseVisualStyleBackColor = true;
            // 
            // UserCdU
            // 
            this.UserCdU.Location = new System.Drawing.Point(529, 335);
            this.UserCdU.Name = "UserCdU";
            this.UserCdU.Size = new System.Drawing.Size(100, 20);
            this.UserCdU.TabIndex = 3;
            // 
            // label1CdU
            // 
            this.label1CdU.AutoSize = true;
            this.label1CdU.Location = new System.Drawing.Point(527, 372);
            this.label1CdU.Name = "label1CdU";
            this.label1CdU.Size = new System.Drawing.Size(102, 13);
            this.label1CdU.TabIndex = 2;
            this.label1CdU.Text = "Usuario ya existente";
            // 
            // ComenzarCdU
            // 
            this.ComenzarCdU.Location = new System.Drawing.Point(544, 403);
            this.ComenzarCdU.Name = "ComenzarCdU";
            this.ComenzarCdU.Size = new System.Drawing.Size(75, 23);
            this.ComenzarCdU.TabIndex = 1;
            this.ComenzarCdU.Text = "Crear";
            this.ComenzarCdU.UseVisualStyleBackColor = true;
            this.ComenzarCdU.Click += new System.EventHandler(this.ComenzarCdU_Click);
            // 
            // SnapBackToReality
            // 
            this.SnapBackToReality.BackColor = System.Drawing.Color.DarkTurquoise;
            this.SnapBackToReality.BackgroundImage = global::SignIt.Properties.Resources.Group_44;
            this.SnapBackToReality.ForeColor = System.Drawing.Color.Black;
            this.SnapBackToReality.Location = new System.Drawing.Point(31, 26);
            this.SnapBackToReality.Name = "SnapBackToReality";
            this.SnapBackToReality.Size = new System.Drawing.Size(137, 134);
            this.SnapBackToReality.TabIndex = 0;
            this.SnapBackToReality.UseVisualStyleBackColor = false;
            this.SnapBackToReality.Click += new System.EventHandler(this.SnapBackToReality_Click);
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.Home.Controls.Add(this.UserHome);
            this.Home.Controls.Add(this.LeccionesHome);
            this.Home.Controls.Add(this.DiccionarioHome);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1429, 805);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // UserHome
            // 
            this.UserHome.AutoSize = true;
            this.UserHome.Location = new System.Drawing.Point(1241, 11);
            this.UserHome.Name = "UserHome";
            this.UserHome.Size = new System.Drawing.Size(43, 13);
            this.UserHome.TabIndex = 2;
            this.UserHome.Text = "Usuario";
            // 
            // LeccionesHome
            // 
            this.LeccionesHome.Location = new System.Drawing.Point(526, 345);
            this.LeccionesHome.Name = "LeccionesHome";
            this.LeccionesHome.Size = new System.Drawing.Size(128, 60);
            this.LeccionesHome.TabIndex = 1;
            this.LeccionesHome.Text = "Continua con tus lecciones";
            this.LeccionesHome.UseVisualStyleBackColor = true;
            this.LeccionesHome.Click += new System.EventHandler(this.LeccionesHome_Click);
            // 
            // DiccionarioHome
            // 
            this.DiccionarioHome.Location = new System.Drawing.Point(526, 188);
            this.DiccionarioHome.Name = "DiccionarioHome";
            this.DiccionarioHome.Size = new System.Drawing.Size(139, 61);
            this.DiccionarioHome.TabIndex = 0;
            this.DiccionarioHome.Text = "Explora el diccionario";
            this.DiccionarioHome.UseVisualStyleBackColor = true;
            this.DiccionarioHome.Click += new System.EventHandler(this.DiccionarioHome_Click);
            // 
            // IdS
            // 
            this.IdS.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.IdS.Controls.Add(this.label2IdS);
            this.IdS.Controls.Add(this.SalirIdS);
            this.IdS.Controls.Add(this.ComenzarIds);
            this.IdS.Controls.Add(this.linkLabel1IdS);
            this.IdS.Controls.Add(this.UserIdS);
            this.IdS.Location = new System.Drawing.Point(4, 22);
            this.IdS.Name = "IdS";
            this.IdS.Padding = new System.Windows.Forms.Padding(3);
            this.IdS.Size = new System.Drawing.Size(1429, 805);
            this.IdS.TabIndex = 0;
            this.IdS.Text = "Inicio de Sesión";
            this.IdS.UseVisualStyleBackColor = true;
            this.IdS.Click += new System.EventHandler(this.IdS_Click);
            // 
            // label2IdS
            // 
            this.label2IdS.AutoSize = true;
            this.label2IdS.Location = new System.Drawing.Point(568, 336);
            this.label2IdS.Name = "label2IdS";
            this.label2IdS.Size = new System.Drawing.Size(93, 13);
            this.label2IdS.TabIndex = 5;
            this.label2IdS.Text = "Usuario incorrecto";
            // 
            // SalirIdS
            // 
            this.SalirIdS.Location = new System.Drawing.Point(848, 487);
            this.SalirIdS.Name = "SalirIdS";
            this.SalirIdS.Size = new System.Drawing.Size(75, 23);
            this.SalirIdS.TabIndex = 4;
            this.SalirIdS.Text = "Salir";
            this.SalirIdS.UseVisualStyleBackColor = true;
            this.SalirIdS.Click += new System.EventHandler(this.SalirIdS_Click);
            // 
            // ComenzarIds
            // 
            this.ComenzarIds.Location = new System.Drawing.Point(571, 370);
            this.ComenzarIds.Name = "ComenzarIds";
            this.ComenzarIds.Size = new System.Drawing.Size(75, 23);
            this.ComenzarIds.TabIndex = 3;
            this.ComenzarIds.Text = "Comenzar";
            this.ComenzarIds.UseVisualStyleBackColor = true;
            this.ComenzarIds.Click += new System.EventHandler(this.ComenzarIds_Click);
            // 
            // linkLabel1IdS
            // 
            this.linkLabel1IdS.AutoSize = true;
            this.linkLabel1IdS.Location = new System.Drawing.Point(524, 412);
            this.linkLabel1IdS.Name = "linkLabel1IdS";
            this.linkLabel1IdS.Size = new System.Drawing.Size(176, 13);
            this.linkLabel1IdS.TabIndex = 1;
            this.linkLabel1IdS.TabStop = true;
            this.linkLabel1IdS.Text = "Haz click aquí para crear un usuaio";
            this.linkLabel1IdS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1IdS_LinkClicked);
            // 
            // UserIdS
            // 
            this.UserIdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UserIdS.Location = new System.Drawing.Point(487, 273);
            this.UserIdS.Name = "UserIdS";
            this.UserIdS.Size = new System.Drawing.Size(231, 38);
            this.UserIdS.TabIndex = 0;
            // 
            // Menubutton
            // 
            this.Menubutton.BackgroundImage = global::SignIt.Properties.Resources._3_rayitas__2_;
            this.Menubutton.Location = new System.Drawing.Point(0, 0);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(100, 75);
            this.Menubutton.TabIndex = 3;
            this.Menubutton.UseVisualStyleBackColor = true;
            this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.signIt);
            this.Controls.Add(this.Menubutton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.signIt.ResumeLayout(false);
            this.juegos.ResumeLayout(false);
            this.Ajustes.ResumeLayout(false);
            this.Ajustes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.CdU.ResumeLayout(false);
            this.CdU.PerformLayout();
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.IdS.ResumeLayout(false);
            this.IdS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl signIt;
        private System.Windows.Forms.TabPage IdS;
        private System.Windows.Forms.TabPage CdU;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage LeccionesMenu;
        private System.Windows.Forms.TabPage Diccionario;
        private System.Windows.Forms.TabPage Ajustes;
        private System.Windows.Forms.TabPage juegos;
        private System.Windows.Forms.TabPage Lecciones_y_Ejercicios;
        private System.Windows.Forms.Button SalirIdS;
        private System.Windows.Forms.Button ComenzarIds;
        private System.Windows.Forms.LinkLabel linkLabel1IdS;
        private System.Windows.Forms.TextBox UserIdS;
        private System.Windows.Forms.Button ComenzarCdU;
        private System.Windows.Forms.Button SnapBackToReality;
        private System.Windows.Forms.TextBox UserCdU;
        private System.Windows.Forms.Label label1CdU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LeccionesHome;
        private System.Windows.Forms.Button DiccionarioHome;
        private System.Windows.Forms.Button MenuExitButton;
        private System.Windows.Forms.Button MenuSettingsButton;
        private System.Windows.Forms.Button MenuGamesButton;
        private System.Windows.Forms.Button MenuDiccionarioButton;
        private System.Windows.Forms.Button MenuLectionsButton;
        private System.Windows.Forms.Button MenuHomeButton;
        private System.Windows.Forms.Button Menubutton;
        private System.Windows.Forms.Label PantallaSett;
        private System.Windows.Forms.Label SonidoSett;
        private System.Windows.Forms.Label UserNameSett;
        private CircularProgressBar.CircularProgressBar XProgresBarSett;
        private System.Windows.Forms.Button FullScrButtonSett;
        private System.Windows.Forms.Label label2IdS;
        private System.Windows.Forms.Label UserHome;
        private System.Windows.Forms.Button MemotestGamesButton;
        private System.Windows.Forms.Button RaceGamesButton;
        private Race race1;
    }
}

