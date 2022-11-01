namespace TALLERM
{
    partial class INGRESAR
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDatosVehiculo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.Lista);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.txtTipo);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.panelDatosVehiculo);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TALLERM.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(470, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatosVehiculo.Controls.Add(this.txtPrecio);
            this.panelDatosVehiculo.Controls.Add(this.label13);
            this.panelDatosVehiculo.Controls.Add(this.txtServicio);
            this.panelDatosVehiculo.Controls.Add(this.txtColor);
            this.panelDatosVehiculo.Controls.Add(this.label14);
            this.panelDatosVehiculo.Controls.Add(this.txtMarca);
            this.panelDatosVehiculo.Controls.Add(this.label15);
            this.panelDatosVehiculo.Controls.Add(this.txtPlaca);
            this.panelDatosVehiculo.Controls.Add(this.labelPlaca);
            this.panelDatosVehiculo.Controls.Add(this.label16);
            this.panelDatosVehiculo.Location = new System.Drawing.Point(20, 225);
            this.panelDatosVehiculo.Name = "panelDatosVehiculo";
            this.panelDatosVehiculo.Size = new System.Drawing.Size(594, 247);
            this.panelDatosVehiculo.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(10, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(482, 215);
            this.label16.TabIndex = 7;
            this.label16.Text = "DATOS DEL VEHICULO";
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
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlaca.ForeColor = System.Drawing.Color.White;
            this.txtPlaca.Location = new System.Drawing.Point(405, 75);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(162, 20);
            this.txtPlaca.TabIndex = 9;
            this.txtPlaca.Text = "Ingrese La Placa Del Vehiculo";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::TALLERM.Properties.Resources.Marca;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(20, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 23);
            this.label15.TabIndex = 10;
            this.label15.Text = "     MARCA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::TALLERM.Properties.Resources.Color;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(215, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "COLOR";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.Silver;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(15, 111);
            this.txtServicio.Multiline = true;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(549, 80);
            this.txtServicio.TabIndex = 14;
            this.txtServicio.Text = "\r\n\r\nDescriba El Problema Del Auto, Materiales Y Mano De Obra";
            this.txtServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Image = global::TALLERM.Properties.Resources.Pago;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(112, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "PRECIO TOTAL";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(309, 209);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(154, 20);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.Text = "Ingrese El Valor Del Servicio\r\n";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(65, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 56);
            this.label11.TabIndex = 9;
            this.label11.Text = "Indique El Tipo De Vehiculo A Registrar\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtTipo.Location = new System.Drawing.Point(164, 99);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(163, 28);
            this.txtTipo.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(164, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "VOLVER";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(314, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "GUARDAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(20, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "LIMPIAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.Color.Silver;
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 16;
            this.Lista.Location = new System.Drawing.Point(617, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(178, 484);
            this.Lista.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 524);
            this.tabControl1.TabIndex = 13;
            // 
            // INGRESAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "INGRESAR";
            this.Text = "INGRESAR";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}