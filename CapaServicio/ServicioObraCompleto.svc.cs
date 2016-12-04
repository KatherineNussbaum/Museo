using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaEntidad;
using CapaInterface;
using CapaNegocio;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioObraCompleto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioObraCompleto.svc o ServicioObraCompleto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioObraCompleto : IServicioObraCompleto
    {
        private IObraCompletoBO _obraCompletoBO;
        public ServicioObraCompleto()
        {
            this._obraCompletoBO = new ObraCompletoBO();
        }

        public IList<ObraCompleto> ListarObrasCompleto()
        {
            return this._obraCompletoBO.ListarObrasCompleto();
        }

        public IList<ObraCompleto> ListarObrasCompleto365()
        {
            return this._obraCompletoBO.ListarObrasCompleto365();
        }

        public IList<ObraCompleto> ListarObrasCompletoArtista(string rut)
        {
            return this._obraCompletoBO.ListarObrasCompletoArtista(rut);
        }
    }
}
