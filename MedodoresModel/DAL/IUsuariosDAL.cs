using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedodoresModel.DAL
{
    public interface IUsuariosDAL
    {
        void AgregarUsuario(Usuario usuario);
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int id);
        Usuario ObtenerUsuario(int id);
        List<Usuario> ObtenerUsuarios();
    }
}
