using Datos;
using Entidades;

namespace Logica
{
    public class ImpMoto
    {
        RepositorioMoto repositorioMoto = new RepositorioMoto();

        public int Insertar(Moto moto)
        {
            int resultado = repositorioMoto.InsertarMoto(moto);
            return resultado;
        }
    }
}
