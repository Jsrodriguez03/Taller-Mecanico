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

        //public void leerDatos(int opcion)
        //{
        //    String line;

        //    try
        //    {
        //        String direccion = "";
        //        if (opcion == 0)
        //        {
        //            direccion = this.ruta1;
        //        }

        //        if (opcion == 1)
        //        {
        //            direccion = this.ruta2;
        //        }

        //        if (opcion == 2)
        //        {
        //            direccion = this.ruta3;
        //        }

        //        StreamReader sr = new StreamReader(direccion, true);
        //        line = sr.ReadLine();
        //        int i = 1;
        //        while (!(sr.EndOfStream))
        //        {
        //            String[] info = line.Split(';');
        //            dg


        //            Console.WriteLine($"-------------- Contacto {i} --------------");
        //            Console.WriteLine($"ID: {info[0]}");
        //            Console.WriteLine($"NOMBRE: {info[1]}");
        //            Console.WriteLine($"TELEFONO: {info[2]}");

        //            if (opcion == 0)
        //            {
        //                Console.WriteLine($"FECHA DE NACIMIENTO: {info[3]}");
        //            }

        //            if (opcion == 1)
        //            {
        //                Console.WriteLine($"NIT: {info[3]}");
        //                Console.WriteLine($"RAZON SOCIAL: {info[4]}");
        //                Console.WriteLine($"CORREO: {info[5]}");
        //            }

        //            line = sr.ReadLine();
        //            i++;
        //        }
        //        sr.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception: " + e.Message);
        //    }
        //}


        //public void vaciar()
        //{
        //    StreamWriter sw = new StreamWriter(ruta, false);
        //    sw.Write("");
        //    sw.Close();
        //}
    }
}
