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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTipo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioTipo.svc o ServicioTipo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioTipo : IServicioTipo
    {
        private ITipoBO _tipoBO;

        public ServicioTipo()
        {
            this._tipoBO = new TipoBO();
        }
        public IList<Tipo> ListarTipos()
        {
            return this._tipoBO.ListarTipos();
        }
    }
}
