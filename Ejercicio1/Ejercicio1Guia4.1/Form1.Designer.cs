namespace Ejercicio1Guia4._1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPrueba = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btPrueba
            // 
            this.btPrueba.Location = new System.Drawing.Point(520, 161);
            this.btPrueba.Name = "btPrueba";
            this.btPrueba.Size = new System.Drawing.Size(140, 92);
            this.btPrueba.TabIndex = 1;
            this.btPrueba.Text = "Prueba";
            this.btPrueba.UseVisualStyleBackColor = true;
            this.btPrueba.Click += new System.EventHandler(this.btPrueba_Click);
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(12, 12);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ReadOnly = true;
            this.tbVer.Size = new System.Drawing.Size(502, 426);
            this.tbVer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPrueba;
        private System.Windows.Forms.TextBox tbVer;
    }
}

