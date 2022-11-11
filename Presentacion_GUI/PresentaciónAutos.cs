using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Entidades;
using Logica;
using System.IO;

namespace TALLERM
{
    public partial class PresentaciónAutos : Form
    {
        public PresentaciónAutos()
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
            txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
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

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
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
                txtPlaca.Text == "Ingrese La Placa Del Vehiculo" || dgServicios.Rows[0].Cells[0].Value == null)            
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
            ServiciosAutos serviciosAutos = new ServiciosAutos();
            Auto auto = new Auto();

            auto.Dueño = txtCedu.Text +";"+ txtNom.Text + ";" + txtApe.Text + ";" + txtTel.Text;
            auto.Marca = txtMarca.Text;
            auto.Color = txtColor.Text;
            auto.Placa = txtPlaca.Text;
            auto.Servicio = (string)dgServicios.Rows[0].Cells["descripciónServicios"].Value;
            auto.Mecanico = (string)dgServicios.Rows[0].Cells["Mecanico"].Value;
            auto.Precio = (string)dgServicios.Rows[0].Cells["valor"].Value;

            serviciosAutos.Agregar(auto);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {            
            PresentaciónClientes autos = new PresentaciónClientes();
            this.Hide();
            autos.ShowDialog();
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
                if (txtServicio.Text == "Ajustes del Borner")
                {
                    valor = "15700";
                }
                else
                {
                    if (txtServicio.Text == "Ajustes del Motor")
                    {
                        valor = "530000";
                    }
                    else
                    {
                        if (txtServicio.Text == "Ajuste del tiempo de encendido")
                        {
                            valor = "23200";
                        }
                        else
                        {
                            if (txtServicio.Text == "Limpieza o Cambio del filtro de aire")
                            {
                                valor = "152000";
                            }
                            else
                            {
                                if (txtServicio.Text == "Limpieza o Cambio  de gasolina")
                                {
                                    valor = "150000";
                                }
                                else
                                {
                                    if (txtServicio.Text == "Limpieza o Cambio de las bujías")
                                    {
                                        valor = "150000";
                                    }
                                    else
                                    {
                                        if (txtServicio.Text == "Nivelación de batería")
                                        {
                                            valor = "15000";
                                        }
                                        else
                                        {
                                            if (txtServicio.Text == "Pintar")
                                            {
                                                valor = "54000";
                                            }
                                            else
                                            {
                                                if (txtServicio.Text == "Pinchazos")
                                                {
                                                    valor = "35000";
                                                }
                                                else
                                                {
                                                    if (txtServicio.Text == "Reparación de clutch")
                                                    {
                                                        valor = "110000";
                                                    }
                                                    else
                                                    {
                                                        if (txtServicio.Text == "Reparación de Frenos")
                                                        {
                                                            valor = "20000";
                                                        }
                                                        else
                                                        {
                                                            if (txtServicio.Text == "Reparación de luces")
                                                            {
                                                                valor = "18700";
                                                            }
                                                            else
                                                            {
                                                                if (txtServicio.Text == "Cambio de Aceite y Filtro")
                                                                {
                                                                    valor = "13000";
                                                                }
                                                                else
                                                                {
                                                                    valor = "38000";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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
            Precio.Text = Total.ToString()+"$";
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

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
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

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
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

        private void txtPlaca_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "Ingrese La Placa Del Vehiculo")
            {
                txtPlaca.Text = "";
            }

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

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }
        }

        private void txtServicio_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

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
            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

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

        private void PresentaciónAutos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            String ruta1 = "Automoviles.TXT";
            StreamReader sr = new StreamReader(ruta1);
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