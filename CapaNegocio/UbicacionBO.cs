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
    public class UbicacionBO : IUbicacionBO
    {
        private MuseoEntities _objContext;
        public UbicacionBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<Ubicacion> ListarUbicaciones()
        {
            return this._objContext.Ubicacion.ToList();
        }
    }
}
