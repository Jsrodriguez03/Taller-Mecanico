using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace TALLERM
{
    public partial class ServiciosAutos : Form
    {
        DatosClientes datosClientes = new DatosClientes();

        public ServiciosAutos()
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
                LimpiarCajas();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DatosClientes().ShowDialog();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text != "Seleccionar" && txtMecanico.Text != "Seleccionar")
            {
                float valor = 0;
                if (txtServicio.Text == "Ajustes del Borner")
                {
                    valor = 15700;
                }
                else
                {
                    if (txtServicio.Text == "Ajustes del Motor")
                    {
                        valor = 530000;
                    }
                    else
                    {
                        if (txtServicio.Text == "Ajuste del tiempo de encendido")
                        {
                            valor = 23200;
                        }
                        else
                        {
                            if (txtServicio.Text == "Limpieza o Cambio del filtro de aire")
                            {
                                valor = 152000;
                            }
                            else
                            {
                                if (txtServicio.Text == "Limpieza o Cambio  de gasolina")
                                {
                                    valor = 150000;
                                }
                                else
                                {
                                    if (txtServicio.Text == "Limpieza o Cambio de las bujías")
                                    {
                                        valor = 26900;
                                    }
                                    else
                                    {
                                        if (txtServicio.Text == "Nivelación de batería")
                                        {
                                            valor = 15000;
                                        }
                                        else
                                        {
                                            if (txtServicio.Text == "Pintar")
                                            {
                                                valor = 54000;
                                            }
                                            else
                                            {
                                                if (txtServicio.Text == "Pinchazos")
                                                {
                                                    valor = 35000;
                                                }
                                                else
                                                {
                                                    if (txtServicio.Text == "Reparación de clutch")
                                                    {
                                                        valor = 110000;
                                                    }
                                                    else
                                                    {
                                                        if (txtServicio.Text == "Reparación de Frenos")
                                                        {
                                                            valor = 20000;
                                                        }
                                                        else
                                                        {
                                                            if (txtServicio.Text == "Reparación de luces")
                                                            {
                                                                valor = 18700;
                                                            }
                                                            else
                                                            {
                                                                if (txtServicio.Text == "Cambio de Aceite y Filtro")
                                                                {
                                                                    valor = 13000;
                                                                }
                                                                else
                                                                {
                                                                    valor = 38000;
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

                dgServicios.Rows.Add(txtServicio.Text, txtMecanico.Text,valor);
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
                Total += Convert.ToDecimal(row.Cells["Column3"].Value);
            }
            Precio.Text = Total.ToString()+"$";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFila();
        }
        public void EliminarFila()
        {
            //foreach (DataGridViewRow row in dgServicios.Rows)
            //{
            //    if (row.Cells[0].Value != null)
            //    {
            //        dgServicios.Rows.Remove(dgServicios.CurrentRow);
            //        //dgServicios.Rows.Remove(dgServicios.CurrentRow.Index);
            //        PrecioTotal();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No Hay Fila Seleccionada");
            //    }
            //}
        }

        
    }
}