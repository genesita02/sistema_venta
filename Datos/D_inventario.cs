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

    public class InventarioRepository
    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=paniagua_sistema_ventas;User ID=sa;Password=123456;TrustServerCertificate=True";
        public void SP_GuardarProductoInventario(Inventario inventario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GuardarProductoInventario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", inventario.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", inventario.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", inventario.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", inventario.Precio);
                cmd.Parameters.AddWithValue("@Estado", inventario.Estado);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Inventario> SP_EliminarProductoInventario()
        {
            List<Inventario> inventarioList = new List<Inventario>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarProductoInventario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    inventarioList.Add(new Inventario
                    {
                        IdInventario = (int)reader["id_inventario"],
                        Codigo = (decimal)reader["codigo"],
                        Descripcion = (string)reader["descripcion"],
                        Cantidad = (decimal)reader["cantidad"],
                        Precio = (decimal)reader["precio"],
                        Estado = (string)reader["estado"]
                    });
                }
            }
            return inventarioList;
        }
    }

}
