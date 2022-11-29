using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioMoto:BaseDatos
    {
        public int InsertarMotocicleta(Moto moto)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  moto(idServicio, Propietario, Marca, Color, Placa) " +
                "values('{0}','{1}','{2}','{3}','{4}')", moto.idSer.IdServicio, moto.Propietario, moto.Marca, moto.Color, moto.Placa), ObtenerConexion());

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
