namespace Entidades
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta()
        {

        }

        public Bicicleta(string Propietario, string Marca, string Color) : base(Propietario, Marca, Color)
        {

        }

        public override string ToString()
        {
            return $"{Propietario};{Marca};{Color}";
        }
    }
}