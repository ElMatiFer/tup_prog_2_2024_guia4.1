using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio2Guia4._1.Models
{
    internal class Logistica
    {
        ArrayList envios = new ArrayList();
        public int CantidadEnvios
        {
            get
            {
                
                    return envios.Count;
               
            }
        }
        public Envio AgregarEnvio(Envio nuevo)
        {
            if (nuevo != null)
            { 
                envios.Add(nuevo);
            }
            return nuevo;
        }
        public int VerEnvioPorCodigo(int codigo)
        {
            envios.Sort();
            int idx = envios.BinarySearch(new Envio(codigo));
            return idx;
           
        }
        public Envio VerEnvio(int idx)
        {
            return (Envio)envios[idx];
        }

    }
}
