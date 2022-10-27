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
            this.endTutorial = new System.Windows.Forms.Button();
            this.tutoReg = new System.Windows.Forms.Button();
            this.tutocont = new System.Windows.Forms.Button();
            this.skipTutorial = new System.Windows.Forms.Button();
            this.tutoTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(115, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 556);
            this.panel1.TabIndex = 1;
            // 
            // endTutorial
            // 
            this.endTutorial.BackColor = System.Drawing.Color.Transparent;
            this.endTutorial.BackgroundImage = global::SignIt.Properties.Resources.Botón__1_;
            this.endTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endTutorial.FlatAppearance.BorderSize = 0;
            this.endTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endTutorial.Location = new System.Drawing.Point(565, 656);
            this.endTutorial.Name = "endTutorial";
            this.endTutorial.Size = new System.Drawing.Size(233, 68);
            this.endTutorial.TabIndex = 10;
            this.endTutorial.UseVisualStyleBackColor = false;
            // 
            // tutoReg
            // 
            this.tutoReg.BackColor = System.Drawing.Color.Transparent;
            this.tutoReg.BackgroundImage = global::SignIt.Properties.Resources.Group_561;
            this.tutoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutoReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutoReg.FlatAppearance.BorderSize = 0;
            this.tutoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutoReg.Location = new System.Drawing.Point(443, 655);
            this.tutoReg.Name = "tutoReg";
            this.tutoReg.Size = new System.Drawing.Size(75, 71);
            this.tutoReg.TabIndex = 9;
            this.tutoReg.UseVisualStyleBackColor = false;
            // 
            // tutocont
            // 
            this.tutocont.BackColor = System.Drawing.Color.Transparent;
            this.tutocont.BackgroundImage = global::SignIt.Properties.Resources.Group_57;
            this.tutocont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutocont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutocont.FlatAppearance.BorderSize = 0;
            this.tutocont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutocont.Location = new System.Drawing.Point(836, 655);
            this.tutocont.Name = "tutocont";
            this.tutocont.Size = new System.Drawing.Size(75, 71);
            this.tutocont.TabIndex = 8;
            this.tutocont.UseVisualStyleBackColor = false;
            // 
            // skipTutorial
            // 
            this.skipTutorial.BackColor = System.Drawing.Color.Transparent;
            this.skipTutorial.BackgroundImage = global::SignIt.Properties.Resources.Flecha2;
            this.skipTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skipTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipTutorial.FlatAppearance.BorderSize = 0;
            this.skipTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipTutorial.Font = new System.Drawing.Font("Noto Sans", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipTutorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skipTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skipTutorial.Location = new System.Drawing.Point(1129, 662);
            this.skipTutorial.Name = "skipTutorial";
            this.skipTutorial.Size = new System.Drawing.Size(118, 56);
            this.skipTutorial.TabIndex = 7;
            this.skipTutorial.Text = "      SALTAR";
            this.skipTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skipTutorial.UseVisualStyleBackColor = false;
            this.skipTutorial.Click += new System.EventHandler(this.skipTutorial_Click_1);
            // 
            // tutoTimer
            // 
            this.tutoTimer.Enabled = true;
            this.tutoTimer.Interval = 500;
            this.tutoTimer.Tick += new System.EventHandler(this.tutoTimer_Tick);
            // 
            // tutorial
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
            this.Name = "tutorial";
            this.Size = new System.Drawing.Size(1366, 788);
            this.Load += new System.EventHandler(this.tutorial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button endTutorial;
        private System.Windows.Forms.Button tutoReg;
        private System.Windows.Forms.Button tutocont;
        private System.Windows.Forms.Button skipTutorial;
        private System.Windows.Forms.Timer tutoTimer;
    }
}
