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
    }
}
