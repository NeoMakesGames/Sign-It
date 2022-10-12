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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signIt = new System.Windows.Forms.TabControl();
            this.IdS = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2IdS = new System.Windows.Forms.Label();
            this.SalirIdS = new System.Windows.Forms.Button();
            this.ComenzarIds = new System.Windows.Forms.Button();
            this.linkLabel1IdS = new System.Windows.Forms.LinkLabel();
            this.UserIdS = new System.Windows.Forms.TextBox();
            this.CdU = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserCdU = new System.Windows.Forms.TextBox();
            this.label1CdU = new System.Windows.Forms.Label();
            this.ComenzarCdU = new System.Windows.Forms.Button();
            this.SnapBackToReality = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.TabPage();
            this.sliderHomeDer = new System.Windows.Forms.Button();
            this.sliderHomeIz = new System.Windows.Forms.Button();
            this.sliderHome = new System.Windows.Forms.Panel();
            this.DiccionarioHome = new System.Windows.Forms.Button();
            this.LeccionesHome = new System.Windows.Forms.Button();
            this.UserHome = new System.Windows.Forms.Label();
            this.LeccionesMenu = new System.Windows.Forms.TabPage();
            this.Diccionario = new System.Windows.Forms.TabPage();
            this.juegos = new System.Windows.Forms.TabPage();
            this.MemotestGamesButton = new System.Windows.Forms.Button();
            this.RaceGamesButton = new System.Windows.Forms.Button();
            this.race1 = new SignIt.Race();
            this.Ajustes = new System.Windows.Forms.TabPage();
            this.FullScrButtonSett = new System.Windows.Forms.Button();
            this.PantallaSett = new System.Windows.Forms.Label();
            this.SonidoSett = new System.Windows.Forms.Label();
            this.UserNameSett = new System.Windows.Forms.Label();
            this.XProgresBarSett = new CircularProgressBar.CircularProgressBar();
            this.Lecciones_y_Ejercicios = new System.Windows.Forms.TabPage();
            this.tuto1 = new SignIt.tuto();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.MenuSettingsButton = new System.Windows.Forms.Button();
            this.MenuGamesButton = new System.Windows.Forms.Button();
            this.MenuDiccionarioButton = new System.Windows.Forms.Button();
            this.MenuLectionsButton = new System.Windows.Forms.Button();
            this.MenuHomeButton = new System.Windows.Forms.Button();
            this.Menubutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.signIt.SuspendLayout();
            this.IdS.SuspendLayout();
            this.CdU.SuspendLayout();
            this.Home.SuspendLayout();
            this.juegos.SuspendLayout();
            this.Ajustes.SuspendLayout();
            this.Lecciones_y_Ejercicios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signIt
            // 
            this.signIt.Controls.Add(this.IdS);
            this.signIt.Controls.Add(this.CdU);
            this.signIt.Controls.Add(this.Home);
            this.signIt.Controls.Add(this.LeccionesMenu);
            this.signIt.Controls.Add(this.Diccionario);
            this.signIt.Controls.Add(this.juegos);
            this.signIt.Controls.Add(this.Ajustes);
            this.signIt.Controls.Add(this.Lecciones_y_Ejercicios);
            this.signIt.Location = new System.Drawing.Point(-5, 0);
            this.signIt.Name = "signIt";
            this.signIt.SelectedIndex = 0;
            this.signIt.Size = new System.Drawing.Size(1437, 831);
            this.signIt.TabIndex = 0;
            // 
            // IdS
            // 
            this.IdS.BackColor = System.Drawing.Color.LightBlue;
            this.IdS.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.IdS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IdS.Controls.Add(this.panel2);
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
            this.IdS.Click += new System.EventHandler(this.IdS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SignIt.Properties.Resources.logo_azul_sin_fondo_1;
            this.panel2.Location = new System.Drawing.Point(454, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 206);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2IdS
            // 
            this.label2IdS.AutoSize = true;
            this.label2IdS.BackColor = System.Drawing.Color.Transparent;
            this.label2IdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2IdS.ForeColor = System.Drawing.Color.IndianRed;
            this.label2IdS.Location = new System.Drawing.Point(555, 416);
            this.label2IdS.Name = "label2IdS";
            this.label2IdS.Size = new System.Drawing.Size(235, 31);
            this.label2IdS.TabIndex = 5;
            this.label2IdS.Text = "Usuario incorrecto";
            this.label2IdS.Click += new System.EventHandler(this.label2IdS_Click);
            // 
            // SalirIdS
            // 
            this.SalirIdS.BackColor = System.Drawing.Color.Transparent;
            this.SalirIdS.BackgroundImage = global::SignIt.Properties.Resources.Ícono_de_salir__1_;
            this.SalirIdS.Location = new System.Drawing.Point(1246, 645);
            this.SalirIdS.Name = "SalirIdS";
            this.SalirIdS.Size = new System.Drawing.Size(64, 57);
            this.SalirIdS.TabIndex = 4;
            this.SalirIdS.UseVisualStyleBackColor = false;
            this.SalirIdS.Click += new System.EventHandler(this.SalirIdS_Click);
            // 
            // ComenzarIds
            // 
            this.ComenzarIds.BackColor = System.Drawing.Color.Transparent;
            this.ComenzarIds.BackgroundImage = global::SignIt.Properties.Resources.Botón;
            this.ComenzarIds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComenzarIds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComenzarIds.Location = new System.Drawing.Point(462, 481);
            this.ComenzarIds.Name = "ComenzarIds";
            this.ComenzarIds.Size = new System.Drawing.Size(420, 85);
            this.ComenzarIds.TabIndex = 3;
            this.ComenzarIds.UseVisualStyleBackColor = false;
            this.ComenzarIds.Click += new System.EventHandler(this.ComenzarIds_Click);
            // 
            // linkLabel1IdS
            // 
            this.linkLabel1IdS.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1IdS.AutoSize = true;
            this.linkLabel1IdS.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1IdS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1IdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.linkLabel1IdS.Location = new System.Drawing.Point(454, 613);
            this.linkLabel1IdS.Name = "linkLabel1IdS";
            this.linkLabel1IdS.Size = new System.Drawing.Size(446, 31);
            this.linkLabel1IdS.TabIndex = 1;
            this.linkLabel1IdS.TabStop = true;
            this.linkLabel1IdS.Text = "¿No tienes usuario? ¡Haz click aquí!";
            this.linkLabel1IdS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1IdS_LinkClicked);
            // 
            // UserIdS
            // 
            this.UserIdS.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.UserIdS.Location = new System.Drawing.Point(454, 290);
            this.UserIdS.Name = "UserIdS";
            this.UserIdS.Size = new System.Drawing.Size(435, 83);
            this.UserIdS.TabIndex = 0;
            this.UserIdS.TextChanged += new System.EventHandler(this.UserIdS_TextChanged);
            // 
            // CdU
            // 
            this.CdU.BackColor = System.Drawing.Color.LightBlue;
            this.CdU.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.CdU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CdU.Controls.Add(this.panel3);
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::SignIt.Properties.Resources.logo_azul_sin_fondo_1;
            this.panel3.Location = new System.Drawing.Point(454, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 206);
            this.panel3.TabIndex = 7;
            // 
            // UserCdU
            // 
            this.UserCdU.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.UserCdU.Location = new System.Drawing.Point(454, 290);
            this.UserCdU.Name = "UserCdU";
            this.UserCdU.Size = new System.Drawing.Size(435, 83);
            this.UserCdU.TabIndex = 3;
            // 
            // label1CdU
            // 
            this.label1CdU.AutoSize = true;
            this.label1CdU.BackColor = System.Drawing.Color.Transparent;
            this.label1CdU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1CdU.ForeColor = System.Drawing.Color.IndianRed;
            this.label1CdU.Location = new System.Drawing.Point(541, 416);
            this.label1CdU.Name = "label1CdU";
            this.label1CdU.Size = new System.Drawing.Size(260, 31);
            this.label1CdU.TabIndex = 2;
            this.label1CdU.Text = "Usuario ya existente";
            // 
            // ComenzarCdU
            // 
            this.ComenzarCdU.BackColor = System.Drawing.Color.Transparent;
            this.ComenzarCdU.BackgroundImage = global::SignIt.Properties.Resources.Botón__1_;
            this.ComenzarCdU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComenzarCdU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComenzarCdU.Location = new System.Drawing.Point(461, 481);
            this.ComenzarCdU.Name = "ComenzarCdU";
            this.ComenzarCdU.Size = new System.Drawing.Size(420, 85);
            this.ComenzarCdU.TabIndex = 1;
            this.ComenzarCdU.UseVisualStyleBackColor = false;
            this.ComenzarCdU.Click += new System.EventHandler(this.ComenzarCdU_Click);
            // 
            // SnapBackToReality
            // 
            this.SnapBackToReality.BackColor = System.Drawing.Color.Transparent;
            this.SnapBackToReality.BackgroundImage = global::SignIt.Properties.Resources.Flecha;
            this.SnapBackToReality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SnapBackToReality.ForeColor = System.Drawing.Color.Black;
            this.SnapBackToReality.Location = new System.Drawing.Point(31, 26);
            this.SnapBackToReality.Name = "SnapBackToReality";
            this.SnapBackToReality.Size = new System.Drawing.Size(125, 102);
            this.SnapBackToReality.TabIndex = 0;
            this.SnapBackToReality.UseVisualStyleBackColor = false;
            this.SnapBackToReality.Click += new System.EventHandler(this.SnapBackToReality_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.LightBlue;
            this.Home.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Controls.Add(this.sliderHomeDer);
            this.Home.Controls.Add(this.sliderHomeIz);
            this.Home.Controls.Add(this.sliderHome);
            this.Home.Controls.Add(this.DiccionarioHome);
            this.Home.Controls.Add(this.LeccionesHome);
            this.Home.Controls.Add(this.UserHome);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1429, 805);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            // 
            // sliderHomeDer
            // 
            this.sliderHomeDer.BackColor = System.Drawing.Color.Transparent;
            this.sliderHomeDer.BackgroundImage = global::SignIt.Properties.Resources.Group_57;
            this.sliderHomeDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sliderHomeDer.Location = new System.Drawing.Point(1262, 312);
            this.sliderHomeDer.Name = "sliderHomeDer";
            this.sliderHomeDer.Size = new System.Drawing.Size(40, 80);
            this.sliderHomeDer.TabIndex = 5;
            this.sliderHomeDer.UseVisualStyleBackColor = false;
            this.sliderHomeDer.Click += new System.EventHandler(this.sliderHomeDer_Click);
            // 
            // sliderHomeIz
            // 
            this.sliderHomeIz.BackColor = System.Drawing.Color.Transparent;
            this.sliderHomeIz.BackgroundImage = global::SignIt.Properties.Resources.Group_561;
            this.sliderHomeIz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sliderHomeIz.Location = new System.Drawing.Point(876, 312);
            this.sliderHomeIz.Name = "sliderHomeIz";
            this.sliderHomeIz.Size = new System.Drawing.Size(40, 80);
            this.sliderHomeIz.TabIndex = 4;
            this.sliderHomeIz.UseVisualStyleBackColor = false;
            this.sliderHomeIz.Click += new System.EventHandler(this.sliderHomeIz_Click);
            // 
            // sliderHome
            // 
            this.sliderHome.BackColor = System.Drawing.Color.Teal;
            this.sliderHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sliderHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderHome.Location = new System.Drawing.Point(904, 168);
            this.sliderHome.Name = "sliderHome";
            this.sliderHome.Size = new System.Drawing.Size(365, 365);
            this.sliderHome.TabIndex = 3;
            // 
            // DiccionarioHome
            // 
            this.DiccionarioHome.BackColor = System.Drawing.Color.Transparent;
            this.DiccionarioHome.BackgroundImage = global::SignIt.Properties.Resources.Group_54__1_1;
            this.DiccionarioHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DiccionarioHome.Location = new System.Drawing.Point(372, 376);
            this.DiccionarioHome.Name = "DiccionarioHome";
            this.DiccionarioHome.Size = new System.Drawing.Size(388, 160);
            this.DiccionarioHome.TabIndex = 2;
            this.DiccionarioHome.UseVisualStyleBackColor = false;
            this.DiccionarioHome.Click += new System.EventHandler(this.DiccionarioHome_Click_1);
            // 
            // LeccionesHome
            // 
            this.LeccionesHome.BackColor = System.Drawing.Color.Transparent;
            this.LeccionesHome.BackgroundImage = global::SignIt.Properties.Resources.Group_41__2_;
            this.LeccionesHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeccionesHome.Location = new System.Drawing.Point(372, 168);
            this.LeccionesHome.Name = "LeccionesHome";
            this.LeccionesHome.Size = new System.Drawing.Size(388, 160);
            this.LeccionesHome.TabIndex = 1;
            this.LeccionesHome.UseVisualStyleBackColor = false;
            this.LeccionesHome.Click += new System.EventHandler(this.LeccionesHome_Click_1);
            // 
            // UserHome
            // 
            this.UserHome.AutoSize = true;
            this.UserHome.BackColor = System.Drawing.Color.Transparent;
            this.UserHome.Location = new System.Drawing.Point(1281, 40);
            this.UserHome.Name = "UserHome";
            this.UserHome.Size = new System.Drawing.Size(35, 13);
            this.UserHome.TabIndex = 0;
            this.UserHome.Text = "label1";
            // 
            // LeccionesMenu
            // 
            this.LeccionesMenu.BackColor = System.Drawing.Color.LightBlue;
            this.LeccionesMenu.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.LeccionesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeccionesMenu.Location = new System.Drawing.Point(4, 22);
            this.LeccionesMenu.Name = "LeccionesMenu";
            this.LeccionesMenu.Size = new System.Drawing.Size(1429, 805);
            this.LeccionesMenu.TabIndex = 3;
            this.LeccionesMenu.Text = "LeccionesMenu";
            // 
            // Diccionario
            // 
            this.Diccionario.BackColor = System.Drawing.Color.LightBlue;
            this.Diccionario.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.Diccionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Diccionario.Location = new System.Drawing.Point(4, 22);
            this.Diccionario.Name = "Diccionario";
            this.Diccionario.Size = new System.Drawing.Size(1429, 805);
            this.Diccionario.TabIndex = 4;
            this.Diccionario.Text = "Diccioinario";
            // 
            // juegos
            // 
            this.juegos.BackColor = System.Drawing.Color.LightBlue;
            this.juegos.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.juegos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.juegos.Controls.Add(this.MemotestGamesButton);
            this.juegos.Controls.Add(this.RaceGamesButton);
            this.juegos.Controls.Add(this.race1);
            this.juegos.Location = new System.Drawing.Point(4, 22);
            this.juegos.Name = "juegos";
            this.juegos.Size = new System.Drawing.Size(1429, 805);
            this.juegos.TabIndex = 6;
            this.juegos.Text = "juegos";
            // 
            // MemotestGamesButton
            // 
            this.MemotestGamesButton.BackgroundImage = global::SignIt.Properties.Resources.Group_47__1_;
            this.MemotestGamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MemotestGamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemotestGamesButton.Location = new System.Drawing.Point(780, 98);
            this.MemotestGamesButton.Name = "MemotestGamesButton";
            this.MemotestGamesButton.Size = new System.Drawing.Size(300, 350);
            this.MemotestGamesButton.TabIndex = 1;
            this.MemotestGamesButton.UseVisualStyleBackColor = true;
            this.MemotestGamesButton.Click += new System.EventHandler(this.MemotestGamesButton_Click);
            // 
            // RaceGamesButton
            // 
            this.RaceGamesButton.BackgroundImage = global::SignIt.Properties.Resources.Group_48;
            this.RaceGamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RaceGamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RaceGamesButton.Location = new System.Drawing.Point(290, 98);
            this.RaceGamesButton.Name = "RaceGamesButton";
            this.RaceGamesButton.Size = new System.Drawing.Size(300, 350);
            this.RaceGamesButton.TabIndex = 0;
            this.RaceGamesButton.UseVisualStyleBackColor = true;
            this.RaceGamesButton.Click += new System.EventHandler(this.RaceGamesButton_Click);
            // 
            // race1
            // 
            this.race1.BackColor = System.Drawing.Color.SteelBlue;
            this.race1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("race1.BackgroundImage")));
            this.race1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.race1.Location = new System.Drawing.Point(2, -12);
            this.race1.Name = "race1";
            this.race1.Size = new System.Drawing.Size(1430, 823);
            this.race1.TabIndex = 2;
            this.race1.Visible = false;
            // 
            // Ajustes
            // 
            this.Ajustes.BackColor = System.Drawing.Color.LightBlue;
            this.Ajustes.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.Ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Lecciones_y_Ejercicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lecciones_y_Ejercicios.Controls.Add(this.tuto1);
            this.Lecciones_y_Ejercicios.Location = new System.Drawing.Point(4, 22);
            this.Lecciones_y_Ejercicios.Name = "Lecciones_y_Ejercicios";
            this.Lecciones_y_Ejercicios.Size = new System.Drawing.Size(1429, 805);
            this.Lecciones_y_Ejercicios.TabIndex = 7;
            this.Lecciones_y_Ejercicios.Text = "Lecciones y Ejercicios";
            this.Lecciones_y_Ejercicios.UseVisualStyleBackColor = true;
            // 
            // tuto1
            // 
            this.tuto1.BackColor = System.Drawing.Color.LightBlue;
            this.tuto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tuto1.BackgroundImage")));
            this.tuto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tuto1.Location = new System.Drawing.Point(0, 0);
            this.tuto1.Name = "tuto1";
            this.tuto1.Size = new System.Drawing.Size(1366, 788);
            this.tuto1.TabIndex = 0;
            this.tuto1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.MenuExitButton);
            this.panel1.Controls.Add(this.MenuSettingsButton);
            this.panel1.Controls.Add(this.MenuGamesButton);
            this.panel1.Controls.Add(this.MenuDiccionarioButton);
            this.panel1.Controls.Add(this.MenuLectionsButton);
            this.panel1.Controls.Add(this.MenuHomeButton);
            this.panel1.Location = new System.Drawing.Point(0, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 807);
            this.panel1.TabIndex = 2;
            // 
            // MenuExitButton
            // 
            this.MenuExitButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuExitButton.BackgroundImage = global::SignIt.Properties.Resources.Group_55__2_;
            this.MenuExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuExitButton.Location = new System.Drawing.Point(3, 637);
            this.MenuExitButton.Name = "MenuExitButton";
            this.MenuExitButton.Size = new System.Drawing.Size(326, 100);
            this.MenuExitButton.TabIndex = 5;
            this.MenuExitButton.UseVisualStyleBackColor = false;
            this.MenuExitButton.Click += new System.EventHandler(this.MenuExitButton_Click);
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuSettingsButton.BackgroundImage = global::SignIt.Properties.Resources.Group_53;
            this.MenuSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuSettingsButton.Location = new System.Drawing.Point(3, 531);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(326, 100);
            this.MenuSettingsButton.TabIndex = 4;
            this.MenuSettingsButton.UseVisualStyleBackColor = false;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuGamesButton
            // 
            this.MenuGamesButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuGamesButton.BackgroundImage = global::SignIt.Properties.Resources.Group_52;
            this.MenuGamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuGamesButton.Location = new System.Drawing.Point(3, 425);
            this.MenuGamesButton.Name = "MenuGamesButton";
            this.MenuGamesButton.Size = new System.Drawing.Size(326, 100);
            this.MenuGamesButton.TabIndex = 3;
            this.MenuGamesButton.UseVisualStyleBackColor = false;
            this.MenuGamesButton.Click += new System.EventHandler(this.MenuGamesButton_Click);
            // 
            // MenuDiccionarioButton
            // 
            this.MenuDiccionarioButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuDiccionarioButton.BackgroundImage = global::SignIt.Properties.Resources.Group_50;
            this.MenuDiccionarioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuDiccionarioButton.Location = new System.Drawing.Point(3, 319);
            this.MenuDiccionarioButton.Name = "MenuDiccionarioButton";
            this.MenuDiccionarioButton.Size = new System.Drawing.Size(326, 100);
            this.MenuDiccionarioButton.TabIndex = 2;
            this.MenuDiccionarioButton.UseVisualStyleBackColor = false;
            this.MenuDiccionarioButton.Click += new System.EventHandler(this.MenuDiccionarioButton_Click);
            // 
            // MenuLectionsButton
            // 
            this.MenuLectionsButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuLectionsButton.BackgroundImage = global::SignIt.Properties.Resources.Group_49;
            this.MenuLectionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuLectionsButton.Location = new System.Drawing.Point(3, 213);
            this.MenuLectionsButton.Name = "MenuLectionsButton";
            this.MenuLectionsButton.Size = new System.Drawing.Size(326, 100);
            this.MenuLectionsButton.TabIndex = 1;
            this.MenuLectionsButton.UseVisualStyleBackColor = false;
            this.MenuLectionsButton.Click += new System.EventHandler(this.MenuLectionsButton_Click);
            // 
            // MenuHomeButton
            // 
            this.MenuHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuHomeButton.BackgroundImage = global::SignIt.Properties.Resources._3_rayitas_botón;
            this.MenuHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuHomeButton.Location = new System.Drawing.Point(3, 104);
            this.MenuHomeButton.Name = "MenuHomeButton";
            this.MenuHomeButton.Size = new System.Drawing.Size(326, 100);
            this.MenuHomeButton.TabIndex = 0;
            this.MenuHomeButton.UseVisualStyleBackColor = false;
            this.MenuHomeButton.Click += new System.EventHandler(this.MenuHomeButton_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Text = "SignIt!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.signIt.ResumeLayout(false);
            this.IdS.ResumeLayout(false);
            this.IdS.PerformLayout();
            this.CdU.ResumeLayout(false);
            this.CdU.PerformLayout();
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.juegos.ResumeLayout(false);
            this.Ajustes.ResumeLayout(false);
            this.Ajustes.PerformLayout();
            this.Lecciones_y_Ejercicios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl signIt;
        private System.Windows.Forms.TabPage IdS;
        private System.Windows.Forms.TabPage CdU;
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
        private System.Windows.Forms.Button MemotestGamesButton;
        private System.Windows.Forms.Button RaceGamesButton;
        private Race race1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Button LeccionesHome;
        private System.Windows.Forms.Label UserHome;
        private System.Windows.Forms.Button DiccionarioHome;
        private System.Windows.Forms.Button sliderHomeDer;
        private System.Windows.Forms.Button sliderHomeIz;
        private System.Windows.Forms.Panel sliderHome;
        private tuto tuto1;
        private System.Windows.Forms.Timer timer1;
    }
}

