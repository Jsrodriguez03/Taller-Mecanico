using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioServicio:BaseDatos
    {
        public int InsertarServicio(Servicio servicio)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  servicio(IdServicio, NombreServicio, " +
                    "IdMecanico, Precio) values('{0}','{1}','{2}','{3}')", servicio.IdServicio, servicio.NombreServicio,
                    servicio.idMecanico.idMecanico, servicio.Precio), ObtenerConexion());

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
