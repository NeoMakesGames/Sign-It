namespace SignIt
{
    partial class Race
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Race));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.RacePoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(121, 61);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(402, 207);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(121, 288);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.Size = new System.Drawing.Size(399, 20);
            this.RaceTextBox.TabIndex = 1;
            // 
            // RacePoints
            // 
            this.RacePoints.AutoSize = true;
            this.RacePoints.Location = new System.Drawing.Point(605, 25);
            this.RacePoints.Name = "RacePoints";
            this.RacePoints.Size = new System.Drawing.Size(13, 13);
            this.RacePoints.TabIndex = 2;
            this.RacePoints.Text = "0";
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RacePoints);
            this.Controls.Add(this.RaceTextBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Race";
            this.Size = new System.Drawing.Size(709, 417);
            this.Load += new System.EventHandler(this.Race_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.Label RacePoints;
    }
}
