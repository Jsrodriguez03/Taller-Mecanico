using Datos;
using Entidades;

namespace Logica
{
    public class ImpAutomovil
    {
        RepositorioAutomovil repositorioAutomovil = new RepositorioAutomovil();

        public int Insertar(Auto auto)
        {
            int resultado = repositorioAutomovil.InsertarVehiculo(auto);
            return resultado;
        }
    }
}
