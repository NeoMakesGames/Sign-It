namespace Sign_It_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInicioDeSesion = new System.Windows.Forms.TextBox();
            this.ComenzarIds = new System.Windows.Forms.Button();
            this.label2Ids = new System.Windows.Forms.Label();
            this.linkLabel1IdS = new System.Windows.Forms.LinkLabel();
            this.UserCdU = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuSettingsButton = new System.Windows.Forms.Button();
            this.MenuGamesButton = new System.Windows.Forms.Button();
            this.MenuHomeButton = new System.Windows.Forms.Button();
            this.MenuDiccionarioButton = new System.Windows.Forms.Button();
            this.MenuLectionsButton = new System.Windows.Forms.Button();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.Menubutton = new System.Windows.Forms.Button();
            this.ComenzarCdU = new System.Windows.Forms.Button();
            this.label1CdU = new System.Windows.Forms.Label();
            this.SnapBackToReality = new System.Windows.Forms.Button();
            this.signIt = new System.Windows.Forms.TabControl();
            this.IdS = new System.Windows.Forms.TabPage();
            this.SalirIdS = new System.Windows.Forms.Button();
            this.CdU = new System.Windows.Forms.TabPage();
            this.Home = new System.Windows.Forms.TabPage();
            this.DiccionarioHome = new System.Windows.Forms.Button();
            this.LeccionesHome = new System.Windows.Forms.Button();
            this.Lecciones = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Diccionario = new System.Windows.Forms.TabPage();
            this.Juegos = new System.Windows.Forms.TabPage();
            this.Ajustes = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.signIt.SuspendLayout();
            this.IdS.SuspendLayout();
            this.CdU.SuspendLayout();
            this.Home.SuspendLayout();
            this.Lecciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInicioDeSesion
            // 
            this.UserInicioDeSesion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserInicioDeSesion.Location = new System.Drawing.Point(562, 256);
            this.UserInicioDeSesion.Name = "UserInicioDeSesion";
            this.UserInicioDeSesion.Size = new System.Drawing.Size(293, 43);
            this.UserInicioDeSesion.TabIndex = 1;
            // 
            // ComenzarIds
            // 
            this.ComenzarIds.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComenzarIds.Location = new System.Drawing.Point(594, 373);
            this.ComenzarIds.Name = "ComenzarIds";
            this.ComenzarIds.Size = new System.Drawing.Size(221, 71);
            this.ComenzarIds.TabIndex = 2;
            this.ComenzarIds.Text = "Comenzar";
            this.ComenzarIds.UseVisualStyleBackColor = true;
            this.ComenzarIds.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2Ids
            // 
            this.label2Ids.AutoSize = true;
            this.label2Ids.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2Ids.ForeColor = System.Drawing.Color.Red;
            this.label2Ids.Location = new System.Drawing.Point(594, 315);
            this.label2Ids.Name = "label2Ids";
            this.label2Ids.Size = new System.Drawing.Size(228, 37);
            this.label2Ids.TabIndex = 4;
            this.label2Ids.Text = "Usuario no Valido";
            // 
            // linkLabel1IdS
            // 
            this.linkLabel1IdS.AutoSize = true;
            this.linkLabel1IdS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1IdS.Location = new System.Drawing.Point(556, 474);
            this.linkLabel1IdS.Name = "linkLabel1IdS";
            this.linkLabel1IdS.Size = new System.Drawing.Size(313, 28);
            this.linkLabel1IdS.TabIndex = 5;
            this.linkLabel1IdS.TabStop = true;
            this.linkLabel1IdS.Text = "Para crear un usuario has click aquí";
            this.linkLabel1IdS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1IdS_LinkClicked);
            // 
            // UserCdU
            // 
            this.UserCdU.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserCdU.Location = new System.Drawing.Point(363, 219);
            this.UserCdU.Name = "UserCdU";
            this.UserCdU.Size = new System.Drawing.Size(291, 43);
            this.UserCdU.TabIndex = 7;
            this.UserCdU.TextChanged += new System.EventHandler(this.UserCdU_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.MenuSettingsButton);
            this.panel1.Controls.Add(this.MenuGamesButton);
            this.panel1.Controls.Add(this.MenuHomeButton);
            this.panel1.Controls.Add(this.MenuDiccionarioButton);
            this.panel1.Controls.Add(this.MenuLectionsButton);
            this.panel1.Controls.Add(this.MenuExitButton);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 775);
            this.panel1.TabIndex = 9;
            // 
            // MenuSettingsButton
            // 
            this.MenuSettingsButton.Location = new System.Drawing.Point(4, 529);
            this.MenuSettingsButton.Name = "MenuSettingsButton";
            this.MenuSettingsButton.Size = new System.Drawing.Size(192, 79);
            this.MenuSettingsButton.TabIndex = 5;
            this.MenuSettingsButton.Text = "Ajustes";
            this.MenuSettingsButton.UseVisualStyleBackColor = true;
            this.MenuSettingsButton.Click += new System.EventHandler(this.MenuSettingsButton_Click);
            // 
            // MenuGamesButton
            // 
            this.MenuGamesButton.Location = new System.Drawing.Point(5, 412);
            this.MenuGamesButton.Name = "MenuGamesButton";
            this.MenuGamesButton.Size = new System.Drawing.Size(192, 79);
            this.MenuGamesButton.TabIndex = 4;
            this.MenuGamesButton.Text = "Juegos";
            this.MenuGamesButton.UseVisualStyleBackColor = true;
            this.MenuGamesButton.Click += new System.EventHandler(this.MenuGamesButton_Click);
            // 
            // MenuHomeButton
            // 
            this.MenuHomeButton.Location = new System.Drawing.Point(4, 74);
            this.MenuHomeButton.Name = "MenuHomeButton";
            this.MenuHomeButton.Size = new System.Drawing.Size(192, 79);
            this.MenuHomeButton.TabIndex = 3;
            this.MenuHomeButton.Text = "Home";
            this.MenuHomeButton.UseVisualStyleBackColor = true;
            this.MenuHomeButton.Click += new System.EventHandler(this.MenuHomeButton_Click);
            // 
            // MenuDiccionarioButton
            // 
            this.MenuDiccionarioButton.Location = new System.Drawing.Point(5, 299);
            this.MenuDiccionarioButton.Name = "MenuDiccionarioButton";
            this.MenuDiccionarioButton.Size = new System.Drawing.Size(192, 79);
            this.MenuDiccionarioButton.TabIndex = 2;
            this.MenuDiccionarioButton.Text = "Diccionario";
            this.MenuDiccionarioButton.UseVisualStyleBackColor = true;
            this.MenuDiccionarioButton.Click += new System.EventHandler(this.MenuDiccionarioButton_Click);
            // 
            // MenuLectionsButton
            // 
            this.MenuLectionsButton.Location = new System.Drawing.Point(4, 186);
            this.MenuLectionsButton.Name = "MenuLectionsButton";
            this.MenuLectionsButton.Size = new System.Drawing.Size(192, 79);
            this.MenuLectionsButton.TabIndex = 0;
            this.MenuLectionsButton.Text = "Lecciones";
            this.MenuLectionsButton.UseVisualStyleBackColor = true;
            this.MenuLectionsButton.Click += new System.EventHandler(this.MenuLectionsButton_Click);
            // 
            // MenuExitButton
            // 
            this.MenuExitButton.Location = new System.Drawing.Point(4, 650);
            this.MenuExitButton.Name = "MenuExitButton";
            this.MenuExitButton.Size = new System.Drawing.Size(192, 79);
            this.MenuExitButton.TabIndex = 1;
            this.MenuExitButton.Text = "Salir";
            this.MenuExitButton.UseVisualStyleBackColor = true;
            this.MenuExitButton.Click += new System.EventHandler(this.MenuExitButton_Click);
            // 
            // Menubutton
            // 
            this.Menubutton.Location = new System.Drawing.Point(0, -1);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(80, 54);
            this.Menubutton.TabIndex = 10;
            this.Menubutton.Text = "...";
            this.Menubutton.UseVisualStyleBackColor = true;
            this.Menubutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ComenzarCdU
            // 
            this.ComenzarCdU.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComenzarCdU.Location = new System.Drawing.Point(407, 347);
            this.ComenzarCdU.Name = "ComenzarCdU";
            this.ComenzarCdU.Size = new System.Drawing.Size(219, 71);
            this.ComenzarCdU.TabIndex = 11;
            this.ComenzarCdU.Text = "Crear";
            this.ComenzarCdU.UseVisualStyleBackColor = true;
            this.ComenzarCdU.Click += new System.EventHandler(this.ComenzarCdU_Click);
            // 
            // label1CdU
            // 
            this.label1CdU.AutoSize = true;
            this.label1CdU.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1CdU.ForeColor = System.Drawing.Color.Red;
            this.label1CdU.Location = new System.Drawing.Point(363, 287);
            this.label1CdU.Name = "label1CdU";
            this.label1CdU.Size = new System.Drawing.Size(288, 28);
            this.label1CdU.TabIndex = 12;
            this.label1CdU.Text = "Nombre de usuario ya existente";
            this.label1CdU.Click += new System.EventHandler(this.label1CdU_Click);
            // 
            // SnapBackToReality
            // 
            this.SnapBackToReality.Location = new System.Drawing.Point(4, 3);
            this.SnapBackToReality.Name = "SnapBackToReality";
            this.SnapBackToReality.Size = new System.Drawing.Size(75, 44);
            this.SnapBackToReality.TabIndex = 14;
            this.SnapBackToReality.Text = "<---";
            this.SnapBackToReality.UseVisualStyleBackColor = true;
            this.SnapBackToReality.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // signIt
            // 
            this.signIt.Controls.Add(this.IdS);
            this.signIt.Controls.Add(this.CdU);
            this.signIt.Controls.Add(this.Home);
            this.signIt.Controls.Add(this.Lecciones);
            this.signIt.Controls.Add(this.Diccionario);
            this.signIt.Controls.Add(this.Juegos);
            this.signIt.Controls.Add(this.Ajustes);
            this.signIt.Location = new System.Drawing.Point(-4, -8);
            this.signIt.Name = "signIt";
            this.signIt.SelectedIndex = 0;
            this.signIt.Size = new System.Drawing.Size(1362, 785);
            this.signIt.TabIndex = 15;
            // 
            // IdS
            // 
            this.IdS.Controls.Add(this.SalirIdS);
            this.IdS.Controls.Add(this.UserInicioDeSesion);
            this.IdS.Controls.Add(this.linkLabel1IdS);
            this.IdS.Controls.Add(this.label2Ids);
            this.IdS.Controls.Add(this.ComenzarIds);
            this.IdS.Location = new System.Drawing.Point(4, 24);
            this.IdS.Name = "IdS";
            this.IdS.Padding = new System.Windows.Forms.Padding(3);
            this.IdS.Size = new System.Drawing.Size(1354, 757);
            this.IdS.TabIndex = 0;
            this.IdS.Text = "InicioDeSesion";
            this.IdS.UseVisualStyleBackColor = true;
            this.IdS.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SalirIdS
            // 
            this.SalirIdS.Location = new System.Drawing.Point(1237, 699);
            this.SalirIdS.Name = "SalirIdS";
            this.SalirIdS.Size = new System.Drawing.Size(91, 32);
            this.SalirIdS.TabIndex = 6;
            this.SalirIdS.Text = "Salir";
            this.SalirIdS.UseVisualStyleBackColor = true;
            this.SalirIdS.Click += new System.EventHandler(this.SalirIdS_Click);
            // 
            // CdU
            // 
            this.CdU.Controls.Add(this.SnapBackToReality);
            this.CdU.Controls.Add(this.UserCdU);
            this.CdU.Controls.Add(this.label1CdU);
            this.CdU.Controls.Add(this.ComenzarCdU);
            this.CdU.Location = new System.Drawing.Point(4, 24);
            this.CdU.Name = "CdU";
            this.CdU.Padding = new System.Windows.Forms.Padding(3);
            this.CdU.Size = new System.Drawing.Size(1354, 757);
            this.CdU.TabIndex = 1;
            this.CdU.Text = "CreacionDeUsuario";
            this.CdU.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.DiccionarioHome);
            this.Home.Controls.Add(this.LeccionesHome);
            this.Home.Location = new System.Drawing.Point(4, 24);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1354, 757);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // DiccionarioHome
            // 
            this.DiccionarioHome.Location = new System.Drawing.Point(474, 145);
            this.DiccionarioHome.Name = "DiccionarioHome";
            this.DiccionarioHome.Size = new System.Drawing.Size(150, 54);
            this.DiccionarioHome.TabIndex = 1;
            this.DiccionarioHome.Text = "Diccionario";
            this.DiccionarioHome.UseVisualStyleBackColor = true;
            // 
            // LeccionesHome
            // 
            this.LeccionesHome.Location = new System.Drawing.Point(474, 400);
            this.LeccionesHome.Name = "LeccionesHome";
            this.LeccionesHome.Size = new System.Drawing.Size(150, 54);
            this.LeccionesHome.TabIndex = 0;
            this.LeccionesHome.Text = "Continua con tus lecciones";
            this.LeccionesHome.UseVisualStyleBackColor = true;
            // 
            // Lecciones
            // 
            this.Lecciones.Controls.Add(this.button1);
            this.Lecciones.Location = new System.Drawing.Point(4, 24);
            this.Lecciones.Name = "Lecciones";
            this.Lecciones.Size = new System.Drawing.Size(1354, 757);
            this.Lecciones.TabIndex = 3;
            this.Lecciones.Text = "Lecciones";
            this.Lecciones.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Palabras basicas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Diccionario
            // 
            this.Diccionario.Location = new System.Drawing.Point(4, 24);
            this.Diccionario.Name = "Diccionario";
            this.Diccionario.Size = new System.Drawing.Size(1354, 757);
            this.Diccionario.TabIndex = 4;
            this.Diccionario.Text = "Diccionario";
            this.Diccionario.UseVisualStyleBackColor = true;
            // 
            // Juegos
            // 
            this.Juegos.Location = new System.Drawing.Point(4, 24);
            this.Juegos.Name = "Juegos";
            this.Juegos.Size = new System.Drawing.Size(1354, 757);
            this.Juegos.TabIndex = 5;
            this.Juegos.Text = "Juegos";
            this.Juegos.UseVisualStyleBackColor = true;
            // 
            // Ajustes
            // 
            this.Ajustes.Location = new System.Drawing.Point(4, 24);
            this.Ajustes.Name = "Ajustes";
            this.Ajustes.Size = new System.Drawing.Size(1354, 757);
            this.Ajustes.TabIndex = 6;
            this.Ajustes.Text = "Ajustes";
            this.Ajustes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.Menubutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signIt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.signIt.ResumeLayout(false);
            this.IdS.ResumeLayout(false);
            this.IdS.PerformLayout();
            this.CdU.ResumeLayout(false);
            this.CdU.PerformLayout();
            this.Home.ResumeLayout(false);
            this.Lecciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox UserInicioDeSesion;
        private Button ComenzarIds;
        private Label label2Ids;
        private LinkLabel linkLabel1IdS;
        private TextBox UserCdU;
        private Panel panel1;
        private Button Menubutton;
        private Button ComenzarCdU;
        private Label label1CdU;
        private Button MenuLectionsButton;
        private Button MenuExitButton;
        private Button SnapBackToReality;
        private TabControl signIt;
        private TabPage IdS;
        private TabPage CdU;
        private TabPage Home;
        private Button SalirIdS;
        private Button DiccionarioHome;
        private Button LeccionesHome;
        private TabPage Lecciones;
        private Button MenuSettingsButton;
        private Button MenuGamesButton;
        private Button MenuHomeButton;
        private Button MenuDiccionarioButton;
        private Button button1;
        private TabPage Diccionario;
        private TabPage Juegos;
        private TabPage Ajustes;
    }
}