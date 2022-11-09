using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta()
        {

        }

        public Bicicleta(string Dueño, string Marca, string Color, string Servicio, string Mecanico, string Precio):base(Dueño, Marca, Color, Servicio, Mecanico, Precio)
        {

        }

        public override string ToString()
        {
            return $"{Dueño};{Marca};{Color};{Servicio};{Mecanico};{Precio}";
        }
    }
}