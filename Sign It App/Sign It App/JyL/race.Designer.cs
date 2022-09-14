namespace Sign_It_App
{
    partial class race
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CounterRace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 23);
            this.textBox1.TabIndex = 1;
            // 
            // CounterRace
            // 
            this.CounterRace.AutoSize = true;
            this.CounterRace.Location = new System.Drawing.Point(653, 366);
            this.CounterRace.Name = "CounterRace";
            this.CounterRace.Size = new System.Drawing.Size(38, 15);
            this.CounterRace.TabIndex = 2;
            this.CounterRace.Text = "label1";
            // 
            // race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CounterRace);
            this.Controls.Add(this.textBox1);
            this.Name = "race";
            this.Size = new System.Drawing.Size(1380, 757);
            this.Load += new System.EventHandler(this.race_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Label CounterRace;
    }
}
