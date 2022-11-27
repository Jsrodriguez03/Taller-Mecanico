using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TALLERM
{
    public partial class PresentaciónMotos : Form
    {
        public PresentaciónMotos()
        {
            InitializeComponent();
            boxServicio.Text = "Seleccionar";
            boxServicio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            boxServicio.Text = "Seleccionar";
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

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
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
                //Guardar();
                LimpiarCajas();
                LimpiarTabla();
            }            
        }

        public void LimpiarTabla()
        {
            dgServicios.Rows.Clear();
            PrecioTotal();
        }

        //public void Guardar()
        //{
        //    ServiciosMotos serviciosMotos = new ServiciosMotos();
        //    Moto moto = new Moto();

        //    moto.Propietario = txtCedu.Text + ";" + txtNom.Text + ";" + txtApe.Text + ";" + txtTel.Text;
        //    moto.Marca = txtMarca.Text;
        //    moto.Color = txtColor.Text;
        //    moto.Placa = txtPlaca.Text;
        //    //moto.Servicio = (string)dgServicios.Rows[0].Cells["descripciónServicios"].Value;
        //    //moto.Mecanico = (string)dgServicios.Rows[0].Cells["Responsable"].Value;
        //    //moto.Precio = (string)dgServicios.Rows[0].Cells["valor"].Value;

        //    serviciosMotos.Agregar(moto);
        //}

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            PresentaciónClientes bici = new PresentaciónClientes();
            this.Hide();
            bici.ShowDialog();
            this.Close();
        }

        private void PestañaVehiculos_Click(object sender, EventArgs e)
        {
            InicializarCajas();
        }        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (boxServicio.Text != "Seleccionar" && txtMecanico.Text != "Seleccionar")
            {
                string valor = "";
                if (boxServicio.Text == "Ajuste del Nivel de la suspensión")
                {
                    valor = "15700";
                }
                else
                {
                    if (boxServicio.Text == "Cambio de Aceite")
                    {
                        valor = "23000";
                    }
                    else
                    {
                        if (boxServicio.Text == "Lavado General")
                        {
                            valor = "530000";
                        }
                        else
                        {
                            if (boxServicio.Text == "Limpieza de filtros")
                            {
                                valor = "152000";
                            }
                            else
                            {
                                if (boxServicio.Text == "Mantenimiento de frenos")
                                {
                                    valor = "150000";
                                }
                                else
                                {
                                    if (boxServicio.Text == "Regulación del Anticongelante")
                                    {
                                        valor = "26900";
                                    }
                                    else
                                    {
                                        if (boxServicio.Text == "Revisión de Cadena")
                                        {
                                            valor = "15000";
                                        }
                                        else
                                        {
                                            if (boxServicio.Text == "Revisión de Frenos")
                                            {
                                                valor = "54000";
                                            }
                                            else
                                            {
                                                if (boxServicio.Text == "Revisión de la Batería")
                                                {
                                                    valor = "35000";
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
                
                dgServicios.Rows.Add(boxServicio.Text, txtMecanico.Text, valor);
                PrecioTotal();
                boxServicio.Text = "Seleccionar";
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

            if (txtPlaca.Text == "")
            {
                txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            }

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
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

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
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

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
            }

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
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

            if (boxServicio.Text == "")
            {
                boxServicio.Text = "Seleccionar";
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

            if (txtMecanico.Text == "")
            {
                txtMecanico.Text = "Seleccionar";
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

        private void PresentaciónBicicletas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            String ruta1 = "Motocicletas.TXT";
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
