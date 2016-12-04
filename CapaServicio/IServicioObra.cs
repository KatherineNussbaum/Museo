using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaDato;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioObra" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioObra
    {
        [OperationContract]
        bool AgregarObra(string codigo, string artistaRut, string estilo, long valor, string dimensiones,
        DateTime fechaCreacion, string procedencia, string cuidadosEspeciales, int ubicacionId, DateTime fechaIngreso);
        [OperationContract]
        bool VerificarObra(string codigo);
        [OperationContract]
        IList<Obra> ListarObras();
        [OperationContract]
        IList<Obra> ListarObrasArtista(string artistaRut);
    }
}
