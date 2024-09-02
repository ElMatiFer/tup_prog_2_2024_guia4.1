using Ejercicio1Guia4._1.API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia4._1.Cliente
{
    internal class Envio : IComparable, IProcesable
    {
        ArrayList costos = new ArrayList();

        public int NumeroAduanero {  get; private set; }
        public double CostoTotal 
        { 
            get
            { 
                double total = 0;
                foreach (ICosto a in costos)
                {
                     total += a.Valor;
                }
                return total;
            } 
        }
        public int CantidadCostos 
        {
            get
            {     
                 return costos.Count;
            } 
        }
        public Envio(int numeroAduanero)
        {
            NumeroAduanero = numeroAduanero;
        }
        public ICosto VerCosto(int idx)
        {    
              return costos[idx] as ICosto;
        }
        public ICosto CrearCosto(string concepto, double valor)
        {
            ICosto costo = new Costo(concepto, valor);
            costos.Add(costo);
            return costo;
        }
        public int CompareTo(object obj)
        {

            if (obj != null && obj is Envio)
            {
                Envio envio = obj as Envio;
                return NumeroAduanero.CompareTo(envio.NumeroAduanero);
            }
            return 1;
        }
        public override string ToString()
        {
            return $"Envio: {NumeroAduanero}";
        }
    }
}
