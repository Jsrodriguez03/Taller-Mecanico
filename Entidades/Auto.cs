namespace Entidades
{
    public class Auto : Vehiculo
    {
        public Auto()
        {

        }

        public Auto(string Propietario, string Marca, string Color, string Placa) : base(Propietario, Marca, Color)
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