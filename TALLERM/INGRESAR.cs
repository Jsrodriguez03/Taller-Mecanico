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
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

       
        private void boxLimpiar_Click(object sender, EventArgs e)
        {

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
            txtTelefono.Text = " ";
        }

        private void txtcedu_Click(object sender, EventArgs e)
        {
            txtcedu.Text = " ";
        }

        private void txtnom_Click(object sender, EventArgs e)
        {
            txtnom.Text = " ";
        }

        private void txtApe_Click(object sender, EventArgs e)
        {
            txtApe.Text = "";
        }

        private void txtCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
        }
    }
}