using System;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace TALLERM
{
    public partial class PresentaciónBicicleta : Form
    {
        public PresentaciónBicicleta()
        {
            InitializeComponent();
            txtServicio.Text = "Seleccionar";
            txtServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMecanico.Text = "Seleccionar";
            txtMecanico.DropDownStyle = ComboBoxStyle.DropDownList;
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
            if (txtMarca.Text == "Ingrese La Marca Del Vehiculo" || txtColor.Text == "Ingrese El Color Del Vehiculo" ||
                dgServicios.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
            }
            else
            {
                MessageBox.Show("¡DATOS GUARDADOS EXITOSAMENTE!");
                Guardar();
                LimpiarCajas();
                LimpiarTabla();
            }
        }

        public void LimpiarTabla()
        {
            dgServicios.Rows.Clear();
            PrecioTotal();
        }

        public void Guardar()
        {
            ServiciosBicicletas serviciosBicicletas = new ServiciosBicicletas();
            Bicicleta bici = new Bicicleta();

            bici.Dueño = txtCedu.Text + ";" + txtNom.Text + ";" + txtApe.Text + ";" + txtTel.Text;
            bici.Marca = txtMarca.Text;
            bici.Color = txtColor.Text;
            bici.Servicio = (string)dgServicios.Rows[0].Cells["descripciónServicios"].Value;
            bici.Mecanico = (string)dgServicios.Rows[0].Cells["Mecanico"].Value;
            bici.Precio = (string)dgServicios.Rows[0].Cells["valor"].Value;

            serviciosBicicletas.Agregar(bici);
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            PresentaciónClientes bicis = new PresentaciónClientes();
            this.Hide();
            bicis.ShowDialog();
            this.Close();
        }
        
        private void PestañaVehiculos_Click(object sender, EventArgs e)
        {
            InicializarCajas();
        }        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text != "Seleccionar" && txtMecanico.Text != "Seleccionar")
            {
                string valor = "";
                if (txtServicio.Text == "Lavado")
                {
                    valor = "15000";
                }
                else
                {
                    if (txtServicio.Text == "Mantenimiento")
                    {
                        valor = "150000";
                    }
                    else
                    {
                        if (txtServicio.Text == "Pinchazo")
                        {
                            valor = "1300";
                        }
                        else
                        {
                            valor = "211000";
                        }
                    }
                }

                dgServicios.Rows.Add(txtServicio.Text, txtMecanico.Text, valor);
                PrecioTotal();
                txtServicio.Text = "Seleccionar";
                txtMecanico.Text = "Seleccionar";
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
                Total += Convert.ToDecimal(row.Cells["valor"].Value);
            }
            Precio.Text = Total.ToString() + "$";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }

        public void EliminarFila()
        {
            foreach (DataGridViewRow row in dgServicios.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    //dgServicios.Rows.Remove(dgServicios.CurrentRow);
                    dgServicios.Rows.RemoveAt(dgServicios.CurrentRow.Index);
                    PrecioTotal();
                    break;
                }
                else
                {
                    MessageBox.Show("No Hay Fila Seleccionada");
                }
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir?", "         T A L L E R      M E C Á N I C O", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PresentaciónBicicleta_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            String ruta2 = "Bicicletas.TXT";
            StreamReader sr = new StreamReader(ruta2);
            string line = sr.ReadLine();
            while (line != null)
            {
                String[] info = line.Split(';');
                GrillaListadoGeneral.Rows.Add(info);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}