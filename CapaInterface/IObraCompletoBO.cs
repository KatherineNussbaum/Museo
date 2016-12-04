using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;

namespace CapaInterface
{
    public interface IObraCompletoBO
    {
        IList<ObraCompleto> ListarObrasCompleto();
        IList<ObraCompleto> ListarObrasCompleto365();
        IList<ObraCompleto> ListarObrasCompletoArtista(string rut);
    }
}
