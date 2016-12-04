using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    public interface IObraBO
    {
        bool AgregarObra(string codigo, string artistaRut, string estilo, long valor, string dimensiones, string procedencia, string cuidadosEspeciales, int ubicacionId, DateTime? fechaIngreso);
        bool VerificarObra(string codigo);
        IList<Obra> ListarObras();
        IList<Obra> ListarObrasArtista(string artistaRut);
        
    }
}
