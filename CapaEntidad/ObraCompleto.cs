using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ObraCompleto
    {
        #region Variables
        public string Codigo { get; set; }
        public string Artista { get; set; }
        public string Estilo { get; set; }
        public long? Valor { get; set; }
        public string Dimensiones { get; set; }
        public string Procedencia { get; set; }
        public string CuidadosEspeciales { get; set; }
        public string Salon { get; set; }
        public DateTime? FechaIngreso { get; set; }
        #endregion

        public ObraCompleto()
        {
            this.Codigo = this.Artista = this.Estilo = this.Dimensiones = this.Procedencia = this.CuidadosEspeciales = this.Salon = string.Empty;
            this.Valor = 0;
            this.FechaIngreso = null;
        }
    }
}
