using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

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

        public static List<Auto> Buscar(string idS)
        {
            List<Auto> _lista = new List<Auto>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT idServicio, Propietario, " +
                "Marca, Color, Placa FROM auto " +
                "where Color = '{0}'", idS), BaseDatos.ObtenerConexion());


            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Auto auto = new Auto();
                auto.Propietario = _reader.GetString(0);
                auto.Propietario = _reader.GetString(1);
                auto.Marca = _reader.GetString(2);
                auto.Color = _reader.GetString(3);
                auto.Placa = _reader.GetString(4);
                _lista.Add(auto);
            }

            return _lista;
        }

    }
}
