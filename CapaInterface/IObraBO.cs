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
        bool AgregarObra(string codigo, string artistaRut, string estilo, long valor, string dimensiones,
        string fechaCreacion, DateTime? procedencia, string temperatura, string humedad, string ubicacionSalon);

        bool VerificarObra(string codigo);

        IList<Obra> ListarObras();
    }
}
