using Ejercicio1Guia4._1.API;
using Ejercicio1Guia4._1.Cliente;
using Ejercicio1Guia4._1.Proveedores;
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

namespace Ejercicio1Guia4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Ordenar(IComparable[] envios, int cantidad)
        {
            for (int n = 0; n < cantidad - 1; n++)
            {
                for (int m = n + 1; m < cantidad; m++)
                {
                    if (envios[n].CompareTo(envios[m]) > 0)
                    {
                        IComparable aux = envios[m];
                        envios[m] = envios[n];
                        envios[n] = aux;
                    }
                }
            }
        }

        private void btPrueba_Click(object sender, EventArgs e)
        {
            Envio[] envios = new Envio[] //lista de envíos planificados
            {     
                new Envio(2423),
                new Envio(2323),
                new Envio(2293),
                new Envio(1423)
            };

            ArrayList agentesCargos = new ArrayList() //agentes de recargos
            {
                new Transporte(2344,23),
                new Aduana(23244),
            };

            foreach (IProcesadorEnvios agente in agentesCargos)
            {
                agente.ProcesarEnvios(envios);
            }

            Ordenar(envios, envios.Length);//por lo del length, se que el vector está completo!
            foreach (IProcesable env in envios)
            {
                tbVer.Text += $"{env.ToString()}\r\n";//número aduanero

                for (int idx = 0; idx < env.CantidadCostos; idx++)
                {
                    tbVer.Text += env.VerCosto(idx).ToString() + "\r\n";//concepto y valor
                }

                tbVer.Text += $"Total:{env.CostoTotal:f2}\r\n\r\n";//total
            }



        }
    }
}
