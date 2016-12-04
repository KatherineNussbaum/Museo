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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioUsuarios.svc o ServicioUsuarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioUsuarios : IServicioUsuarios
    {
        private IUsuariosBO _usuariosBO;
        public ServicioUsuarios()
        {
            this._usuariosBO = new UsuariosBO();
        }

        public Usuarios BuscarUsuario(string usuario)
        {
            return this._usuariosBO.BuscarUsuario(usuario);
        }

        public bool VerificarUsuarios(string usuario)
        {
            return this._usuariosBO.VerificarUsuarios(usuario);
        }
    }
}
