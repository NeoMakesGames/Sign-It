
namespace S.It_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new S.It_.UserControl1();
            this.creaciónDeUsuario1 = new S.It_.CreaciónDeUsuario();
            this.home1 = new S.It_.Home();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(282, 191);
            this.userControl11.TabIndex = 0;
            // 
            // creaciónDeUsuario1
            // 
            this.creaciónDeUsuario1.Location = new System.Drawing.Point(370, 12);
            this.creaciónDeUsuario1.Name = "creaciónDeUsuario1";
            this.creaciónDeUsuario1.Size = new System.Drawing.Size(358, 177);
            this.creaciónDeUsuario1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.Highlight;
            this.home1.Location = new System.Drawing.Point(12, 235);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(261, 203);
            this.home1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.creaciónDeUsuario1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private CreaciónDeUsuario creaciónDeUsuario1;
        private Home home1;
    }
}