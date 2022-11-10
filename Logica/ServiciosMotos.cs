using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class ServiciosMotos : ImpServicioMotos
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        Archivos txt = new Archivos();

        public void Agregar(Vehiculo vehiculo)
        {
            txt.Guardar(2, vehiculo.ToString());
            vehiculos.Add(vehiculo);
        }
    }
}
