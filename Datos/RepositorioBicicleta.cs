using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioBicicleta:BaseDatos
    {
        public int InsertarVehiculo(Bicicleta bici)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  bici(idServicio, Propietario, Marca, Color, Placa) " +
                "values('{0}','{1}','{2}','{3}','{4}')", bici.idSer.IdServicio, bici.Propietario, bici.Marca, bici.Color, bici.Placa), ObtenerConexion());

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
