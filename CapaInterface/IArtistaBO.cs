﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;

namespace CapaInterface
{
    public interface IArtistaBO
    {
        #region Métodos
        IList<Artista> ListarArtistas();
        #endregion
    }
}
