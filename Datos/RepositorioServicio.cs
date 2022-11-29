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

        public int InsertarServicioBicicleta(Servicio servicio)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  serviciobicicleta(IdServicio, NombreServicio, " +
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

        public int InsertarServicioMotocicleta(Servicio servicio)
        {
            try
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into  serviciomoto(IdServicio, NombreServicio, " +
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

        public static List<Servicio> Buscar(string nombre)
        {
            List<Servicio> _lista = new List<Servicio>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT s.IdServicio, s.NombreServicio, s.Precio, " +
                "concat(m.NombreMecanico, ' ', m.ApellidoMecanico)" +
                " FROM mecanico m JOIN servicio s ON s.IdMecanico=m.IdMecanico " +
                "where idServicio = '{0}'", nombre), BaseDatos.ObtenerConexion());


            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Servicio servicio = new Servicio();
                servicio.IdServicio = _reader.GetString(0);
                servicio.NombreServicio = _reader.GetString(1);
                servicio.Precio = _reader.GetDouble(2);
                servicio.IdServicio = _reader.GetString(3);


                _lista.Add(servicio);
            }

            return _lista;
        }

        public static List<Servicio> BuscarBici(string nombre)
        {
            List<Servicio> _lista = new List<Servicio>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT s.IdServicio, s.NombreServicio, s.Precio, " +
                "concat(m.NombreMecanico, ' ', m.ApellidoMecanico)" +
                " FROM mecanico m JOIN serviciobicicleta s ON s.IdMecanico=m.IdMecanico " +
                "where idServicio = '{0}'", nombre), BaseDatos.ObtenerConexion());


            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Servicio servicio = new Servicio();
                servicio.IdServicio = _reader.GetString(0);
                servicio.NombreServicio = _reader.GetString(1);
                servicio.Precio = _reader.GetDouble(2);
                servicio.IdServicio = _reader.GetString(3);

                _lista.Add(servicio);
            }

            return _lista;
        }
    }
}
