using Ejercicio1Guia4._1.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia4._1.Proveedores
{
    internal class Aduana : IProcesadorEnvios
    {
        public double ValorFijo { get; private set; }
        public Aduana(double valorFijo)
        {
            ValorFijo = valorFijo;
        }
        public void ProcesarEnvios(IProcesable[] envios)
        {
            if (envios != null)
            {
                foreach (IProcesable a in envios)
                {
                    a.CrearCosto("Costo de aduana: ", ValorFijo);
                }
            }
        }
    }
}
