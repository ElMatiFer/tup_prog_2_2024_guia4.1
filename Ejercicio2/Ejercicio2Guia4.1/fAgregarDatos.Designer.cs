namespace Ejercicio2Guia4._1
{
    partial class fAgregarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código aduanero";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(135, 8);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(164, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.Location = new System.Drawing.Point(135, 34);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(164, 20);
            this.tbEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa";
            // 
            // btAgregar
            // 
            this.btAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAgregar.Location = new System.Drawing.Point(15, 70);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(135, 23);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(156, 70);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(139, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // fAgregarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 105);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmpresa);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Name = "fAgregarDatos";
            this.Text = "Datos del envío";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btCancelar;
    }
}