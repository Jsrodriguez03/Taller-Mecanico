using Datos;
using Entidades;

namespace Logica
{
    public class ImpMoto
    {
        RepositorioMoto repositorioMoto = new RepositorioMoto();

        public int InsertarMoto(Moto moto)
        {
            int resultado = repositorioMoto.InsertarMotocicleta(moto);
            return resultado;
        }
    }
}
