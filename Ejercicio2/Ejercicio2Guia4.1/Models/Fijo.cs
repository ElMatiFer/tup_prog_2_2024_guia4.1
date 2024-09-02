using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Guia4._1.Models
{
    internal class Fijo : Costo
    {
        public override double ValorFinal { get; protected set; }
        public Fijo(string concepto, double valorFinal) : base (concepto)
        {
            ValorFinal = valorFinal;
        }
        public override string ToString()
        {
            return $"Concepto: {Concepto} | Valor Final: {ValorFinal}";
        }
    }
}
