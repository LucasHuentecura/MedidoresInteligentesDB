using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {
        private MEDIDORDBEntities medidoresDB = new MEDIDORDBEntities();

        public void AgregarUsuario(Usuario usuario)
        {
            this.medidoresDB.Usuarios.Add(usuario);
            this.medidoresDB.SaveChanges();
        }

        public void ActualizarUsuario(Usuario usuario)
        {

        }

        public void EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
