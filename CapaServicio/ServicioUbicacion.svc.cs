using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaInterface;
using CapaNegocio;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbicacion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioUbicacion.svc o ServicioUbicacion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioUbicacion : IServicioUbicacion
    {
        private IUbicacionBO _ubicacionBO;
        public ServicioUbicacion()
        {
            this._ubicacionBO = new UbicacionBO();
        }
        public IList<Ubicacion> ListarUbicaciones()
        {
            return this._ubicacionBO.ListarUbicaciones();
        }
    }
}
