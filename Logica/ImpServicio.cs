using Datos;
using Entidades;

namespace Logica
{
    public class ImpServicio
    {
        RepositorioServicio repositorioServicio = new RepositorioServicio();

        public int Insertar(Servicio servicio)
        {
            int resultado = repositorioServicio.InsertarServicio(servicio);
            return resultado;
        }
    }
}
