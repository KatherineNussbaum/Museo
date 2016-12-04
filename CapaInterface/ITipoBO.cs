using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    public interface ITipoBO
    {
        IList<Tipo> ListarTipos();
    }
}
