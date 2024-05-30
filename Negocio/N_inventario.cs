using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class InventarioService
    {
        private InventarioRepository inventarioRepository = new InventarioRepository();

        public void SP_GuardarProductoInventario(Inventario inventario)
        {
            inventarioRepository.SP_GuardarProductoInventario(inventario);
        }

        public List<Inventario> SP_EliminarProductoInventario()
        {
            return inventarioRepository.SP_EliminarProductoInventario();
        }
    }

}
