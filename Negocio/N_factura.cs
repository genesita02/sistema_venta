using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class FacturaService
    {
        private FacturaRepository facturaRepository = new FacturaRepository();

        public void SP_Guardar_Factura(Factura factura)
        {
            facturaRepository.SP_Guardar_Factura(factura);
        }

       
        public List<Factura> SP_Listar_Facturas()
        {
            return facturaRepository.SP_Listar_Facturas();
        }
    }
}
