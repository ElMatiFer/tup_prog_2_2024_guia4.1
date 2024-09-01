using Ejercicio1Guia4._1.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia4._1.Proveedores
{
    internal class Transporte : IProcesadorEnvios
    {
        public double DistanciaKM { get; private set; }
        public double PrecioKM { get; private set; }
        public Transporte(double distanciaKM, double precioKM)
        {
            PrecioKM = precioKM;
            DistanciaKM = distanciaKM;
        }

        public void ProcesarEnvios(IProcesable[] envios)
        {
            if (envios != null && envios.Length > 0)
            {
                double valorProducto = DistanciaKM * PrecioKM / envios.Length;

                foreach (IProcesable a in envios)
                {
                    a.CrearCosto("Costo de transporte: ", valorProducto);
                }
            }
        }
    }
}
