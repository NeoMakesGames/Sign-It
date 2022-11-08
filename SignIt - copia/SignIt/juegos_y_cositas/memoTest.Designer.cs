namespace SignIt
{
    partial class memoTest
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
            this.MemoTimerA = new System.Windows.Forms.Timer(this.components);
            this.MemoTimerB = new System.Windows.Forms.Timer(this.components);
            this.Memotest_1 = new System.Windows.Forms.Button();
            this.Memotest_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemoTimerA
            // 
            this.MemoTimerA.Interval = 250;
            // 
            // MemoTimerB
            // 
            this.MemoTimerB.Interval = 1000;
            // 
            // Memotest_1
            // 
            this.Memotest_1.Location = new System.Drawing.Point(476, 133);
            this.Memotest_1.Name = "Memotest_1";
            this.Memotest_1.Size = new System.Drawing.Size(75, 23);
            this.Memotest_1.TabIndex = 0;
            this.Memotest_1.Text = "button1";
            this.Memotest_1.UseVisualStyleBackColor = true;
            // 
            // Memotest_2
            // 
            this.Memotest_2.Location = new System.Drawing.Point(333, 201);
            this.Memotest_2.Name = "Memotest_2";
            this.Memotest_2.Size = new System.Drawing.Size(75, 23);
            this.Memotest_2.TabIndex = 1;
            this.Memotest_2.Text = "button2";
            this.Memotest_2.UseVisualStyleBackColor = true;
            // 
            // memoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::SignIt.Properties.Resources.Fondo_triángulos_prendidos__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Memotest_2);
            this.Controls.Add(this.Memotest_1);
            this.DoubleBuffered = true;
            this.Name = "memoTest";
            this.Size = new System.Drawing.Size(1366, 788);
            this.Load += new System.EventHandler(this.memoTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MemoTimerA;
        private System.Windows.Forms.Timer MemoTimerB;
        private System.Windows.Forms.Button Memotest_1;
        private System.Windows.Forms.Button Memotest_2;
    }
}
