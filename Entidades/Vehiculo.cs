using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }

        public Vehiculo(string Dueño,string Marca, string Color, string Servicio, string Mecanico, string Precio)
        {
            this.Dueño = Dueño;
            this.Marca = Marca;
            this.Color = Color;            
            this.Servicio = Servicio;
            this.Mecanico = Mecanico;
            this.Precio = Precio;
        }

        public override string ToString()
        {
            return $"{Dueño};{Marca};{Color};{Servicio};{Mecanico};{Precio}";
        }

        public string Dueño { get; set; }

        public string Marca { get; set; }

        public string Precio { get; set; }

        public string Color { get; set; }

        public string Servicio { get; set; }

        public string Mecanico { get; set; }
    }
}