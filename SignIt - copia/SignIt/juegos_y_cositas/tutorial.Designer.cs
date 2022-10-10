namespace SignIt
{
    partial class tutorial
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tutocont = new System.Windows.Forms.Button();
            this.tutoreg = new System.Windows.Forms.Button();
            this.tutotimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(106, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 576);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1159, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tutocont
            // 
            this.tutocont.Location = new System.Drawing.Point(789, 678);
            this.tutocont.Name = "tutocont";
            this.tutocont.Size = new System.Drawing.Size(110, 49);
            this.tutocont.TabIndex = 2;
            this.tutocont.Text = "button2";
            this.tutocont.UseVisualStyleBackColor = true;
            this.tutocont.Click += new System.EventHandler(this.tutocont_Click);
            // 
            // tutoreg
            // 
            this.tutoreg.Location = new System.Drawing.Point(534, 678);
            this.tutoreg.Name = "tutoreg";
            this.tutoreg.Size = new System.Drawing.Size(110, 49);
            this.tutoreg.TabIndex = 3;
            this.tutoreg.Text = "button3";
            this.tutoreg.UseVisualStyleBackColor = true;
            this.tutoreg.Click += new System.EventHandler(this.tutoreg_Click);
            // 
            // tutotimer
            // 
            this.tutotimer.Interval = 250;
            this.tutotimer.Tick += new System.EventHandler(this.tutotimer_Tick);
            // 
            // tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tutoreg);
            this.Controls.Add(this.tutocont);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "tutorial";
            this.Size = new System.Drawing.Size(1366, 788);
            this.Load += new System.EventHandler(this.tutorial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tutocont;
        private System.Windows.Forms.Button tutoreg;
        private System.Windows.Forms.Timer tutotimer;
    }
}
