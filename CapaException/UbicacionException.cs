﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class UbicacionException : Exception
    {
        public UbicacionException(string mensaje) : base(mensaje)
        {

        }
    }
}
