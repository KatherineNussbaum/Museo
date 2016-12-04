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
        #region Métodos
        /// <summary>
        /// Método para agregar Personas 
        /// </summary>
        /// <param name="rut"></param>
        /// <param name="dv"></param>
        /// <param name="nombres"></param>
        /// <param name="apPaterno"></param>
        /// <param name="apMaterno"></param>
        /// <param name="sexo"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="domicilio"></param>
        /// <param name="fono"></param>
        /// <param name="email"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public bool AgregarPersona(string rut, string dv, string nombres, string apPaterno, string apMaterno, string sexo, 
            DateTime? fechaNacimiento, string domicilio, string fono, string email, int tipo)
        {
            #region Validaciones
            if (string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
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
            #endregion
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

        /// <summary>
        /// Método que verifica si un rut ya se encuentra ingresado
        /// </summary>
        /// <param name="rut"></param>
        /// <returns></returns>
        public bool VerificarPersona(string rut)
        {
            if(string.IsNullOrEmpty(rut) || string.IsNullOrWhiteSpace(rut))
            {
                throw new PersonaException("Error: falta rut");
            }
            return this._objContext.Persona.Any(p => p.Rut == rut);
        }

        /// <summary>
        /// Método para listar todos los artistas
        /// </summary>
        /// <returns></returns>
        public IList<Persona> ListarArtistas()
        {
            return this._objContext.Persona.Where(p => p.Tipo == 1 || p.Tipo == 3).ToList();
        }

        #endregion
    }
}
