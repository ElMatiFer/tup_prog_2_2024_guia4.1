namespace Ejercicio2Guia4._1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btListar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDetalle = new System.Windows.Forms.ListBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btSeleccionarCosto = new System.Windows.Forms.Button();
            this.cbCostos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAltaEnvio = new System.Windows.Forms.Button();
            this.tbCodigoAduanero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnvios = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEnvios);
            this.groupBox3.Controls.Add(this.btListar);
            this.groupBox3.Location = new System.Drawing.Point(12, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 217);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Envíos cargados";
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(244, 19);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(166, 79);
            this.btListar.TabIndex = 7;
            this.btListar.Text = "Listar envios existentes";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDetalle);
            this.groupBox2.Controls.Add(this.btGuardar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btSeleccionarCosto);
            this.groupBox2.Controls.Add(this.cbCostos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver/Alta de Envío";
            // 
            // lbDetalle
            // 
            this.lbDetalle.FormattingEnabled = true;
            this.lbDetalle.Location = new System.Drawing.Point(6, 76);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(232, 160);
            this.lbDetalle.TabIndex = 7;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(244, 76);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(166, 79);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar Envío";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalle";
            // 
            // btSeleccionarCosto
            // 
            this.btSeleccionarCosto.Location = new System.Drawing.Point(244, 34);
            this.btSeleccionarCosto.Name = "btSeleccionarCosto";
            this.btSeleccionarCosto.Size = new System.Drawing.Size(166, 21);
            this.btSeleccionarCosto.TabIndex = 3;
            this.btSeleccionarCosto.Text = "Seleccionar y agregar costo";
            this.btSeleccionarCosto.UseVisualStyleBackColor = true;
            this.btSeleccionarCosto.Click += new System.EventHandler(this.btSeleccionarCosto_Click);
            // 
            // cbCostos
            // 
            this.cbCostos.FormattingEnabled = true;
            this.cbCostos.Location = new System.Drawing.Point(6, 34);
            this.cbCostos.Name = "cbCostos";
            this.cbCostos.Size = new System.Drawing.Size(232, 21);
            this.cbCostos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Costos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btAltaEnvio);
            this.groupBox1.Controls.Add(this.tbCodigoAduanero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver/Alta de Envío";
            // 
            // lEmpresa
            // 
            this.lEmpresa.AutoSize = true;
            this.lEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpresa.Location = new System.Drawing.Point(147, 57);
            this.lEmpresa.Name = "lEmpresa";
            this.lEmpresa.Size = new System.Drawing.Size(0, 15);
            this.lEmpresa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa de transporte:";
            // 
            // btAltaEnvio
            // 
            this.btAltaEnvio.Location = new System.Drawing.Point(244, 34);
            this.btAltaEnvio.Name = "btAltaEnvio";
            this.btAltaEnvio.Size = new System.Drawing.Size(166, 20);
            this.btAltaEnvio.TabIndex = 2;
            this.btAltaEnvio.Text = "Ver/Alta Envío";
            this.btAltaEnvio.UseVisualStyleBackColor = true;
            this.btAltaEnvio.Click += new System.EventHandler(this.btAltaEnvio_Click);
            // 
            // tbCodigoAduanero
            // 
            this.tbCodigoAduanero.Location = new System.Drawing.Point(6, 34);
            this.tbCodigoAduanero.Name = "tbCodigoAduanero";
            this.tbCodigoAduanero.Size = new System.Drawing.Size(232, 20);
            this.tbCodigoAduanero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Aduanero";
            // 
            // tbEnvios
            // 
            this.tbEnvios.Location = new System.Drawing.Point(8, 19);
            this.tbEnvios.Multiline = true;
            this.tbEnvios.Name = "tbEnvios";
            this.tbEnvios.Size = new System.Drawing.Size(230, 198);
            this.tbEnvios.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSeleccionarCosto;
        private System.Windows.Forms.ComboBox cbCostos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAltaEnvio;
        private System.Windows.Forms.TextBox tbCodigoAduanero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDetalle;
        private System.Windows.Forms.Label lEmpresa;
        private System.Windows.Forms.TextBox tbEnvios;
    }
}

