using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;
using CapaException;
using CapaInterface;

namespace CapaNegocio
{
    public class ArtistaBO :IArtistaBO
    {
        private MuseoEntities _objContext;
        public ArtistaBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public IList<Artista> ListarArtistas()
        {
            IList<Artista> artista = (from p in _objContext.Persona 
                                      where p.Tipo == 1
                                      select new Artista
                                      {
                                          Rut = p.Rut,
                                          NombreCompleto = p.Nombres + " " + p.ApPaterno + " " + p.ApMaterno
                                      }).ToList();
            return artista;
        }
    }
}
