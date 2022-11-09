using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        public Auto()
        {

        }

        public Auto(string Dueño,string Marca, string Color, string Servicio, string Mecanico, string Precio, string Placa) : base(Dueño, Marca, Color, Servicio, Mecanico, Precio)
        {
            this.Placa = Placa;
        }

        public override string ToString()
        {
            return $"{Dueño};{Marca};{Color};{Placa};{Servicio};{Mecanico};{Precio}";
        }

        public string Placa { get; set; }
    }
}