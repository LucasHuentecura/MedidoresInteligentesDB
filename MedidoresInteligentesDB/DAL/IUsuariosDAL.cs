using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedidoresInteligentesDB.DAL
{
    public interface IUsuariosDAL
    {
        void AgregarUsuario(Usuario usuario);
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
        List<Usuario> ObtenerUsuarios();
    }
}