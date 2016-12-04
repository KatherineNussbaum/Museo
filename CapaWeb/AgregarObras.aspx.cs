using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb
{
    public partial class AgregarObras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Mensaje(string mensaje)
        {
            LblMensaje.Text = mensaje;
            LblMensaje.Visible = true;
        }

        protected void Limpiar()
        {
            TxtCodigo.Text = TxtCuidadosEspeciales.Text = TxtDimensiones.Text = TxtEstilo.Text = TxtFechaIngreso.Text = TxtProcedencia.Text = TxtValor.Text = string.Empty;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LblMensaje.Visible = false;
            #region Asignación de Variables
            string codigo = TxtCodigo.Text;
            string artistaRut = DdlArtista.SelectedValue;
            string estilo = TxtEstilo.Text;
            int valor;
            int.TryParse(TxtValor.Text, out valor);
            string dimensiones = TxtDimensiones.Text;
            string procedencia = TxtProcedencia.Text;
            string cuidadosEspeciales = TxtCuidadosEspeciales.Text;
            int ubicacionId;
            int.TryParse(DdlUbicacion.SelectedValue, out ubicacionId);
            DateTime? fechaIngreso = null;
            
            if(!string.IsNullOrEmpty(TxtFechaIngreso.Text) && !string.IsNullOrWhiteSpace(TxtFechaIngreso.Text))
            {
                fechaIngreso = Convert.ToDateTime(TxtFechaIngreso.Text);
            }
            
            #endregion

            ObraServ.ServicioObraClient obras = new ObraServ.ServicioObraClient();

            bool result = obras.VerificarObra(codigo);
            if (result)
            {
                Mensaje("El código de esta obra ya esta ingresada en el sistema");
            }
            else
            {
                bool resultAgregar = obras.AgregarObra(codigo, artistaRut, estilo, valor, dimensiones, procedencia, cuidadosEspeciales, ubicacionId, fechaIngreso);
                if (resultAgregar)
                {
                    Mensaje("La obra fue agregada exitosamente.");
                    
                }
                else
                {
                    Mensaje("Ocurrió un error. La obra no fue guardada.");
                    
                }
                Limpiar();
            }
        }
    }
}