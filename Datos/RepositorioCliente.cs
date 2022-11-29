using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioCliente : BaseDatos
    {
        public int InsertarCliente(Cliente cliente)
        {
            try
            {
                int retorno=0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  cliente(Cedula, Nombre, Apellido, Telefono) " +
                "values('{0}','{1}','{2}','{3}')", cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.Telefono), ObtenerConexion());
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
