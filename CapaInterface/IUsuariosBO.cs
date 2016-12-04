﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaInterface
{
    public interface IUsuariosBO
    {
        #region Métodos
        bool VerificarUsuarios(string usuario);
        Usuarios BuscarUsuario(string usuario);
        #endregion
    }
}
