namespace TallerMecanico
{
    partial class ListadoBicicleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoBicicleta));
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecanico2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaListadoGeneral = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(601, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 50;
            this.button1.Text = "CARGAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnBuscar.Location = new System.Drawing.Point(435, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 40);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Buscar Por Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // precio2
            // 
            this.precio2.FillWeight = 25.38071F;
            this.precio2.HeaderText = "Precio";
            this.precio2.Name = "precio2";
            this.precio2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio2.Width = 70;
            // 
            // mecanico2
            // 
            this.mecanico2.FillWeight = 25.38071F;
            this.mecanico2.HeaderText = "Mecánico";
            this.mecanico2.Name = "mecanico2";
            this.mecanico2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mecanico2.Width = 90;
            // 
            // servicio
            // 
            this.servicio.FillWeight = 771.5736F;
            this.servicio.HeaderText = "Servicio";
            this.servicio.Name = "servicio";
            this.servicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.servicio.Width = 200;
            // 
            // placa
            // 
            this.placa.FillWeight = 25.38071F;
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.placa.Width = 80;
            // 
            // color
            // 
            this.color.FillWeight = 25.38071F;
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.color.Width = 80;
            // 
            // marca
            // 
            this.marca.FillWeight = 25.38071F;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.marca.Width = 70;
            // 
            // telefono
            // 
            this.telefono.FillWeight = 25.38071F;
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefono.Width = 80;
            // 
            // apellido
            // 
            this.apellido.FillWeight = 25.38071F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 25.38071F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cedula
            // 
            this.cedula.FillWeight = 25.38071F;
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cedula.Width = 80;
            // 
            // GrillaListadoGeneral
            // 
            this.GrillaListadoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaListadoGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellido,
            this.telefono,
            this.marca,
            this.color,
            this.placa,
            this.servicio,
            this.mecanico2,
            this.precio2});
            this.GrillaListadoGeneral.Location = new System.Drawing.Point(12, 69);
            this.GrillaListadoGeneral.Name = "GrillaListadoGeneral";
            this.GrillaListadoGeneral.RowHeadersVisible = false;
            this.GrillaListadoGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaListadoGeneral.Size = new System.Drawing.Size(776, 363);
            this.GrillaListadoGeneral.TabIndex = 46;
            // 
            // ListadoBicicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GrillaListadoGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoBicicleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado General de Servicios Bicicletas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaListadoGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mecanico2;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        public System.Windows.Forms.DataGridView GrillaListadoGeneral;
    }
}