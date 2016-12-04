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
            #region Asignación de variables
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
            DateTime? fechaNacimiento = null;
            if (!string.IsNullOrEmpty(TxtFechaNacimiento.Text) && !string.IsNullOrWhiteSpace(TxtFechaNacimiento.Text))
            {
                fechaNacimiento = Convert.ToDateTime(TxtFechaNacimiento.Text);
            }
            
            string domicilio = TxtDomicilio.Text;
            string fono = TxtFono.Text;
            string email = TxtEmail.Text;
            int tipo = 1;
            #endregion

            PersonaServ.ServicioPersonaClient persona = new PersonaServ.ServicioPersonaClient();
            if (persona.VerificarPersona(rut))
            {
                Mensaje("Esta persona ya se encuentra registrada");
            }
            else
            {
                bool result = persona.AgregarPersona(rut, dv, nombres, apPaterno, apMaterno, sexo, fechaNacimiento, domicilio, fono, email, tipo);
                if (result)
                {
                    Mensaje("El artista fue agregado con éxito");
                }
                else
                {
                    Mensaje("Ocurrió un error. El artista no se guardó");
                }
            }
        }
    }
}