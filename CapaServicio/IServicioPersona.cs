using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPersona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPersona
    {
        [OperationContract]
        bool AgregarPersona(string rut, string dv, string nombres, string apPaterno, string apMaterno, string sexo, DateTime? fechaNacimiento, string domicilio, string fono, string email, int tipo);
        [OperationContract]
        bool VerificarPersona(string rut);
        [OperationContract]
        IList<Persona> ListarArtistas();
    }
}
