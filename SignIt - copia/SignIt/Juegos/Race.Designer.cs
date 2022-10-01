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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Race));
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.RacePoints = new System.Windows.Forms.Label();
            this.TimerRace = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.RaceButtonStart = new System.Windows.Forms.Button();
            this.TimerRace2 = new System.Windows.Forms.Timer(this.components);
            this.ExitRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
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
            // TimerRace
            // 
            this.TimerRace.Enabled = true;
            this.TimerRace.Interval = 1000;
            this.TimerRace.Tick += new System.EventHandler(this.TimerRace_Tick);
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
            // RaceButtonStart
            // 
            this.RaceButtonStart.Location = new System.Drawing.Point(273, 341);
            this.RaceButtonStart.Name = "RaceButtonStart";
            this.RaceButtonStart.Size = new System.Drawing.Size(75, 23);
            this.RaceButtonStart.TabIndex = 3;
            this.RaceButtonStart.Text = "Start";
            this.RaceButtonStart.UseVisualStyleBackColor = true;
            this.RaceButtonStart.Click += new System.EventHandler(this.RaceButtonStart_Click);
            // 
            // TimerRace2
            // 
            this.TimerRace2.Enabled = true;
            this.TimerRace2.Interval = 1000;
            this.TimerRace2.Tick += new System.EventHandler(this.TimerRace2_Tick);
            // 
            // ExitRace
            // 
            this.ExitRace.Location = new System.Drawing.Point(20, 15);
            this.ExitRace.Name = "ExitRace";
            this.ExitRace.Size = new System.Drawing.Size(75, 23);
            this.ExitRace.TabIndex = 4;
            this.ExitRace.UseVisualStyleBackColor = true;
            this.ExitRace.Click += new System.EventHandler(this.ExitRace_Click);
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitRace);
            this.Controls.Add(this.RaceButtonStart);
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
        private System.Windows.Forms.Timer TimerRace;
        private System.Windows.Forms.Button RaceButtonStart;
        private System.Windows.Forms.Timer TimerRace2;
        private System.Windows.Forms.Button ExitRace;
    }
}
