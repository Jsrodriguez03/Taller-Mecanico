﻿using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class ListadoAuto : Form
    {
        public ListadoAuto()
        {
            InitializeComponent();
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

        private void ListadoAuto_Load(object sender, EventArgs e)
        {
            //CargarGrilla();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GrillaListadoGeneral.DataSource = RepositorioAutomovil.Buscar(txtBuscar.Text);
        }
    }
}
