using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ObraCompletoException : Exception
    {
        public ObraCompletoException(string mensaje): base(mensaje)
        {

        }
    }
}
