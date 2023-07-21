using MedidoresInteligentesDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresInteligentesDB
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            int id = getId();
            string rut = this.rutTxt.Text.Trim();
            string nombre = this.nombreTxt.Text.Trim();
            string correo = this.correoTxt.Text.Trim();
            string contrasena = this.contrasenaTxt.Text.Trim();

            // Contruir el Objeto Usuario
            Usuario usuario = new Usuario()
            {
                id = id,
                Rut = rut,
                Nombre = nombre,
                Correo = correo,
                Contrasena = contrasena
            };

            // Guardar Usuario
            usuariosDAL.AgregarUsuario(usuario);

            Response.Redirect("MostrarUsuarios.aspx");
        }

        private int getId()
        {
            // Obtener la hora actual
            DateTime now = DateTime.Now;

            // Obtener la hora, minutos y milisegundos
            int hour = now.Hour;
            int minute = now.Minute;
            int millisecond = now.Millisecond;

            // Combinar la hora, minutos y milisegundos en un número entero (HHMMSS)
            int hourMinuteSecond = (hour * 10000) + (minute * 100) + millisecond;

            return hourMinuteSecond;
        }
    }
}