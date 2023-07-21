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

        public void ActualizarUsuario(Usuario usuario)
        {
            Usuario uOriginal = this.medidoresDB.Usuarios.Find(usuario.id);
            uOriginal.Nombre = usuario.Nombre;
            uOriginal.Rut = usuario.Rut;
            uOriginal.Correo = usuario.Correo;
            uOriginal.Contrasena = usuario.Contrasena;
            this.medidoresDB.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            Usuario usuario = this.medidoresDB.Usuarios.Find(id);
            this.medidoresDB.Usuarios.Remove(usuario);
            this.medidoresDB.SaveChanges();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            //LINQ
            var query = from u in this.medidoresDB.Usuarios select u;
            return query.ToList();
        }
    }
}