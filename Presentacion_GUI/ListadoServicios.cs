using Datos;
using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class ListadoServicios : Form
    {
        public ListadoServicios()
        {
            InitializeComponent();
        }

        private void ListadoServicios_Load(object sender, EventArgs e)
        {
            GrillaServicio.DataSource = RepositorioServicio.Buscar(txtBus.Text);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
