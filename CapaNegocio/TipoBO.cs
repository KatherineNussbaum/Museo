using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaException;
using CapaInterface;

namespace CapaNegocio
{
    public class TipoBO : ITipoBO
    {
        private MuseoEntities _objContext;
        public TipoBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }
        #region Métodos
        /// <summary>
        /// Método que lista los tipos de personas
        /// </summary>
        /// <returns></returns>
        public IList<Tipo> ListarTipos()
        {
            return this._objContext.Tipo.ToList();
        }
        #endregion
    }
}
