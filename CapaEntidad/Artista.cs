using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Artista
    {
        public string Rut { get; set; }
        public string NombreCompleto { get; set; }

        public Artista()
        {
            this.Rut = this.NombreCompleto = string.Empty;
        }
    }
}
