using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UserService
    {
        private UserRepository IngresarAlSistema = new UserRepository();

        public bool ValidateUser(string usuario, string contraseña)
        {
            Usuario user = IngresarAlSistema.IngresarAlSistema(usuario, contraseña);
            return user != null;
        }
    }
}
