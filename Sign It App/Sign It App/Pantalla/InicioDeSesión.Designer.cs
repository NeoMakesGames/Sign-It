namespace Sign_It_App.Pantalla
{
    partial class InicioDeSesión
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
            this.label1 = new System.Windows.Forms.Label();
            this.label1IdS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ananda", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(564, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignIt";
            // 
            // label1IdS
            // 
            this.label1IdS.AutoSize = true;
            this.label1IdS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1IdS.Location = new System.Drawing.Point(338, 369);
            this.label1IdS.Name = "label1IdS";
            this.label1IdS.Size = new System.Drawing.Size(154, 28);
            this.label1IdS.TabIndex = 4;
            this.label1IdS.Text = "Ingresar Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1160, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InicioDeSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1IdS);
            this.Controls.Add(this.label1);
            this.Name = "InicioDeSesión";
            this.Size = new System.Drawing.Size(1300, 750);
            this.Load += new System.EventHandler(this.InicioDeSesión_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label1IdS;
        private Button button1;
    }
}
