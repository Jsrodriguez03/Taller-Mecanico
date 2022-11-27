namespace Entidades
{
    public class Moto : Vehiculo
    {
        public Moto()
        {

        }

        public Moto(string Propietario, string Marca, string Color, string Placa) : base(Propietario, Marca, Color)
        {
            this.Placa = Placa;
        }

        public override string ToString()
        {
            return $"{Propietario};{Marca};{Color};{Placa}";
        }

        public string Placa { get; set; }
    }
}