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
    public partial class DatosClientes : Form
    {
        public DatosClientes()
        {
            InitializeComponent();
            
        
        }

        public void VerificarCajas()
        {
            if (txtcedula.Text == "" && txtNombre.Text == "" && txtApellido.Text == ""
                && txtTelefono.Text == "" && txtnom.Text == "" && txtApe.Text == "" && txtCargo.Text == "" && txtcedu.Text == "")
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
            }
            else
            {
                MessageBox.Show("¡DATOS GUARDADOS EXITOSAMENTE!");
                LimpiarCajas();
            }
        }

        private void txtcedula_Click(object sender, EventArgs e)
        {
            txtcedula.Text = "";

         }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";

        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
        }

        private void txtcedu_Click(object sender, EventArgs e)
        {
            txtcedu.Text = "";
        }

        private void txtnom_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
        }

        private void txtApe_Click(object sender, EventArgs e)
        {
            txtApe.Text = "";
        }

        private void txtCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
        }

        private void boxLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
        public void LimpiarCajas()
        {
            txtcedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtnom.Text = "";
            txtcedu.Text = "";
            txtApe.Text = "";
            txtCargo.Text = "";
        }

        private void boxServicios_Click(object sender, EventArgs e)
        {
            VerificarCajas();
        }
    }
}
