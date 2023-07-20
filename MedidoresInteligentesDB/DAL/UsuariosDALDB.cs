using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedidoresInteligentesDB.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {
        private MEDIDORDBEntities medidoresDB = new MEDIDORDBEntities();

        public void AgregarUsuario(Usuario usuario)
        {
            this.medidoresDB.Usuarios.Add(usuario);
            this.medidoresDB.SaveChanges();
        }

    }
}