﻿namespace TALLERM
{
    partial class PresentaciónMotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentaciónMotos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PestañaVehiculos = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtMecanico = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgServicios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCedu = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.PestañaVehiculos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDatosVehiculo.SuspendLayout();
            this.ListaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PestañaVehiculos);
            this.tabControl1.Controls.Add(this.ListaGeneral);
            this.tabControl1.Location = new System.Drawing.Point(-3, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 506);
            this.tabControl1.TabIndex = 14;
            // 
            // PestañaVehiculos
            // 
            this.PestañaVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PestañaVehiculos.Controls.Add(this.txtTel);
            this.PestañaVehiculos.Controls.Add(this.txtApe);
            this.PestañaVehiculos.Controls.Add(this.txtNom);
            this.PestañaVehiculos.Controls.Add(this.txtCedu);
            this.PestañaVehiculos.Controls.Add(this.btnSalir);
            this.PestañaVehiculos.Controls.Add(this.panel1);
            this.PestañaVehiculos.Controls.Add(this.dgServicios);
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
            this.btnSalir.Location = new System.Drawing.Point(656, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 40);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.panel1.TabIndex = 42;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnEliminar.Location = new System.Drawing.Point(427, 63);
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
            this.txtMecanico.Location = new System.Drawing.Point(264, 77);
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(143, 21);
            this.txtMecanico.TabIndex = 44;
            this.txtMecanico.Click += new System.EventHandler(this.txtMecanico_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = global::TallerMecanico.Properties.Resources.Mecánico;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(260, 47);
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
            this.btnAgregar.Location = new System.Drawing.Point(427, 11);
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
            "Lavado",
            "Mantenimiento",
            "Pinchazo",
            "Revisión General"});
            this.txtServicio.Location = new System.Drawing.Point(23, 77);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(223, 21);
            this.txtServicio.TabIndex = 41;
            this.txtServicio.Click += new System.EventHandler(this.txtServicio_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Image = global::TallerMecanico.Properties.Resources.icons8_engranaje_303;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(16, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 27);
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
            // dgServicios
            // 
            this.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgServicios.Location = new System.Drawing.Point(19, 267);
            this.dgServicios.Name = "dgServicios";
            this.dgServicios.RowHeadersVisible = false;
            this.dgServicios.RowHeadersWidth = 40;
            this.dgServicios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgServicios.Size = new System.Drawing.Size(592, 195);
            this.dgServicios.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción Servicios";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 290;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mecánico Responsable";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 168;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor del Servicio";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 131;
            // 
            // Precio
            // 
            this.Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Precio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Precio.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.Color.White;
            this.Precio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Precio.Location = new System.Drawing.Point(636, 431);
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
            this.label4.Location = new System.Drawing.Point(636, 401);
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
            this.btnLimpiar.Location = new System.Drawing.Point(656, 194);
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
            this.btnGuardar.Location = new System.Drawing.Point(656, 287);
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
            this.btnVolver.Location = new System.Drawing.Point(656, 241);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 40);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatosVehiculo.Controls.Add(this.label1);
            this.panelDatosVehiculo.Controls.Add(this.txtColor);
            this.panelDatosVehiculo.Controls.Add(this.label5);
            this.panelDatosVehiculo.Controls.Add(this.txtMarca);
            this.panelDatosVehiculo.Controls.Add(this.label3);
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
            this.label1.Text = "Datos De La Bicicleta";
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
            this.label5.Image = global::TallerMecanico.Properties.Resources.icons8_bicicleta_40__1_4;
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
            this.label3.Image = global::TallerMecanico.Properties.Resources.icons8_bicicleta_301;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "     MARCA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.GrillaListadoGeneral.TabIndex = 1;
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
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(806, 83);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(29, 15);
            this.txtTel.TabIndex = 50;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.Visible = false;
            // 
            // txtApe
            // 
            this.txtApe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApe.Enabled = false;
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(806, 59);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(29, 15);
            this.txtApe.TabIndex = 49;
            this.txtApe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApe.Visible = false;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(806, 40);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(29, 15);
            this.txtNom.TabIndex = 48;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNom.Visible = false;
            // 
            // txtCedu
            // 
            this.txtCedu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCedu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedu.Enabled = false;
            this.txtCedu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedu.Location = new System.Drawing.Point(806, 17);
            this.txtCedu.Name = "txtCedu";
            this.txtCedu.Size = new System.Drawing.Size(29, 15);
            this.txtCedu.TabIndex = 47;
            this.txtCedu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedu.Visible = false;
            // 
            // PresentaciónMotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 500);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PresentaciónMotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TALLER MECÁNICO - Solicitud de Datos Bicicleta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiciosBicicleta_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.PestañaVehiculos.ResumeLayout(false);
            this.PestañaVehiculos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.ListaGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PestañaVehiculos;
        private System.Windows.Forms.DataGridView dgServicios;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ListaGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox txtMecanico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox txtServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GrillaListadoGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtApe;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtCedu;
    }
}