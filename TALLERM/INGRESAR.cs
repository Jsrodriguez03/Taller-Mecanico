using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALLERM
{
    public partial class INGRESAR : Form
    {
        public INGRESAR()
        {
            InitializeComponent();
            txtTipo.Text = "Seleccionar";
            panelDatosVehiculo.Enabled = false;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            txtTipo.Text = "Seleccionar";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtPlaca.Text = "";
            txtPrecio.Text = "";
            txtServicio.Text = "";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            VerificarCajas();
        }

        public void VerificarCajas()
        {
            if (txtTipo.Text == "Seleccionar" && txtMarca.Text == "" && txtColor.Text == ""
                && txtPlaca.Text == "" && txtPrecio.Text == "" && txtServicio.Text == "")
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
            }
            else
            {
                MessageBox.Show("¡DATOS GUARDADOS EXITOSAMENTE!");
                LimpiarCajas();
            }
        }

        private void txtTipo_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTipo.Text != "Seleccionar")
            {
                panelDatosVehiculo.Enabled = true;
                if (txtTipo.Text != "Bicicleta")
                {
                    txtPlaca.Enabled = true;
                }
                else
                {
                    txtPlaca.Enabled = false;
                }
            }
            else
            {
                panelDatosVehiculo.Enabled = false;
            }
        }
    }
}