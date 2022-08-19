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
            this.label1IdS = new System.Windows.Forms.Label();
            this.label2Ids = new System.Windows.Forms.Label();
            this.linkLabel1IdS = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // inicioDeSesión1
            // 
            this.inicioDeSesión1.Location = new System.Drawing.Point(2, 1);
            this.inicioDeSesión1.Name = "inicioDeSesión1";
            this.inicioDeSesión1.Size = new System.Drawing.Size(1350, 751);
            this.inicioDeSesión1.TabIndex = 0;
            // 
            // UserInicioDeSesion
            // 
            this.UserInicioDeSesion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserInicioDeSesion.Location = new System.Drawing.Point(550, 354);
            this.UserInicioDeSesion.Name = "UserInicioDeSesion";
            this.UserInicioDeSesion.Size = new System.Drawing.Size(291, 43);
            this.UserInicioDeSesion.TabIndex = 1;
            // 
            // ComenzarIds
            // 
            this.ComenzarIds.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComenzarIds.Location = new System.Drawing.Point(587, 488);
            this.ComenzarIds.Name = "ComenzarIds";
            this.ComenzarIds.Size = new System.Drawing.Size(219, 71);
            this.ComenzarIds.TabIndex = 2;
            this.ComenzarIds.Text = "Comenzar";
            this.ComenzarIds.UseVisualStyleBackColor = true;
            this.ComenzarIds.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1IdS
            // 
            this.label1IdS.AutoSize = true;
            this.label1IdS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1IdS.Location = new System.Drawing.Point(377, 364);
            this.label1IdS.Name = "label1IdS";
            this.label1IdS.Size = new System.Drawing.Size(154, 28);
            this.label1IdS.TabIndex = 3;
            this.label1IdS.Text = "Ingresar Usuario";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.linkLabel1IdS);
            this.Controls.Add(this.label2Ids);
            this.Controls.Add(this.label1IdS);
            this.Controls.Add(this.ComenzarIds);
            this.Controls.Add(this.UserInicioDeSesion);
            this.Controls.Add(this.inicioDeSesión1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pantalla.InicioDeSesión inicioDeSesión1;
        private TextBox UserInicioDeSesion;
        private Button ComenzarIds;
        private Label label1IdS;
        private Label label2Ids;
        private LinkLabel linkLabel1IdS;
    }
}