using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class ArtistaException : Exception
    {
        public ArtistaException(string mensaje) : base(mensaje)
        {

        }
    }
}
