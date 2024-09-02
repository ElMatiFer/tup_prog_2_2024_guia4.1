using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Guia4._1.Models
{
    internal class Envio : IComparable
    {
        public ArrayList costos = new ArrayList();
        public int CodigoAduanero {  get; private set; }
        public string Empresa { get; private set; }

        public double ValorTotal 
        {
            get
            {
                double acum = 0;
                foreach (Costo a in costos)
                {
                    acum += a.ValorFinal;
                }
                return acum; 
            }
        }
        public int CantidadCostos
        {
            get
            {
                
                    return costos.Count;
                
            }
        }
        public Envio(int codigo, string empresa)
        {
            CodigoAduanero = codigo;
            Empresa = empresa;
        }
        public Envio(int codigo)
        {
            CodigoAduanero = codigo; 
        }
        public void AgregarCosto(Costo nuevo)
        {
            costos.Add(nuevo);
        }
        public int CompareTo(object obj)
        {
            if (obj != null && obj is Envio)
            {
                Envio a = obj as Envio;
                return CodigoAduanero.CompareTo(a.CodigoAduanero);
            }
            return -1;
        }
        public override string ToString()
        {
            return $"Envío: {CodigoAduanero,10:000000} Empresa:{Empresa} Total:${ValorTotal:f2}";
        }
    }
}
