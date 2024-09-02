using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Guia4._1.Models
{
    internal abstract class Costo
    {
        public string Concepto { get; private set; }
        virtual public double ValorFinal { get; protected set; }

        public Costo(string concepto) 
        {
            Concepto = concepto;
        }
    }
}
