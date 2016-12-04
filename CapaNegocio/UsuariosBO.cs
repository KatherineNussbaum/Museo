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
    public class UsuariosBO : IUsuariosBO
    {
        private MuseoEntities _objContext;
        public UsuariosBO()
        {
            this._objContext = new MuseoEntities();
            this._objContext.Configuration.ProxyCreationEnabled = false;
        }
        #region Métodos
        /// <summary>
        /// Método que busca y devuelve un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Usuarios BuscarUsuario(string usuario)
        {
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
            {
                throw new UsuariosException("Error: Falta usuario");
            }
            return this._objContext.Usuarios.FirstOrDefault(u => u.Usuario == usuario);
        }

        /// <summary>
        /// Método que verifica si un usuario se encuentra registrado
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool VerificarUsuarios(string usuario)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrWhiteSpace(usuario))
            {
                throw new UsuariosException("Error: Falta usuario");
            }
            return this._objContext.Usuarios.Any(u => u.Usuario == usuario);
        }
        #endregion
    }
}
