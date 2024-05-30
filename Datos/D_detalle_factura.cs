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

    public class DetalleFacturaRepository
    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=paniagua_sistema_ventas;User ID=sa;Password=123456;TrustServerCertificate=True";

        public void SP_Guardar_Detalle_Factura(DetalleFactura detalleFactura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Guardar_Detalle_Factura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoArticulo", detalleFactura.CodigoArticulo);
                cmd.Parameters.AddWithValue("@Producto", detalleFactura.Producto);
                cmd.Parameters.AddWithValue("@Descripcion", detalleFactura.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", detalleFactura.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", detalleFactura.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", detalleFactura.Estado);
                cmd.Parameters.AddWithValue("@IdFactura", detalleFactura.IdFactura);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<DetalleFactura> SP_Listar_Detalles_Factura()
        {
            List<DetalleFactura> detallesFactura = new List<DetalleFactura>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Detalles_Factura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    detallesFactura.Add(new DetalleFactura
                    {
                        IdDetalleFactura = (int)reader["id_detalle_factura"],
                        CodigoArticulo = (decimal)reader["codigo_articulo"],
                        Producto = (string)reader["producto"],
                        Descripcion = (string)reader["descripcion"],
                        Precio = (decimal)reader["precio"],
                        Cantidad = (decimal)reader["cantidad"],
                        Estado = (string)reader["estado"],
                        IdFactura = (int)reader["id_factura"]
                    });
                }
            }
            return detallesFactura;
        }
    }

}
