using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Total { get; set; }
        public decimal Itbis { get; set; }
        public decimal Precio { get; set; }
        public decimal CodigoProducto { get; set; }
        public string Producto { get; set; }
        public string NombreCliente { get; set; }
        public decimal NumIdentidad { get; set; }
        public decimal RNC { get; set; }
        public string Estado { get; set; }
    }
}
