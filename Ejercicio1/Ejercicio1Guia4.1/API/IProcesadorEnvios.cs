﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia4._1.API
{
    internal interface IProcesadorEnvios
    {
        void ProcesarEnvios(IProcesable[] envios);
    }
}
