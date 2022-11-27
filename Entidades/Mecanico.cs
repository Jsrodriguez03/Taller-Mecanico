namespace Entidades
{
    public class Mecanico : Persona
    {
        public Mecanico()
        {

        }

        public Mecanico(string Cedula, string Nombre, string Apellidos, string idMecanico) : base(Cedula, Nombre, Apellidos)
        {
            this.idMecanico = idMecanico;
        }

        public override string ToString()
        {
            return $"{idMecanico};{Cedula};{Nombre};{Apellido}";
        }

        public string idMecanico { get; set; }
    }
}
