using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteService
    {
        private ClienteRepository clienteRepository = new ClienteRepository();

        public void CreateCliente(Cliente cliente)
        {
            clienteRepository.SP_GuardarCliente(cliente);
        }

        public List<Cliente> SP_EliminarCliente()
        {
            return clienteRepository.SP_EliminarCliente();
        }
    }

}
