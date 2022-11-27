using MySql.Data.MySqlClient;

namespace Datos
{
    public class BaseDatos
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server = 127.0.0.1; database = Taller; Uid = root; pwd = santiish;");
            conectar.Open();
            return conectar;
        }

    }
}
