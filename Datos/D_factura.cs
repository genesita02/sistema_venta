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
    public class FacturaRepository
    {
        private string connectionString = @"Data Source=CHERRYY-E5440;Initial Catalog=paniagua_sistema_ventas;User ID=sa;Password=123456;TrustServerCertificate=True";

        public void SP_Guardar_Factura(Factura factura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Guardar_Factura", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                cmd.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                cmd.Parameters.AddWithValue("@Total", factura.Total);
                cmd.Parameters.AddWithValue("@Itbis", factura.Itbis);
                cmd.Parameters.AddWithValue("@Precio", factura.Precio);
                cmd.Parameters.AddWithValue("@CodigoProducto", factura.CodigoProducto);
                cmd.Parameters.AddWithValue("@Producto", factura.Producto);
                cmd.Parameters.AddWithValue("@NombreCliente", factura.NombreCliente);
                cmd.Parameters.AddWithValue("@NumIdentidad", factura.NumIdentidad);
                cmd.Parameters.AddWithValue("@RNC", factura.RNC);
                cmd.Parameters.AddWithValue("@Estado", factura.Estado);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Factura> SP_Listar_Facturas()
        {
            List<Factura> facturas = new List<Factura>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Facturas", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    facturas.Add(new Factura
                    {
                        IdFactura = (int)reader["id_factura"],
                        Cantidad = (decimal)reader["cantidad"],
                        Descripcion = (string)reader["descripcion"],
                        Total = (decimal)reader["total"],
                        Itbis = (decimal)reader["itbis"],
                        Precio = (decimal)reader["precio"],
                        CodigoProducto = (decimal)reader["codigo_producto"],
                        Producto = (string)reader["producto"],
                        NombreCliente = (string)reader["nombre_cliente"],
                        NumIdentidad = (decimal)reader["num_identidad"],
                        RNC = (decimal)reader["RNC"],
                        Estado = (string)reader["estado"]
                    });
                }
            }
            return facturas;
        }
    }

}
