using Datos;
using Entidades;

namespace Logica
{
    public class ImpCliente
    {
        RepositorioCliente repositorioCliente = new RepositorioCliente();

        public int Insertar(Cliente cliente)
        {
            int resultado = repositorioCliente.InsertarCliente(cliente);            
            return resultado;
        }

        public int InsertarClienteBici(Cliente cliente)
        {
            int resultado = repositorioCliente.InsertarClienteBicicleta(cliente);
            return resultado;
        }

        public int InsertarClienteMoto(Cliente cliente)
        {
            int resultado = repositorioCliente.InsertarClienteMotocicleta(cliente);
            return resultado;
        }
    }
}
