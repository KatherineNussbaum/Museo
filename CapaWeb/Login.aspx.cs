using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = null;
        }

        protected void Mensaje(string mensaje)
        {
            LblMensaje.Visible = true;
            LblMensaje.Text = mensaje;
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            UsuariosServ.ServicioUsuariosClient login = new UsuariosServ.ServicioUsuariosClient();
            bool result = login.VerificarUsuarios(TxtUsuario.Text);
            if (!result)
            {
                Mensaje("El usuario ingresado no esta registrado.");
            }
            else
            {
                var usuario = login.BuscarUsuario(TxtUsuario.Text);
                if(usuario.Pass == TxtPass.Text)
                {
                    Session["usuario"] = TxtUsuario.Text;
                    Response.Redirect("Reportes.aspx");
                }
                else
                {
                    Mensaje("La contraseña no es correcta.");
                }
            }
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}