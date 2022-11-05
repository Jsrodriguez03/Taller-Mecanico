using System;
using System.Windows.Forms;

namespace TALLERM
{
    public partial class ServiciosBicicleta : Form
    {
        public ServiciosBicicleta()
        {
            InitializeComponent();
            txtServicio.Text = "Seleccionar";
            txtServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMecanico.Text = "Seleccionar";
            txtMecanico.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new DatosClientes().ShowDialog();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            txtServicio.Text = "Seleccionar";
            txtMecanico.Text = "Seleccionar";
            txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            txtColor.Text = "Ingrese El Color Del Vehiculo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InicializarCajas();
            VerificarCajas();
        }

        public void InicializarCajas()
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtServicio.Text == "")
            {
                txtServicio.Text = "Seleccionar";
            }

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }
        }

        public void VerificarCajas()
        {
            if (txtServicio.Text == "Seleccionar" || txtMarca.Text == "Ingrese La Marca Del Vehiculo" ||
                txtColor.Text == "Ingrese El Color Del Vehiculo" || txtMecanico.Text == "Seleccionar")
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
            }
            else
            {
                MessageBox.Show("¡DATOS GUARDADOS EXITOSAMENTE!");
                LimpiarCajas();
            }
        }

        private void PestañaVehiculos_Click(object sender, EventArgs e)
        {
            InicializarCajas();
        }

        //Eventos De Verificación de Cajas
        private void txtMarca_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Ingrese La Marca Del Vehiculo")
            {
                txtMarca.Text = "";
            }

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtServicio.Text == "")
            {
                txtServicio.Text = "Seleccionar";
            }

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }
        }

        private void txtColor_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "Ingrese El Color Del Vehiculo")
            {
                txtColor.Text = "";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (txtServicio.Text == "")
            {
                txtServicio.Text = "Seleccionar";
            }

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }
        }

        private void txtServicio_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }
        }

        private void txtMecanico_Click(object sender, EventArgs e)
        {

            if (txtColor.Text == "")
            {
                txtColor.Text = "Ingrese El Color Del Vehiculo";
            }

            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            }

            if (txtServicio.Text == "")
            {
                txtServicio.Text = "Seleccionar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text != "Seleccionar" && txtMecanico.Text != "Seleccionar")
            {
                float valor = 0;
                if (txtServicio.Text == "Lavado")
                {
                    valor = 15000;
                }
                else
                {
                    if (txtServicio.Text == "Mantenimiento")
                    {
                        valor = 150000;
                    }
                    else
                    {
                        if (txtServicio.Text == "Pinchazo")
                        {
                            valor = 1300;
                        }
                        else
                        {
                            valor = 211000;
                        }
                    }
                }

                dgServicios.Rows.Add(txtServicio.Text, txtMecanico.Text, valor);
                PrecioTotal();
                LimpiarCajas();
            }
            else
            {
                MessageBox.Show("Por Favor Complete Todos Los Campos.");
            }
        }

        public void PrecioTotal()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dgServicios.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["Column3"].Value);
            }
            Precio.Text = Total.ToString() + "$";

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgServicios.Rows.RemoveAt(dgServicios.CurrentCell.RowIndex);
            PrecioTotal();
            //FALTA QUE NO ELIMINEEEEEEEE CUANDO ESTÁ VACÍAAAAAAAAAAAA
            //int fila = dgServicios.CurrentCell.RowIndex;
            //if (fila == -1)
            //{
            //    MessageBox.Show("No Hay Fila Seleccionada");
            //}
            //else
            //{
            //    dgServicios.Rows.RemoveAt(dgServicios.CurrentCell.RowIndex);

            //}
        }
    }
}
