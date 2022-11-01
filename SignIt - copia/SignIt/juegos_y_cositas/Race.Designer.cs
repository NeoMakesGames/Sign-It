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
            this.Contador = new System.Windows.Forms.Label();
            this.imagenTimer = new System.Windows.Forms.Button();
            this.ExitRace = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endRacePanel = new System.Windows.Forms.Panel();
            this.endRacePoints = new System.Windows.Forms.Label();
            this.finalRaceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.endRacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.RaceTextBox.Location = new System.Drawing.Point(382, 459);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.Size = new System.Drawing.Size(630, 53);
            this.RaceTextBox.TabIndex = 1;
            this.RaceTextBox.TextChanged += new System.EventHandler(this.RaceTextBox_TextChanged);
            // 
            // RacePoints
            // 
            this.RacePoints.AutoSize = true;
            this.RacePoints.BackColor = System.Drawing.Color.Transparent;
            this.RacePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RacePoints.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RacePoints.Location = new System.Drawing.Point(1102, 34);
            this.RacePoints.Name = "RacePoints";
            this.RacePoints.Size = new System.Drawing.Size(29, 31);
            this.RacePoints.TabIndex = 2;
            this.RacePoints.Text = "0";
            this.RacePoints.Click += new System.EventHandler(this.RacePoints_Click);
            // 
            // TimerRace
            // 
            this.TimerRace.Enabled = true;
            this.TimerRace.Tick += new System.EventHandler(this.TimerRace_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(382, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(630, 391);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // RaceButtonStart
            // 
            this.RaceButtonStart.BackColor = System.Drawing.Color.Transparent;
            this.RaceButtonStart.BackgroundImage = global::SignIt.Properties.Resources.Group_56;
            this.RaceButtonStart.FlatAppearance.BorderSize = 0;
            this.RaceButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaceButtonStart.Location = new System.Drawing.Point(547, 527);
            this.RaceButtonStart.Name = "RaceButtonStart";
            this.RaceButtonStart.Size = new System.Drawing.Size(300, 70);
            this.RaceButtonStart.TabIndex = 3;
            this.RaceButtonStart.UseVisualStyleBackColor = false;
            this.RaceButtonStart.Click += new System.EventHandler(this.RaceButtonStart_Click);
            // 
            // TimerRace2
            // 
            this.TimerRace2.Enabled = true;
            this.TimerRace2.Interval = 1000;
            this.TimerRace2.Tick += new System.EventHandler(this.TimerRace2_Tick);
            // 
            // Contador
            // 
            this.Contador.AutoSize = true;
            this.Contador.BackColor = System.Drawing.Color.Transparent;
            this.Contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Contador.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Contador.Location = new System.Drawing.Point(1174, 673);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(82, 31);
            this.Contador.TabIndex = 6;
            this.Contador.Text = "00:00";
            // 
            // imagenTimer
            // 
            this.imagenTimer.BackColor = System.Drawing.Color.Transparent;
            this.imagenTimer.BackgroundImage = global::SignIt.Properties.Resources.stopwatch_4;
            this.imagenTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenTimer.FlatAppearance.BorderSize = 0;
            this.imagenTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagenTimer.Location = new System.Drawing.Point(1108, 659);
            this.imagenTimer.Name = "imagenTimer";
            this.imagenTimer.Size = new System.Drawing.Size(60, 60);
            this.imagenTimer.TabIndex = 7;
            this.imagenTimer.UseVisualStyleBackColor = false;
            // 
            // ExitRace
            // 
            this.ExitRace.BackColor = System.Drawing.Color.Transparent;
            this.ExitRace.BackgroundImage = global::SignIt.Properties.Resources.Flecha;
            this.ExitRace.FlatAppearance.BorderSize = 0;
            this.ExitRace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitRace.Location = new System.Drawing.Point(53, 34);
            this.ExitRace.Name = "ExitRace";
            this.ExitRace.Size = new System.Drawing.Size(125, 92);
            this.ExitRace.TabIndex = 4;
            this.ExitRace.UseVisualStyleBackColor = false;
            this.ExitRace.Click += new System.EventHandler(this.ExitRace_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(382, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 71);
            this.panel1.TabIndex = 0;
            // 
            // endRacePanel
            // 
            this.endRacePanel.BackColor = System.Drawing.Color.Transparent;
            this.endRacePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endRacePanel.Controls.Add(this.endRacePoints);
            this.endRacePanel.Controls.Add(this.finalRaceText);
            this.endRacePanel.Location = new System.Drawing.Point(326, 21);
            this.endRacePanel.Name = "endRacePanel";
            this.endRacePanel.Size = new System.Drawing.Size(743, 500);
            this.endRacePanel.TabIndex = 8;
            this.endRacePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.endRacePanel_Paint);
            // 
            // endRacePoints
            // 
            this.endRacePoints.AutoSize = true;
            this.endRacePoints.BackColor = System.Drawing.Color.Transparent;
            this.endRacePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.endRacePoints.ForeColor = System.Drawing.Color.RoyalBlue;
            this.endRacePoints.Location = new System.Drawing.Point(286, 294);
            this.endRacePoints.Name = "endRacePoints";
            this.endRacePoints.Size = new System.Drawing.Size(97, 31);
            this.endRacePoints.TabIndex = 1;
            this.endRacePoints.Text = "Hiciste";
            // 
            // finalRaceText
            // 
            this.finalRaceText.AutoSize = true;
            this.finalRaceText.BackColor = System.Drawing.Color.Transparent;
            this.finalRaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.finalRaceText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.finalRaceText.Location = new System.Drawing.Point(251, 222);
            this.finalRaceText.Name = "finalRaceText";
            this.finalRaceText.Size = new System.Drawing.Size(232, 44);
            this.finalRaceText.TabIndex = 0;
            this.finalRaceText.Text = "Buen intento";
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.endRacePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagenTimer);
            this.Controls.Add(this.Contador);
            this.Controls.Add(this.ExitRace);
            this.Controls.Add(this.RaceButtonStart);
            this.Controls.Add(this.RacePoints);
            this.Controls.Add(this.RaceTextBox);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.DoubleBuffered = true;
            this.Name = "Race";
            this.Size = new System.Drawing.Size(1366, 788);
            this.Load += new System.EventHandler(this.Race_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.endRacePanel.ResumeLayout(false);
            this.endRacePanel.PerformLayout();
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
        private System.Windows.Forms.Label Contador;
        private System.Windows.Forms.Button imagenTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel endRacePanel;
        private System.Windows.Forms.Label endRacePoints;
        private System.Windows.Forms.Label finalRaceText;
    }
}
