using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class AgregarArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Mensaje(string mensaje)
        {
            LblMensaje.Text = mensaje;
            LblMensaje.Visible = true;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LblMensaje.Visible = false;

           if(TxtRut.Text.Length < 7 || TxtRut.Text.Length > 8)
            {
                LblMensaje.Text = "El rut debe tener entr 7 y 8 digitos.";
            }
            string rut = TxtRut.Text;
            string dv = TxtDv.Text;
            string nombres = TxtNombres.Text;
            string apPaterno = TxtApPaterno.Text;
            string apMaterno = TxtApMaterno.Text;
            string sexo;
            if (RdbFemenino.Checked)
            {
                sexo = "F";
            }
            else
            {
                sexo = "M";
            }
            string fechaNacimiento = TxtFechaNacimiento.Text;
            string domicilio = TxtDomicilio.Text;
            string fono = TxtFono.Text;
            string email = TxtEmail.Text;
            
        }
    }
}