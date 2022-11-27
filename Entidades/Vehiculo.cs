namespace Entidades
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }

        public Vehiculo(string Propietario, string Marca, string Color)
        {
            this.Propietario = Propietario;
            this.Marca = Marca;
            this.Color = Color;

        }

        public override string ToString()
        {
            return $"{Propietario};{Marca};{Color}";
        }

        public string Propietario { get; set; }

        public string Marca { get; set; }

        public string Color { get; set; }

    }
}