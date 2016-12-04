using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ArtistaException : Exception
    {
        /// <summary>
        /// Método Exception para clase Artista
        /// </summary>
        /// <param name="mensaje"></param>
        public ArtistaException(string mensaje) : base(mensaje)
        {

        }
    }
}
