using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class UbicacionException : Exception
    {
        /// <summary>
        /// Método Exception para clase Ubicacion
        /// </summary>
        /// <param name="mensaje"></param>
        public UbicacionException(string mensaje) : base(mensaje)
        {

        }
    }
}
