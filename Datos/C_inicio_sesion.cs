using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace Datos
{
    public class UserRepository : UserRepositoryBase
    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=ususario;Integrated Security=True;TrustServerCertificate=True";
    }
}

