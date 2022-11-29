using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioAutomovil : BaseDatos
    {
        public int InsertarVehiculo(Auto auto)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  auto(idServicio, Propietario, Marca, Color, Placa) " +
                "values('{0}','{1}','{2}','{3}','{4}')", auto.idSer.IdServicio, auto.Propietario, auto.Marca, auto.Color, auto.Placa), ObtenerConexion());

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
