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
            this.MenuLectionsButton = new System.Windows.Forms.Button();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.Menubutton = new System.Windows.Forms.Button();
            this.ComenzarCdU = new System.Windows.Forms.Button();
            this.label1CdU = new System.Windows.Forms.Label();
            this.SnapBackToReality = new System.Windows.Forms.Button();
            this.signIt = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SalirIdS = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DiccionarioHome = new System.Windows.Forms.Button();
            this.LeccionesHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.signIt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.panel1.Controls.Add(this.MenuLectionsButton);
            this.panel1.Controls.Add(this.MenuExitButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 750);
            this.panel1.TabIndex = 9;
            // 
            // MenuLectionsButton
            // 
            this.MenuLectionsButton.Location = new System.Drawing.Point(5, 59);
            this.MenuLectionsButton.Name = "MenuLectionsButton";
            this.MenuLectionsButton.Size = new System.Drawing.Size(192, 65);
            this.MenuLectionsButton.TabIndex = 0;
            this.MenuLectionsButton.Text = "Lecciones";
            this.MenuLectionsButton.UseVisualStyleBackColor = true;
            // 
            // MenuExitButton
            // 
            this.MenuExitButton.Location = new System.Drawing.Point(4, 679);
            this.MenuExitButton.Name = "MenuExitButton";
            this.MenuExitButton.Size = new System.Drawing.Size(192, 65);
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
            this.signIt.Controls.Add(this.tabPage3);
            this.signIt.Controls.Add(this.tabPage1);
            this.signIt.Controls.Add(this.tabPage2);
            this.signIt.Location = new System.Drawing.Point(-4, -8);
            this.signIt.Name = "signIt";
            this.signIt.SelectedIndex = 0;
            this.signIt.Size = new System.Drawing.Size(1362, 785);
            this.signIt.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SalirIdS);
            this.tabPage1.Controls.Add(this.UserInicioDeSesion);
            this.tabPage1.Controls.Add(this.linkLabel1IdS);
            this.tabPage1.Controls.Add(this.label2Ids);
            this.tabPage1.Controls.Add(this.ComenzarIds);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1354, 757);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "InicioDeSesion";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SnapBackToReality);
            this.tabPage2.Controls.Add(this.UserCdU);
            this.tabPage2.Controls.Add(this.label1CdU);
            this.tabPage2.Controls.Add(this.ComenzarCdU);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1354, 757);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CreacionDeUsuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DiccionarioHome);
            this.tabPage3.Controls.Add(this.LeccionesHome);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1354, 757);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Home";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.signIt);
            this.Controls.Add(this.Menubutton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.signIt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button SalirIdS;
        private Button DiccionarioHome;
        private Button LeccionesHome;
    }
}