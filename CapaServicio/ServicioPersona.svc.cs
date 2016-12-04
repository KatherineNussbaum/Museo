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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPersona" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioPersona.svc o ServicioPersona.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioPersona : IServicioPersona
    {
        private IPersonaBO _personaBO;
        public ServicioPersona()
        {
            this._personaBO = new PersonaBO();
        }

        public bool AgregarPersona(string rut, string dv, string nombres, string apPaterno, string apMaterno, string sexo, DateTime? fechaNacimiento, string domicilio, string fono, string email, int tipo)
        {
            return this._personaBO.AgregarPersona(rut, dv, nombres, apPaterno, apMaterno, sexo, fechaNacimiento, domicilio, fono, email, tipo);
        }

        public IList<Persona> ListarArtistas()
        {
            return this._personaBO.ListarArtistas();
        }

        public bool VerificarPersona(string rut)
        {
            return this._personaBO.VerificarPersona(rut);
        }
    }
}
