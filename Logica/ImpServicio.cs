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

        public int InsertarServicioBici(Servicio servicio)
        {
            int resultado = repositorioServicio.InsertarServicioBicicleta(servicio);
            return resultado;
        }

        public int InsertarServicioMoto(Servicio servicio)
        {
            int resultado = repositorioServicio.InsertarServicioMotocicleta(servicio);
            return resultado;
        }
    }
}
