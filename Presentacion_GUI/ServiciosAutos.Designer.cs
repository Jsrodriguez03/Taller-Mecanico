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
            this.ListaServicios = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListaGeneral = new System.Windows.Forms.TabPage();
            this.GrillaListadoGeneral = new System.Windows.Forms.DataGridView();
            this.PestañaVehiculos.SuspendLayout();
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
            this.PestañaVehiculos.Controls.Add(this.ListaServicios);
            this.PestañaVehiculos.Controls.Add(this.pictureBox1);
            this.PestañaVehiculos.Controls.Add(this.btnLimpiar);
            this.PestañaVehiculos.Controls.Add(this.btnGuardar);
            this.PestañaVehiculos.Controls.Add(this.btnVolver);
            this.PestañaVehiculos.Controls.Add(this.txtTipo);
            this.PestañaVehiculos.Controls.Add(this.label6);
            this.PestañaVehiculos.Controls.Add(this.panelDatosVehiculo);
            this.PestañaVehiculos.Location = new System.Drawing.Point(4, 22);
            this.PestañaVehiculos.Name = "PestañaVehiculos";
            this.PestañaVehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.PestañaVehiculos.Size = new System.Drawing.Size(838, 446);
            this.PestañaVehiculos.TabIndex = 1;
            this.PestañaVehiculos.Text = "Registro Servicios";
            this.PestañaVehiculos.Click += new System.EventHandler(this.PestañaVehiculos_Click);
            // 
            // ListaServicios
            // 
            this.ListaServicios.BackColor = System.Drawing.Color.Silver;
            this.ListaServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaServicios.FormattingEnabled = true;
            this.ListaServicios.ItemHeight = 16;
            this.ListaServicios.Location = new System.Drawing.Point(633, 26);
            this.ListaServicios.Name = "ListaServicios";
            this.ListaServicios.Size = new System.Drawing.Size(186, 340);
            this.ListaServicios.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TALLERM.Properties.Resources.Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(468, 23);
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
            this.btnLimpiar.Location = new System.Drawing.Point(20, 128);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 40);
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
            this.btnGuardar.Location = new System.Drawing.Point(313, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 40);
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
            this.btnVolver.Location = new System.Drawing.Point(167, 128);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 40);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.White;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Seleccionar",
            "Bicicleta",
            "Motocicleta",
            "Automovil"});
            this.txtTipo.Location = new System.Drawing.Point(128, 82);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(163, 28);
            this.txtTipo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 56);
            this.label6.TabIndex = 9;
            this.label6.Text = "Indique El Tipo De Vehiculo A Registrar\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatosVehiculo.Controls.Add(this.txtPrecio);
            this.panelDatosVehiculo.Controls.Add(this.label4);
            this.panelDatosVehiculo.Controls.Add(this.txtServicio);
            this.panelDatosVehiculo.Controls.Add(this.txtColor);
            this.panelDatosVehiculo.Controls.Add(this.label5);
            this.panelDatosVehiculo.Controls.Add(this.txtMarca);
            this.panelDatosVehiculo.Controls.Add(this.label3);
            this.panelDatosVehiculo.Controls.Add(this.txtPlaca);
            this.panelDatosVehiculo.Controls.Add(this.labelPlaca);
            this.panelDatosVehiculo.Controls.Add(this.label1);
            this.panelDatosVehiculo.Location = new System.Drawing.Point(20, 183);
            this.panelDatosVehiculo.Name = "panelDatosVehiculo";
            this.panelDatosVehiculo.Size = new System.Drawing.Size(592, 186);
            this.panelDatosVehiculo.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(309, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(154, 20);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.Text = "Ingrese El Total a Pagar";
            this.txtPrecio.Click += new System.EventHandler(this.txtPrecio_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Image = global::TALLERM.Properties.Resources.Pago;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(112, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "PRECIO TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.Silver;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(19, 111);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(549, 22);
            this.txtServicio.TabIndex = 14;
            this.txtServicio.Text = "Describa El Problema Del Auto, Materiales Y Mano De Obra";
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServicio.Click += new System.EventHandler(this.txtServicio_Click);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(216, 75);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(163, 20);
            this.txtColor.TabIndex = 13;
            this.txtColor.Text = "Ingrese El Color Del Vehiculo";
            this.txtColor.Click += new System.EventHandler(this.txtColor_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::TALLERM.Properties.Resources.Color;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(215, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "COLOR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(21, 75);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(167, 20);
            this.txtMarca.TabIndex = 11;
            this.txtMarca.Text = "Ingrese La Marca Del Vehiculo";
            this.txtMarca.Click += new System.EventHandler(this.txtMarca_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::TALLERM.Properties.Resources.Marca;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(20, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "     MARCA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaca.ForeColor = System.Drawing.Color.White;
            this.txtPlaca.Location = new System.Drawing.Point(405, 75);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(162, 20);
            this.txtPlaca.TabIndex = 9;
            this.txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            this.txtPlaca.Click += new System.EventHandler(this.txtPlaca_Click);
            // 
            // labelPlaca
            // 
            this.labelPlaca.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Image = global::TALLERM.Properties.Resources.Placa;
            this.labelPlaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPlaca.Location = new System.Drawing.Point(404, 49);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(106, 23);
            this.labelPlaca.TabIndex = 8;
            this.labelPlaca.Text = "PLACA";
            this.labelPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(-2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 179);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATOS DEL VEHICULO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PestañaVehiculos);
            this.tabControl1.Controls.Add(this.ListaGeneral);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 472);
            this.tabControl1.TabIndex = 13;
            // 
            // ListaGeneral
            // 
            this.ListaGeneral.Controls.Add(this.GrillaListadoGeneral);
            this.ListaGeneral.Location = new System.Drawing.Point(4, 22);
            this.ListaGeneral.Name = "ListaGeneral";
            this.ListaGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.ListaGeneral.Size = new System.Drawing.Size(838, 446);
            this.ListaGeneral.TabIndex = 2;
            this.ListaGeneral.Text = "Listado General";
            this.ListaGeneral.UseVisualStyleBackColor = true;
            // 
            // GrillaListadoGeneral
            // 
            this.GrillaListadoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListadoGeneral.Location = new System.Drawing.Point(19, 15);
            this.GrillaListadoGeneral.Name = "GrillaListadoGeneral";
            this.GrillaListadoGeneral.Size = new System.Drawing.Size(796, 357);
            this.GrillaListadoGeneral.TabIndex = 0;
            // 
            // ServiciosAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 467);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiciosAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TALLER MECÁNICO - Solicitud de Datos Automovil";
            this.PestañaVehiculos.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox ListaServicios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaListadoGeneral;
    }
}