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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioObra" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioObra.svc o ServicioObra.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioObra : IServicioObra
    {
        private IObraBO _obraBO;
        public ServicioObra()
        {
            this._obraBO = new ObraBO();
        }

        public bool AgregarObra(string codigo, string artistaRut, string estilo, long valor, string dimensiones, DateTime fechaCreacion, string procedencia, string cuidadosEspeciales, int ubicacionId, DateTime fechaIngreso)
        {
            return this._obraBO.AgregarObra(codigo, artistaRut, estilo, valor, dimensiones, fechaCreacion, procedencia, cuidadosEspeciales, ubicacionId, fechaIngreso);
        }
        
        public IList<Obra> ListarObras()
        {
            return this._obraBO.ListarObras();
        }

        public IList<Obra> ListarObrasArtista(string artistaRut)
        {
            throw new NotImplementedException();
        }

        public bool VerificarObra(string codigo)
        {
            return this._obraBO.VerificarObra(codigo);
        }

    }
}
