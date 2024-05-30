using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class ClienteRepository
    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=paniagua_sistema_ventas;User ID=sa;Password=123456;TrustServerCertificate=True";

        public void SP_GuardarCliente(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GuardarCliente", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@NumIdentidad", cliente.NumIdentidad);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Cliente> SP_EliminarCliente()
        {
            List<Cliente> clienteList = new List<Cliente>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarCliente", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clienteList.Add(new Cliente
                    {
                        IdCliente = (int)reader["id_cliente"],
                        Nombre = (string)reader["nombre"],
                        Apellido = (string)reader["apellido"],
                        NumIdentidad = (decimal)reader["num_identidad"],
                        Estado = (string)reader["estado"]
                    });
                }
            }
            return clienteList;
        }
    }

}
