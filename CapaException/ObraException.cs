using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ObraException: Exception
    {
        public ObraException(string mensaje) : base(mensaje)
        {

        }
    }
}
