namespace SignIt
{
    partial class Ej1
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
            this.ej0cont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ej0cont
            // 
            this.ej0cont.BackColor = System.Drawing.Color.Transparent;
            this.ej0cont.BackgroundImage = global::SignIt.Properties.Resources.Botón1;
            this.ej0cont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ej0cont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ej0cont.FlatAppearance.BorderSize = 0;
            this.ej0cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ej0cont.Location = new System.Drawing.Point(1160, 45);
            this.ej0cont.Name = "ej0cont";
            this.ej0cont.Size = new System.Drawing.Size(182, 66);
            this.ej0cont.TabIndex = 7;
            this.ej0cont.UseVisualStyleBackColor = false;
            this.ej0cont.Click += new System.EventHandler(this.ej0cont_Click);
            // 
            // Ej1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SignIt.Properties.Resources.Group_62__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ej0cont);
            this.DoubleBuffered = true;
            this.Name = "Ej1";
            this.Size = new System.Drawing.Size(1366, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ej0cont;
    }
}
