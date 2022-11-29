using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioBicicleta:BaseDatos
    {
        public int InsertarBicicleta(Bicicleta bici)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  bicicleta(idServicio, Propietario, Marca, Color) " +
                "values('{0}','{1}','{2}','{3}')", bici.idSer.IdServicio, bici.Propietario, bici.Marca, bici.Color), ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
