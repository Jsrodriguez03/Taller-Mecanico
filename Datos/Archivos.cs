using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class Archivos
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        String ruta1 = "Automoviles.TXT";
        String ruta2 = "Bicicletas.TXT";
        String ruta3 = "Motocicletas.TXT";

        public void Guardar(int opcion, string datos)
        {
            String direccion = "";
            if (opcion == 0)
            {
                direccion = this.ruta1;
            }

            if (opcion == 1)
            {
                direccion = this.ruta2;
            }

            if (opcion == 2)
            {
                direccion = this.ruta3;
            }

            StreamWriter sw = new StreamWriter(direccion, true);
            sw.WriteLine(datos);
            sw.Close();
        }

        
    }
}
