using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaException
{
    public class UsuariosException : Exception
    {
        /// <summary>
        /// Método Exception para clase Usuarios
        /// </summary>
        /// <param name="mensaje"></param>
        public UsuariosException(string mensaje) : base(mensaje)
        {

        }
    }
}
