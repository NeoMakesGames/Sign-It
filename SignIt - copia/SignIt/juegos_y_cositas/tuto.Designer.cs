namespace SignIt
{
    partial class tuto
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
            this.tutoTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.skipTutorial = new System.Windows.Forms.Button();
            this.tutocont = new System.Windows.Forms.Button();
            this.tutoReg = new System.Windows.Forms.Button();
            this.endTutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tutoTimer
            // 
            this.tutoTimer.Enabled = true;
            this.tutoTimer.Interval = 250;
            this.tutoTimer.Tick += new System.EventHandler(this.tutoTimer_Tick_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(94, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 556);
            this.panel1.TabIndex = 0;
            // 
            // skipTutorial
            // 
            this.skipTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skipTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipTutorial.Location = new System.Drawing.Point(1120, 635);
            this.skipTutorial.Name = "skipTutorial";
            this.skipTutorial.Size = new System.Drawing.Size(95, 80);
            this.skipTutorial.TabIndex = 1;
            this.skipTutorial.Text = "button1";
            this.skipTutorial.UseVisualStyleBackColor = true;
            this.skipTutorial.Click += new System.EventHandler(this.skipTutorial_Click);
            // 
            // tutocont
            // 
            this.tutocont.BackColor = System.Drawing.Color.Transparent;
            this.tutocont.BackgroundImage = global::SignIt.Properties.Resources.Group_57;
            this.tutocont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutocont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutocont.FlatAppearance.BorderSize = 0;
            this.tutocont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutocont.Location = new System.Drawing.Point(816, 640);
            this.tutocont.Name = "tutocont";
            this.tutocont.Size = new System.Drawing.Size(75, 71);
            this.tutocont.TabIndex = 2;
            this.tutocont.UseVisualStyleBackColor = false;
            this.tutocont.Click += new System.EventHandler(this.tutocont_Click_1);
            // 
            // tutoReg
            // 
            this.tutoReg.BackColor = System.Drawing.Color.Transparent;
            this.tutoReg.BackgroundImage = global::SignIt.Properties.Resources.Group_561;
            this.tutoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutoReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutoReg.FlatAppearance.BorderSize = 0;
            this.tutoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutoReg.Location = new System.Drawing.Point(459, 640);
            this.tutoReg.Name = "tutoReg";
            this.tutoReg.Size = new System.Drawing.Size(75, 71);
            this.tutoReg.TabIndex = 3;
            this.tutoReg.UseVisualStyleBackColor = false;
            this.tutoReg.Click += new System.EventHandler(this.tutoReg_Click_1);
            // 
            // endTutorial
            // 
            this.endTutorial.BackColor = System.Drawing.Color.Transparent;
            this.endTutorial.BackgroundImage = global::SignIt.Properties.Resources.Botón__1_;
            this.endTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endTutorial.FlatAppearance.BorderSize = 0;
            this.endTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endTutorial.Location = new System.Drawing.Point(558, 647);
            this.endTutorial.Name = "endTutorial";
            this.endTutorial.Size = new System.Drawing.Size(233, 57);
            this.endTutorial.TabIndex = 5;
            this.endTutorial.UseVisualStyleBackColor = false;
            this.endTutorial.Click += new System.EventHandler(this.endTutorial_Click);
            // 
            // tuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.endTutorial);
            this.Controls.Add(this.tutoReg);
            this.Controls.Add(this.tutocont);
            this.Controls.Add(this.skipTutorial);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "tuto";
            this.Size = new System.Drawing.Size(1366, 788);
            this.Load += new System.EventHandler(this.tuto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tutoTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button skipTutorial;
        private System.Windows.Forms.Button tutocont;
        private System.Windows.Forms.Button tutoReg;
        private System.Windows.Forms.Button endTutorial;
    }
}
