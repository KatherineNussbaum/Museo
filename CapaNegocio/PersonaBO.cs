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
    public class PersonaBO : IPersonaBO
    {
        private MuseoEntities _objContext;

        public PersonaBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }

        public bool AgregarPersona(string rut, string dv, string nombres, string apPaterno, string apMaterno, string sexo, 
            DateTime? fechaNacimiento, string domicilio, string fono, string email, int tipo)
        {
            if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new PersonaException("Error: falta rut.");
            }
            if (string.IsNullOrEmpty(dv) || string.IsNullOrWhiteSpace(dv))
            {
                throw new PersonaException("Error: falta dv.");
            }
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                throw new PersonaException("Error: falta nombres.");
            }
            if (string.IsNullOrEmpty(apPaterno) || string.IsNullOrWhiteSpace(apPaterno))
            {
                throw new PersonaException("Error: falta apellido paterno.");
            }
            if (!this.VerificarPersona(rut))
            {
                Persona persona = new Persona
                {
                    Rut = rut,
                    Div = dv,
                    Nombres = nombres,
                    ApPaterno = apPaterno,
                    ApMaterno = apMaterno,
                    Sexo = sexo,
                    FechaNacimiento = fechaNacimiento,
                    Domicilio = domicilio,
                    Fono = fono,
                    Email = email,
                    Tipo = tipo
                };
                this._objContext.Persona.Add(persona);
                return this._objContext.SaveChanges() > 0;
            }
            return false;
        }

        public bool VerificarPersona(string rut)
        {
            if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new PersonaException("Error: falta rut");
            }
            return this._objContext.Persona.Any(p => p.Rut == rut);
        }

        public IList<Persona> ListarArtistas()
        {
            return this._objContext.Persona.Where(p => p.Tipo == 1 || p.Tipo == 3).ToList();
        }

    }
}
