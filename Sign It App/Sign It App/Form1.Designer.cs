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
            this.inicioDeSesión1 = new Sign_It_App.Pantalla.InicioDeSesión();
            this.UserInicioDeSesion = new System.Windows.Forms.TextBox();
            this.ComenzarIds = new System.Windows.Forms.Button();
            this.label2Ids = new System.Windows.Forms.Label();
            this.linkLabel1IdS = new System.Windows.Forms.LinkLabel();
            this.UserCdU = new System.Windows.Forms.TextBox();
            this.creacionDeUsuario1 = new Sign_It_App.CreacionDeUsuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuLectionsButton = new System.Windows.Forms.Button();
            this.home1 = new Sign_It_App.Home();
            this.Menubutton = new System.Windows.Forms.Button();
            this.ComenzarCdU = new System.Windows.Forms.Button();
            this.label1CdU = new System.Windows.Forms.Label();
            this.MenuExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inicioDeSesión1
            // 
            this.inicioDeSesión1.Location = new System.Drawing.Point(0, 0);
            this.inicioDeSesión1.Name = "inicioDeSesión1";
            this.inicioDeSesión1.Size = new System.Drawing.Size(1350, 750);
            this.inicioDeSesión1.TabIndex = 0;
            // 
            // UserInicioDeSesion
            // 
            this.UserInicioDeSesion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserInicioDeSesion.Location = new System.Drawing.Point(550, 371);
            this.UserInicioDeSesion.Name = "UserInicioDeSesion";
            this.UserInicioDeSesion.Size = new System.Drawing.Size(291, 43);
            this.UserInicioDeSesion.TabIndex = 1;
            // 
            // ComenzarIds
            // 
            this.ComenzarIds.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComenzarIds.Location = new System.Drawing.Point(587, 529);
            this.ComenzarIds.Name = "ComenzarIds";
            this.ComenzarIds.Size = new System.Drawing.Size(219, 71);
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
            this.label2Ids.Location = new System.Drawing.Point(582, 425);
            this.label2Ids.Name = "label2Ids";
            this.label2Ids.Size = new System.Drawing.Size(228, 37);
            this.label2Ids.TabIndex = 4;
            this.label2Ids.Text = "Usuario no Valido";
            // 
            // linkLabel1IdS
            // 
            this.linkLabel1IdS.AutoSize = true;
            this.linkLabel1IdS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1IdS.Location = new System.Drawing.Point(539, 610);
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
            this.UserCdU.Location = new System.Drawing.Point(550, 371);
            this.UserCdU.Name = "UserCdU";
            this.UserCdU.Size = new System.Drawing.Size(291, 43);
            this.UserCdU.TabIndex = 7;
            this.UserCdU.TextChanged += new System.EventHandler(this.UserCdU_TextChanged);
            // 
            // creacionDeUsuario1
            // 
            this.creacionDeUsuario1.Location = new System.Drawing.Point(0, 0);
            this.creacionDeUsuario1.Name = "creacionDeUsuario1";
            this.creacionDeUsuario1.Size = new System.Drawing.Size(1370, 750);
            this.creacionDeUsuario1.TabIndex = 8;
            this.creacionDeUsuario1.Load += new System.EventHandler(this.creacionDeUsuario1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.MenuExitButton);
            this.panel1.Controls.Add(this.MenuLectionsButton);
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
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.home1.Location = new System.Drawing.Point(-2, -1);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1352, 750);
            this.home1.TabIndex = 13;
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
            this.ComenzarCdU.Location = new System.Drawing.Point(591, 536);
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
            this.label1CdU.Location = new System.Drawing.Point(556, 475);
            this.label1CdU.Name = "label1CdU";
            this.label1CdU.Size = new System.Drawing.Size(288, 28);
            this.label1CdU.TabIndex = 12;
            this.label1CdU.Text = "Nombre de usuario ya existente";
            this.label1CdU.Click += new System.EventHandler(this.label1CdU_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.linkLabel1IdS);
            this.Controls.Add(this.label2Ids);
            this.Controls.Add(this.ComenzarIds);
            this.Controls.Add(this.Menubutton);
            this.Controls.Add(this.UserCdU);
            this.Controls.Add(this.inicioDeSesión1);
            this.Controls.Add(this.ComenzarCdU);
            this.Controls.Add(this.label1CdU);
            this.Controls.Add(this.creacionDeUsuario1);
            this.Controls.Add(this.UserInicioDeSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pantalla.InicioDeSesión inicioDeSesión1;
        private TextBox UserInicioDeSesion;
        private Button ComenzarIds;
        private Label label2Ids;
        private LinkLabel linkLabel1IdS;
        private TextBox UserCdU;
        private CreacionDeUsuario creacionDeUsuario1;
        private Panel panel1;
        private Button Menubutton;
        private Button ComenzarCdU;
        private Label label1CdU;
        private Home home1;
        private Button MenuLectionsButton;
        private Button MenuExitButton;
    }
}