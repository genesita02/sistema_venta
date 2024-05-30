using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetalleFacturaService
    {
        private DetalleFacturaRepository detalleFacturaRepository = new DetalleFacturaRepository();

        public void SP_Guardar_Detalle_Factura(DetalleFactura detalleFactura)
        {
            detalleFacturaRepository.SP_Guardar_Detalle_Factura(detalleFactura);
        }

        public List<DetalleFactura> SP_Listar_Detalles_Factura()
        {
            return detalleFacturaRepository.SP_Listar_Detalles_Factura();
        }
    }

}
