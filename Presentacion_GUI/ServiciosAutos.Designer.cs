namespace TALLERM
{
    partial class ServiciosAutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiciosAutos));
            this.PestañaVehiculos = new System.Windows.Forms.TabPage();
            this.dgServicios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtMecanico = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListaGeneral = new System.Windows.Forms.TabPage();
            this.GrillaListadoGeneral = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.PestañaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDatosVehiculo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ListaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PestañaVehiculos
            // 
            this.PestañaVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PestañaVehiculos.Controls.Add(this.dgServicios);
            this.PestañaVehiculos.Controls.Add(this.panel1);
            this.PestañaVehiculos.Controls.Add(this.label2);
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
            // dgServicios
            // 
            this.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgServicios.Location = new System.Drawing.Point(19, 267);
            this.dgServicios.Name = "dgServicios";
            this.dgServicios.RowHeadersWidth = 40;
            this.dgServicios.Size = new System.Drawing.Size(592, 195);
            this.dgServicios.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción Servicios";
            this.Column1.Name = "Column1";
            this.Column1.Width = 257;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mecánico Responsable";
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor del Servicio";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
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
            this.btnEliminar.Location = new System.Drawing.Point(419, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 40);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.txtMecanico.Location = new System.Drawing.Point(243, 44);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(163, 21);
            this.txtMecanico.TabIndex = 44;
            this.txtMecanico.Click += new System.EventHandler(this.txtMecanico_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.Location = new System.Drawing.Point(419, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 40);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.White;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.ForeColor = System.Drawing.Color.Black;
            this.txtServicio.FormattingEnabled = true;
            this.txtServicio.Items.AddRange(new object[] {
            "Seleccionar",
            "Ajustes del Borner - [15.700 $]",
            "Ajustes del Motor - [530.000 $]",
            "Ajuste del tiempo de encendido - [23.200 $]",
            "Cambio de Aceite y Filtro - [13.000 $]",
            "Limpieza o Cambio del filtro de aire - [152.000 $]",
            "Limpieza o Cambio  de gasolina - [150.000 $]",
            "Limpieza o Cambio de las bujías - [26.900 $]",
            "Nivelación de batería - [15.000 $]",
            "Pintar - [54.000 $]",
            "Pinchazos - [35.000 $]",
            "Reparación de clutch - [110.000 $]",
            "Reparación de Frenos - [20.000 $]",
            "Reparación de luces - [18.700 $]",
            "Revisión del tren delantero [38.000 $]"});
            this.txtServicio.Location = new System.Drawing.Point(22, 77);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(384, 21);
            this.txtServicio.TabIndex = 41;
            this.txtServicio.Click += new System.EventHandler(this.txtServicio_Click);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(636, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "0$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(656, 211);
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
            this.btnGuardar.Location = new System.Drawing.Point(656, 304);
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
            this.btnVolver.Location = new System.Drawing.Point(656, 258);
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
            this.GrillaListadoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListadoGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.GrillaListadoGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaListadoGeneral.Location = new System.Drawing.Point(3, 3);
            this.GrillaListadoGeneral.Name = "GrillaListadoGeneral";
            this.GrillaListadoGeneral.Size = new System.Drawing.Size(832, 474);
            this.GrillaListadoGeneral.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cedula";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Telefono";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Marca";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Placa";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Servicio";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Mecánico";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Precio";
            this.Column12.Name = "Column12";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = global::TALLERM.Properties.Resources.Mecánico;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(256, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mecánico";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = global::TALLERM.Properties.Resources.icons8_engranaje_302;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipo de Servicio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Image = global::TALLERM.Properties.Resources.Pago;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(636, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "PRECIO TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TALLERM.Properties.Resources.Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(656, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::TALLERM.Properties.Resources.Color;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(211, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "COLOR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::TALLERM.Properties.Resources.Marca;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "     MARCA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlaca
            // 
            this.labelPlaca.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Image = global::TALLERM.Properties.Resources.Placa;
            this.labelPlaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPlaca.Location = new System.Drawing.Point(400, 51);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(106, 23);
            this.labelPlaca.TabIndex = 33;
            this.labelPlaca.Text = "PLACA";
            this.labelPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ServiciosAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiciosAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TALLER MECÁNICO - Solicitud de Datos Automovil";
            this.PestañaVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ListaGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView GrillaListadoGeneral;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}