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

        }
        protected void Mensaje(string mensaje)
        {
            LblMensaje.Text = mensaje;
            LblMensaje.Visible = true;
        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            LblMensaje.Visible = false;
            UsuariosServ.ServicioUsuariosClient login = new UsuariosServ.ServicioUsuariosClient();

            bool existe = login.VerificarUsuarios(TxtUsuario.Text);
            if (!existe)
            {
                Mensaje("El usuario ingresado no éxiste.");
            }
            else
            {
                var usuario = login.BuscarUsuario(TxtUsuario.Text);
                if (usuario.Pass.Equals(TxtPass.Text))
                {
                    Session["usuario"] = TxtUsuario.Text;
                    Response.Redirect("Reportes.aspx");
                }
                else
                {
                    Mensaje("La contraseña ingresada no corresponde.");
                }
            }
        }
    }
}