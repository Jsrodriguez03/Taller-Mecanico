using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Logica
{
    public class ServiciosAutos : ImpServicioAutos
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        Archivos txt = new Archivos();

        public void Agregar(Vehiculo vehiculo)
        {
            txt.Guardar(0, vehiculo.ToString()) ;
            vehiculos.Add(vehiculo);
        }

        public void Eliminar()
        {

        }

        public void Modificar()
        {

        }
        
        public void Buscar()
        {

        }

        public void Mostrar()
        {

        }

    }
}
