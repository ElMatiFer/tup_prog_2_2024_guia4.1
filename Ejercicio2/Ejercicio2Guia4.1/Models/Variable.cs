using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Guia4._1.Models
{
    internal class Variable : Costo
    {
        public double PrecioUnidad { get; private set; }
        public double Unidades { get; private set; }
        public override double ValorFinal { get { return PrecioUnidad * Unidades; } }

        public Variable(string concepto, double unidades, double precioUnidad) : base(concepto)
        {
            PrecioUnidad = precioUnidad;
            Unidades = unidades;
        }
        public override string ToString()
        {
            return $"Concepto: {Concepto} | Unidades: {Unidades} | Precio por unidad: {PrecioUnidad}";
        }
    }
}
