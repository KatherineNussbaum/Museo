using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ObraException: Exception
    {
        /// <summary>
        /// Método Exception para clase Obra
        /// </summary>
        /// <param name="mensaje"></param>
        public ObraException(string mensaje) : base(mensaje)
        {

        }
    }
}
