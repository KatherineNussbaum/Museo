using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class PersonaException : Exception
    {
        /// <summary>
        /// Método Exception para clase Persona
        /// </summary>
        /// <param name="mensaje"></param>
        public PersonaException(string mensaje) : base(mensaje)
        {

        }
    }
}
