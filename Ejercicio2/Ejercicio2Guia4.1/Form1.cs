using Ejercicio2Guia4._1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Guia4._1
{
    public partial class Form1 : Form
    {
        Logistica logistica = new Logistica();
        Envio envioSeleccionado;
        public Form1()
        {
            InitializeComponent();
            cbCostos.Items.Add(new Fijo("Peaje puente Zárate", 300));
            cbCostos.Items.Add(new Variable("Combustible", 1500.5, 500));
            cbCostos.Items.Add(new Fijo("Peaje túnel", 300));
            cbCostos.Items.Add(new Variable("Horas de conducción", 500, 10));
        }

        
        
        private void btAltaEnvio_Click(object sender, EventArgs e)
        {
            if (tbCodigoAduanero.Text != "")
            {

                int codigo = Convert.ToInt32(tbCodigoAduanero.Text);

                int idx = logistica.VerEnvioPorCodigo(codigo);

                envioSeleccionado = null;

                if (idx >= 0)
                {
                    
                    envioSeleccionado = logistica.VerEnvio(idx);
                }
                else
                {
                    fAgregarDatos formDatos = new fAgregarDatos();
                    formDatos.tbCodigo.Text = codigo.ToString();
                    formDatos.tbCodigo.Enabled = false;
                    if (formDatos.ShowDialog() == DialogResult.OK)
                    {
                        string empresa = formDatos.tbEmpresa.Text;
                        envioSeleccionado = new Envio(codigo, empresa);
                        lEmpresa.Text = empresa;
                    }
                }
            }
        }

        private void btSeleccionarCosto_Click(object sender, EventArgs e)
        {
            Costo costo = cbCostos.SelectedItem as Costo;
            envioSeleccionado.AgregarCosto(costo);
            lbDetalle.Items.Add(costo.ToString());
            cbCostos.SelectedIndex = -1;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            logistica.AgregarEnvio(envioSeleccionado);
            tbCodigoAduanero.Clear();
            lEmpresa.Text = "";
            lbDetalle.Items.Clear();
            
            envioSeleccionado = null;

        }

        private void btListar_Click(object sender, EventArgs e)
        {
            for (int idx = 0; idx < logistica.CantidadEnvios; idx++)
            {
                Envio env = logistica.VerEnvio(idx);
                tbEnvios.Text += env.ToString() + "\r\n\r\n";
            }

        }
    }
}
