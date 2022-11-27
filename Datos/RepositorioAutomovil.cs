using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class RepositorioAutomovil : BaseDatos
    {
        public int InsertarVehiculo(Auto auto)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  auto(Propietario, Marca, Color, Placa) " +
                "values('{0}','{1}','{2}','{3}')", auto.Propietario, auto.Marca, auto.Color, auto.Placa), ObtenerConexion());

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
