using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;
using CapaInterface;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbicacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbicacion
    {
        [OperationContract]
        IList<Ubicacion> ListarUbicaciones();
    }
}
