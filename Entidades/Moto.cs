using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto()
        {

        }

        public Moto(string Dueño, string Marca, string Color, string Placa, string Servicio, string Mecanico, string Precio):base(Dueño, Marca, Color, Servicio, Mecanico, Precio)
        {
            this.Placa = Placa;
        }

        public override string ToString()
        {
            return $"{Dueño};{Marca};{Color};{Placa};{Servicio};{Precio};{Precio}";
        }

        public string Placa { get; set; }
    }
}