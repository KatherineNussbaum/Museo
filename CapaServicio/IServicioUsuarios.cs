using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuarios
    {
        [OperationContract]
        bool VerificarUsuarios(string usuario);
        [OperationContract]
        Usuarios BuscarUsuario(string usuario);
    }
}
