using Ejercicio1Guia4._1.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia4._1.Cliente
{
    internal class Costo : ICosto
    {
        public string Concepto { get;}
        public double Valor { get;}

        public Costo(string concepto, double valor)
        {
            Concepto = concepto;
            Valor = valor;
        }
        public override string ToString()
        {
            return $"Concepto: {Concepto} | Valor: {Valor}";
        }
    }
}
