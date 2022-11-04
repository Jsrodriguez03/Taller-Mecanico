using System;
using System.Windows.Forms;

namespace TALLERM
{
    public partial class DatosClientes : Form
    {
        public DatosClientes()
        {
            InitializeComponent();
            txtTipo.Text = "Seleccionar";
        }

        //Eventos Para Botones
        private void boxLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            txtcedula.Text = "Ingrese Su Cedula";
            txtNombre.Text = "Ingrese Su Nombre";
            txtApellido.Text = "Ingrese Sus Apellidos";
            txtTelefono.Text = "Ingrese Su Telefono";

            txtcedu.Text = "Ingrese Su Cedula";
            txtnom.Text = "Ingrese Su Nombre";
            txtApe.Text = "Ingrese Sus Apellidos";
            txtCargo.Text = "Ingrese Su Cargo";
            txtTipo.Text = "Seleccionar";
        }

        private void boxSiguiente_Click(object sender, EventArgs e)
        {
            IniciarlizarCajas();
            VerificarCajas();
        }

        public void VerificarCajas()
        {
            if (txtcedula.Text == "Ingrese Su Cedula" || txtNombre.Text == "Ingrese Su Nombre" ||
            txtApellido.Text == "Ingrese Sus Apellidos" || txtTelefono.Text == "Ingrese Su Telefono" ||
            txtcedu.Text == "Ingrese Su Cedula" || txtnom.Text == "Ingrese Su Nombre" ||
            txtApe.Text == "Ingrese Sus Apellidos" || txtCargo.Text == "Ingrese Su Cargo" ||
            txtTipo.Text == "Seleccionar")
            {
                MessageBox.Show("Hay Campos sin Completar, Por Favor Reviselos");
            }
            else
            {
                MessageBox.Show("¡DATOS GUARDADOS EXITOSAMENTE! \n" +
                                "Será Dirigido a La Siguiente Sección.");
                

                if (txtTipo.Text == "Bicicleta")
                {
                    this.Hide();
                    new ServiciosBicicleta().ShowDialog();
                    this.Close();
                }

                if (txtTipo.Text == "Motocicleta")
                {
                    this.Hide();
                    new ServiciosMotos().ShowDialog();
                    this.Close();
                }

                if (txtTipo.Text == "Automovil")
                {
                    this.Hide();
                    new ServiciosAutos().ShowDialog();
                    this.Close();
                }
            }
        }

        public void IniciarlizarCajas()
        {
            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void DatosClientes_Click(object sender, EventArgs e)
        {
            IniciarlizarCajas();
        }

        //Eventos Cajas de Textos
        private void txtcedula_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtcedula.Text == "Ingrese Su Cedula")
            {
                txtcedula.Text = "";
            }

            //Verificación de Cajas
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtNombre.Text == "Ingrese Su Nombre")
            {
                txtNombre.Text = "";
            }

            //Verificación del Resto Cajas
            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtApellido.Text == "Ingrese Sus Apellidos")
            {
                txtApellido.Text = "";
            }

            //Verificación de Cajas
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtTelefono.Text == "Ingrese Su Telefono")
            {
                txtTelefono.Text = "";
            }

            //Verificación de Cajas
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtcedu_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtcedu.Text == "Ingrese Su Cedula")
            {
                txtcedu.Text = "";
            }

            //Verificación de Cajas
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtnom_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtnom.Text == "Ingrese Su Nombre")
            {
                txtnom.Text = "";
            }

            //Verificación de Cajas
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtApe_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtApe.Text == "Ingrese Sus Apellidos")
            {
                txtApe.Text = "";
            }

            //Verificación de Cajas
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Ingrese Su Cargo";
            }
        }

        private void txtCargo_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtCargo.Text == "Ingrese Su Cargo")
            {
                txtCargo.Text = "";
            }

            //Verificar Cajas
            if (txtcedula.Text == "")
            {
                txtcedula.Text = "Ingrese Su Cedula";
            }

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese Su Nombre";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
            }

            if (txtcedu.Text == "")
            {
                txtcedu.Text = "Ingrese Su Cedula";
            }

            if (txtnom.Text == "")
            {
                txtnom.Text = "Ingrese Su Nombre";
            }

            if (txtApe.Text == "")
            {
                txtApe.Text = "Ingrese Sus Apellidos";
            }
        }

    }
}
