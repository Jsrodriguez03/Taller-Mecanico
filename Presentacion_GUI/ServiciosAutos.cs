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
    public partial class ServiciosAutos : Form
    {
        public ServiciosAutos()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            txtTipo.Text = "Seleccionar";
            txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            txtColor.Text = "Ingrese El Color Del Vehiculo";
            txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            txtPrecio.Text = "Ingrese El Total a Pagar";
            txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
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
                txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
            }

            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Ingrese El Total a Pagar";
            }
        }

        public void VerificarCajas()
        {
            if (txtTipo.Text == "Seleccionar" || txtMarca.Text == "Ingrese La Marca Del Vehiculo" ||
                txtColor.Text == "Ingrese El Color Del Vehiculo" || txtPlaca.Text == "Ingrese La Placa Del Vehiculo" ||
                txtPrecio.Text == "Ingrese El Total a Pagar" || txtServicio.Text == "Describa El Problema Del Auto, Materiales Y Mano De Obra")
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
            this.Close();
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
                txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
            }

            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Ingrese El Total a Pagar";
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
                txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
            }

            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Ingrese El Total a Pagar";
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
                txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
            }

            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Ingrese El Total a Pagar";
            }
        }        

        private void txtServicio_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text == "Describa El Problema Del Auto, Materiales Y Mano De Obra")
            {
                txtServicio.Text = "";
            }

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

            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Ingrese El Total a Pagar";
            }
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            if (txtServicio.Text == "")
            {
                txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
            }

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

            if (txtPrecio.Text == "Ingrese El Total a Pagar")
            {
                txtPrecio.Text = "";
            }
        }
   
    }
}