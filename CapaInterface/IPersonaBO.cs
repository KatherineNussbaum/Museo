using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    public interface IPersonaBO
    {
        bool AgregarPersona(string rut, string dv, string nombres, string apPaterno, string apMaterno, string sexo, DateTime? fechaNacimiento, string domicilio, string fono, string email, int tipo);
        bool VerificarPersona(string rut);
        IList<Persona> ListarArtistas();

    }
}
