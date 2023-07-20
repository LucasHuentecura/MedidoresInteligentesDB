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
            int id = 1;
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

        }
    }
}