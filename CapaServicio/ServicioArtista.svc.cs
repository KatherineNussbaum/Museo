using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaEntidad;
using CapaInterface;
using CapaNegocio;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioArtista" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioArtista.svc o ServicioArtista.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioArtista : IServicioArtista
    {
        private IArtistaBO _artistaBO;

        public ServicioArtista()
        {
            this._artistaBO = new ArtistaBO();
        }

        public IList<Artista> ListarArtistas()
        {
            return this._artistaBO.ListarArtistas();
        }
    }
}
