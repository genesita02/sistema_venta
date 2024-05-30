using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public decimal CodigoArticulo { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
        public int IdFactura { get; set; }
    }

}
