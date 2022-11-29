using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class ListadoAuto : Form
    {
        public ListadoAuto()
        {
            InitializeComponent();
        }
        

        private void ListadoAuto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            MySqlConnection conexion = BaseDatos.ObtenerConexion();

            string consulta = "SELECT c.Cedula, c.Nombre, c.Apellido, c.Telefono, a.idServicio, a.Marca, a.Color, a.Placa FROM cliente c " +
                "JOIN auto a WHERE c.idCliente = a.idCliente";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);

            DataTable dt = new DataTable();

            adaptador.Fill(dt);
            GrillaListadoGeneral.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }  

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentaciónPrincipal pPal = new PresentaciónPrincipal();
            this.Hide();
            pPal.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                ListadoServicios lser = new ListadoServicios();
                lser.txtBus.Text = txtBuscar.Text;
                lser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Digite El Servicio A Buscar");
            }
        }
    }
}
