using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaEntidad;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioArtista" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioArtista
    {
        [OperationContract]
        IList<Artista> ListarArtistas();
    }
}
