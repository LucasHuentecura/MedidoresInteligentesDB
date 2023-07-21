using MedidoresInteligentesDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresInteligentesDB
{
    public partial class MostrarUsuarios : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla(this.usuariosDAL.ObtenerUsuarios());
            }
        }

        private void cargarGrilla(List<Usuario> usuarios)
        {
            this.grillaUsuario.DataSource = usuarios;
            this.grillaUsuario.DataBind();
        }
    }
}