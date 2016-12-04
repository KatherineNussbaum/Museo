using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ObraCompletoException : Exception
    {
        /// <summary>
        /// Método Exception para clase ObraCompleto
        /// </summary>
        /// <param name="mensaje"></param>
        public ObraCompletoException(string mensaje): base(mensaje)
        {

        }
    }
}
