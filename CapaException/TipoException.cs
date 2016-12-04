using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class TipoException : Exception
    {
        public TipoException(string mensaje) : base(mensaje)
        {

        }
    }
}
