namespace TALLERM
{
    partial class PresentaciónAutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentaciónAutos));
            this.PestañaVehiculos = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgServicios = new System.Windows.Forms.DataGridView();
            this.descripciónServicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtMecanico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListaGeneral = new System.Windows.Forms.TabPage();
            this.GrillaListadoGeneral = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecanico2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCedu = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.PestañaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDatosVehiculo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ListaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // PestañaVehiculos
            // 
            this.PestañaVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PestañaVehiculos.Controls.Add(this.txtTel);
            this.PestañaVehiculos.Controls.Add(this.txtApe);
            this.PestañaVehiculos.Controls.Add(this.txtNom);
            this.PestañaVehiculos.Controls.Add(this.txtCedu);
            this.PestañaVehiculos.Controls.Add(this.btnSalir);
            this.PestañaVehiculos.Controls.Add(this.dgServicios);
            this.PestañaVehiculos.Controls.Add(this.panel1);
            this.PestañaVehiculos.Controls.Add(this.Precio);
            this.PestañaVehiculos.Controls.Add(this.label4);
            this.PestañaVehiculos.Controls.Add(this.pictureBox1);
            this.PestañaVehiculos.Controls.Add(this.btnLimpiar);
            this.PestañaVehiculos.Controls.Add(this.btnGuardar);
            this.PestañaVehiculos.Controls.Add(this.btnVolver);
            this.PestañaVehiculos.Controls.Add(this.panelDatosVehiculo);
            this.PestañaVehiculos.Location = new System.Drawing.Point(4, 22);
            this.PestañaVehiculos.Name = "PestañaVehiculos";
            this.PestañaVehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.PestañaVehiculos.Size = new System.Drawing.Size(838, 480);
            this.PestañaVehiculos.TabIndex = 1;
            this.PestañaVehiculos.Text = "Registro Servicios";
            this.PestañaVehiculos.Click += new System.EventHandler(this.PestañaVehiculos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(656, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 40);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgServicios
            // 
            this.dgServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripciónServicios,
            this.Mecanico,
            this.valor});
            this.dgServicios.Location = new System.Drawing.Point(19, 267);
            this.dgServicios.Name = "dgServicios";
            this.dgServicios.RowHeadersVisible = false;
            this.dgServicios.RowHeadersWidth = 40;
            this.dgServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgServicios.Size = new System.Drawing.Size(592, 195);
            this.dgServicios.TabIndex = 41;
            // 
            // descripciónServicios
            // 
            this.descripciónServicios.FillWeight = 147.708F;
            this.descripciónServicios.HeaderText = "Descripción Servicios";
            this.descripciónServicios.Name = "descripciónServicios";
            this.descripciónServicios.ReadOnly = true;
            this.descripciónServicios.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descripciónServicios.Width = 290;
            // 
            // Mecanico
            // 
            this.Mecanico.FillWeight = 85.78158F;
            this.Mecanico.HeaderText = "Mecánico Responsable";
            this.Mecanico.Name = "Mecanico";
            this.Mecanico.ReadOnly = true;
            this.Mecanico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mecanico.Width = 168;
            // 
            // valor
            // 
            this.valor.FillWeight = 66.51044F;
            this.valor.HeaderText = "Valor del Servicio";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valor.Width = 131;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtMecanico);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtServicio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(19, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 119);
            this.panel1.TabIndex = 40;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnEliminar.Location = new System.Drawing.Point(426, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 40);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtMecanico
            // 
            this.txtMecanico.BackColor = System.Drawing.Color.White;
            this.txtMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMecanico.ForeColor = System.Drawing.Color.Black;
            this.txtMecanico.FormattingEnabled = true;
            this.txtMecanico.Items.AddRange(new object[] {
            "Seleccionar",
            "Junior Rodriguez",
            "Juliana Torres",
            "Luis Pinto",
            "Steven Molina",
            "Nayid Castellar"});
            this.txtMecanico.Location = new System.Drawing.Point(262, 77);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(146, 21);
            this.txtMecanico.TabIndex = 44;
            this.txtMecanico.Click += new System.EventHandler(this.txtMecanico_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = global::TallerMecanico.Properties.Resources.Mecánico;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(258, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mecánico";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.Location = new System.Drawing.Point(426, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 40);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.White;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.ForeColor = System.Drawing.Color.Black;
            this.txtServicio.FormattingEnabled = true;
            this.txtServicio.Items.AddRange(new object[] {
            "Seleccionar",
            "Ajustes del Borner",
            "Ajustes del Motor",
            "Ajuste del tiempo de encendido",
            "Cambio de Aceite y Filtro",
            "Limpieza o Cambio del filtro de aire",
            "Limpieza o Cambio  de gasolina",
            "Limpieza o Cambio de las bujías",
            "Nivelación de batería",
            "Pintar",
            "Pinchazos",
            "Reparación de clutch",
            "Reparación de Frenos",
            "Reparación de luces",
            "Revisión del tren delantero"});
            this.txtServicio.Location = new System.Drawing.Point(22, 77);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(223, 21);
            this.txtServicio.TabIndex = 41;
            this.txtServicio.Click += new System.EventHandler(this.txtServicio_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = global::TallerMecanico.Properties.Resources.icons8_engranaje_302;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipo de Servicio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 27);
            this.label8.TabIndex = 39;
            this.label8.Text = "Datos Del Servicio ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Precio
            // 
            this.Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Precio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Precio.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.White;
            this.Precio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Precio.Location = new System.Drawing.Point(636, 430);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(186, 28);
            this.Precio.TabIndex = 17;
            this.Precio.Text = "0$";
            this.Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Image = global::TallerMecanico.Properties.Resources.Pago;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(636, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "PRECIO TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallerMecanico.Properties.Resources.Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(656, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(656, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(656, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 40);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LimeGreen;
            this.btnVolver.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(656, 244);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 40);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatosVehiculo.Controls.Add(this.label1);
            this.panelDatosVehiculo.Controls.Add(this.txtColor);
            this.panelDatosVehiculo.Controls.Add(this.label5);
            this.panelDatosVehiculo.Controls.Add(this.txtMarca);
            this.panelDatosVehiculo.Controls.Add(this.label3);
            this.panelDatosVehiculo.Controls.Add(this.txtPlaca);
            this.panelDatosVehiculo.Controls.Add(this.labelPlaca);
            this.panelDatosVehiculo.Location = new System.Drawing.Point(19, 17);
            this.panelDatosVehiculo.Name = "panelDatosVehiculo";
            this.panelDatosVehiculo.Size = new System.Drawing.Size(592, 119);
            this.panelDatosVehiculo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Datos Del Automovil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(212, 77);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(163, 20);
            this.txtColor.TabIndex = 38;
            this.txtColor.Text = "Ingrese El Color Del Vehiculo";
            this.txtColor.Click += new System.EventHandler(this.txtColor_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::TallerMecanico.Properties.Resources.Color;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(211, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "COLOR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(17, 77);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(167, 20);
            this.txtMarca.TabIndex = 36;
            this.txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            this.txtMarca.Click += new System.EventHandler(this.txtMarca_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::TallerMecanico.Properties.Resources.Marca;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "     MARCA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaca.ForeColor = System.Drawing.Color.White;
            this.txtPlaca.Location = new System.Drawing.Point(401, 77);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(162, 20);
            this.txtPlaca.TabIndex = 34;
            this.txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            this.txtPlaca.Click += new System.EventHandler(this.txtPlaca_Click);
            // 
            // labelPlaca
            // 
            this.labelPlaca.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Image = global::TallerMecanico.Properties.Resources.Placa;
            this.labelPlaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPlaca.Location = new System.Drawing.Point(400, 51);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(106, 23);
            this.labelPlaca.TabIndex = 33;
            this.labelPlaca.Text = "PLACA";
            this.labelPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PestañaVehiculos);
            this.tabControl1.Controls.Add(this.ListaGeneral);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 506);
            this.tabControl1.TabIndex = 13;
            // 
            // ListaGeneral
            // 
            this.ListaGeneral.Controls.Add(this.GrillaListadoGeneral);
            this.ListaGeneral.Location = new System.Drawing.Point(4, 22);
            this.ListaGeneral.Name = "ListaGeneral";
            this.ListaGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.ListaGeneral.Size = new System.Drawing.Size(838, 480);
            this.ListaGeneral.TabIndex = 2;
            this.ListaGeneral.Text = "Listado General";
            this.ListaGeneral.UseVisualStyleBackColor = true;
            // 
            // GrillaListadoGeneral
            // 
            this.GrillaListadoGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaListadoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListadoGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellido,
            this.telefono,
            this.marca,
            this.color,
            this.placa,
            this.mecanico2,
            this.precio2});
            this.GrillaListadoGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaListadoGeneral.Location = new System.Drawing.Point(3, 3);
            this.GrillaListadoGeneral.Name = "GrillaListadoGeneral";
            this.GrillaListadoGeneral.RowHeadersVisible = false;
            this.GrillaListadoGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaListadoGeneral.Size = new System.Drawing.Size(832, 474);
            this.GrillaListadoGeneral.TabIndex = 0;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mecanico2
            // 
            this.mecanico2.HeaderText = "Mecánico";
            this.mecanico2.Name = "mecanico2";
            this.mecanico2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precio2
            // 
            this.precio2.HeaderText = "Precio";
            this.precio2.Name = "precio2";
            this.precio2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtCedu
            // 
            this.txtCedu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCedu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedu.Enabled = false;
            this.txtCedu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedu.Location = new System.Drawing.Point(806, 17);
            this.txtCedu.Name = "txtCedu";
            this.txtCedu.Size = new System.Drawing.Size(29, 15);
            this.txtCedu.TabIndex = 43;
            this.txtCedu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedu.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(806, 40);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(29, 15);
            this.txtNom.TabIndex = 44;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNom.Visible = false;
            // 
            // txtApe
            // 
            this.txtApe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtApe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApe.Enabled = false;
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(806, 59);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(29, 15);
            this.txtApe.TabIndex = 45;
            this.txtApe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApe.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(806, 83);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(29, 15);
            this.txtTel.TabIndex = 46;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.Visible = false;
            // 
            // PresentaciónAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PresentaciónAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TALLER MECÁNICO - Solicitud de Datos Automovil";
            this.Load += new System.EventHandler(this.PresentaciónAutos_Load);
            this.PestañaVehiculos.ResumeLayout(false);
            this.PestañaVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ListaGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage PestañaVehiculos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ListaGeneral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox txtMecanico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox txtServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgServicios;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView GrillaListadoGeneral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mecanico2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio2;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtApe;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtCedu;
    }
}