namespace Entidades
{
    public class Vehiculo
    {
        public string Propietario { get; set; }

        public string Marca { get; set; }

        public string Color { get; set; }

        public Servicio idSer { get; set; }

        //public Vehiculo(Servicio idSer, string Propietario, string Marca, string Color)
        //{
        //    this.idSer = idSer;
        //    this.Propietario = Propietario;
        //    this.Marca = Marca;
        //    this.Color = Color;

        //}

        public override string ToString()
        {
            return $"{idSer.IdServicio};{Propietario};{Marca};{Color}";
        }

        

    }
}