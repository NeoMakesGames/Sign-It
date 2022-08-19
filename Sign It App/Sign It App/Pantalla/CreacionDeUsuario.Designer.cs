namespace Sign_It_App
{
    partial class CreacionDeUsuario
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
            this.label1CdU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "SignIt";
            // 
            // label1CdU
            // 
            this.label1CdU.AutoSize = true;
            this.label1CdU.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1CdU.Location = new System.Drawing.Point(164, 374);
            this.label1CdU.Name = "label1CdU";
            this.label1CdU.Size = new System.Drawing.Size(382, 28);
            this.label1CdU.TabIndex = 2;
            this.label1CdU.Text = "Ingresa tu nombre de usuario para crearlo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 3;
            // 
            // CreacionDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1CdU);
            this.Controls.Add(this.label1);
            this.Name = "CreacionDeUsuario";
            this.Size = new System.Drawing.Size(1370, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label1CdU;
        private Label label2;
    }
}
