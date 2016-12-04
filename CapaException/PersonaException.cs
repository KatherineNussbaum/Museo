using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class PersonaException : Exception
    {
        public PersonaException(string mensaje) : base(mensaje)
        {

        }
    }
}
