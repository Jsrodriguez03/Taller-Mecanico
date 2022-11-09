using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace TALLERM
{
    public partial class PresentaciónClientes : Form
    {
        public PresentaciónClientes()
        {
            InitializeComponent();
            txtTipo.Text = "Seleccionar";
            txtTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Eventos Para Botones
        private void boxLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        public void LimpiarCajas()
        {
            txtCedula.Text = "Ingrese Su Cedula";
            txtNombre.Text = "Ingrese Su Nombre";
            txtApellido.Text = "Ingrese Sus Apellidos";
            txtTelefono.Text = "Ingrese Su Telefono";
        }

        private void boxSiguiente_Click(object sender, EventArgs e)
        {
            IniciarlizarCajas();
            VerificarCajas();
            
        }

        public void VerificarCajas()
        {
            if (txtCedula.Text == "Ingrese Su Cedula" || txtNombre.Text == "Ingrese Su Nombre" ||
            txtApellido.Text == "Ingrese Sus Apellidos" || txtTelefono.Text == "Ingrese Su Telefono" ||
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
                    
                    

                }

                if (txtTipo.Text == "Motocicleta")
                {
                    
                    
                }

                if (txtTipo.Text == "Automovil")
                {
                    
                    PresentaciónAutos autos = new PresentaciónAutos();
                    autos.txtCedu.Text = txtCedula.Text;
                    autos.txtNom.Text = txtNombre.Text;
                    autos.txtApe.Text = txtApellido.Text;
                    autos.txtTel.Text = txtTelefono.Text;                    
                    autos.Show();
                    


                }
            }
        }

        public void IniciarlizarCajas()
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
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
        }

        public void Datos()
        {
            PresentaciónAutos autos = new PresentaciónAutos();
            autos.txtCedu.Text = txtCedula.Text;
            autos.txtNom.Text = txtNombre.Text;
            autos.txtApe.Text = txtApellido.Text;
            autos.txtCedu.Text = txtCedula.Text;
        }

        private void DatosClientes_Click(object sender, EventArgs e)
        {
            IniciarlizarCajas();
        }

        //Eventos Cajas de Textos
        private void txtcedula_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtCedula.Text == "Ingrese Su Cedula")
            {
                txtCedula.Text = "";
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
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            //Evento Para Poner en blanco la Caja
            if (txtNombre.Text == "Ingrese Su Nombre")
            {
                txtNombre.Text = "";
            }

            //Verificación del Resto Cajas
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
            }

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Sus Apellidos";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
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

            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
            }

            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese Su Telefono";
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

            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ingrese Su Cedula";
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
    }
}
