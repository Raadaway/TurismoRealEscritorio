
namespace TurismoReal.Presentacion
{
    partial class FrmReservas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Listado = new System.Windows.Forms.TabPage();
            this.CbSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.BtnCheckIn = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DGVListar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.LblIdEstado = new System.Windows.Forms.Label();
            this.LblRutCliente = new System.Windows.Forms.Label();
            this.LblIdDepartamento = new System.Windows.Forms.Label();
            this.LblAbonado = new System.Windows.Forms.Label();
            this.TxtIdEstado = new System.Windows.Forms.TextBox();
            this.TxtRutCliente = new System.Windows.Forms.TextBox();
            this.TxtIdDepartamento = new System.Windows.Forms.TextBox();
            this.TxtMontoAbonado = new System.Windows.Forms.TextBox();
            this.LblIdReserva = new System.Windows.Forms.Label();
            this.TxtIdReserva = new System.Windows.Forms.TextBox();
            this.LblMontoPagado = new System.Windows.Forms.Label();
            this.LblCantidadPersonas = new System.Windows.Forms.Label();
            this.LblTerminoReserva = new System.Windows.Forms.Label();
            this.LblInicioReserva = new System.Windows.Forms.Label();
            this.TxtMontoPagado = new System.Windows.Forms.TextBox();
            this.TxtCantPersonas = new System.Windows.Forms.TextBox();
            this.DTTerminoReserva = new MetroFramework.Controls.MetroDateTime();
            this.DTInicioReserva = new MetroFramework.Controls.MetroDateTime();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).BeginInit();
            this.Agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Listado);
            this.tabControl1.Controls.Add(this.Agregar);
            this.tabControl1.Location = new System.Drawing.Point(1, 66);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 562);
            this.tabControl1.TabIndex = 4;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.CbSeleccionar);
            this.Listado.Controls.Add(this.BtnCheckOut);
            this.Listado.Controls.Add(this.BtnCheckIn);
            this.Listado.Controls.Add(this.BtnEliminar);
            this.Listado.Controls.Add(this.LblTotal);
            this.Listado.Controls.Add(this.BtnBuscar);
            this.Listado.Controls.Add(this.TxtBuscar);
            this.Listado.Controls.Add(this.DGVListar);
            this.Listado.Location = new System.Drawing.Point(4, 25);
            this.Listado.Margin = new System.Windows.Forms.Padding(4);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(4);
            this.Listado.Size = new System.Drawing.Size(1024, 533);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listar";
            this.Listado.UseVisualStyleBackColor = true;
            // 
            // CbSeleccionar
            // 
            this.CbSeleccionar.AutoSize = true;
            this.CbSeleccionar.Location = new System.Drawing.Point(9, 464);
            this.CbSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.CbSeleccionar.Name = "CbSeleccionar";
            this.CbSeleccionar.Size = new System.Drawing.Size(101, 20);
            this.CbSeleccionar.TabIndex = 9;
            this.CbSeleccionar.Text = "Seleccionar";
            this.CbSeleccionar.UseVisualStyleBackColor = true;
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Location = new System.Drawing.Point(867, 20);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(143, 32);
            this.BtnCheckOut.TabIndex = 8;
            this.BtnCheckOut.Text = "Realizar Check-Out";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.Location = new System.Drawing.Point(718, 20);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(143, 32);
            this.BtnCheckIn.TabIndex = 7;
            this.BtnCheckIn.Text = "Realizar Check-In";
            this.BtnCheckIn.UseVisualStyleBackColor = true;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(569, 20);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(143, 32);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(817, 473);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 16);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(419, 20);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(143, 32);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(9, 25);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(400, 22);
            this.TxtBuscar.TabIndex = 3;
            // 
            // DGVListar
            // 
            this.DGVListar.AllowUserToAddRows = false;
            this.DGVListar.AllowUserToDeleteRows = false;
            this.DGVListar.AllowUserToOrderColumns = true;
            this.DGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVListar.Location = new System.Drawing.Point(9, 66);
            this.DGVListar.Margin = new System.Windows.Forms.Padding(4);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.RowHeadersWidth = 51;
            this.DGVListar.Size = new System.Drawing.Size(1004, 390);
            this.DGVListar.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.LblIdEstado);
            this.Agregar.Controls.Add(this.LblRutCliente);
            this.Agregar.Controls.Add(this.LblIdDepartamento);
            this.Agregar.Controls.Add(this.LblAbonado);
            this.Agregar.Controls.Add(this.TxtIdEstado);
            this.Agregar.Controls.Add(this.TxtRutCliente);
            this.Agregar.Controls.Add(this.TxtIdDepartamento);
            this.Agregar.Controls.Add(this.TxtMontoAbonado);
            this.Agregar.Controls.Add(this.LblIdReserva);
            this.Agregar.Controls.Add(this.TxtIdReserva);
            this.Agregar.Controls.Add(this.LblMontoPagado);
            this.Agregar.Controls.Add(this.LblCantidadPersonas);
            this.Agregar.Controls.Add(this.LblTerminoReserva);
            this.Agregar.Controls.Add(this.LblInicioReserva);
            this.Agregar.Controls.Add(this.TxtMontoPagado);
            this.Agregar.Controls.Add(this.TxtCantPersonas);
            this.Agregar.Controls.Add(this.DTTerminoReserva);
            this.Agregar.Controls.Add(this.DTInicioReserva);
            this.Agregar.Controls.Add(this.BtnCancelar);
            this.Agregar.Controls.Add(this.BtnAgregar);
            this.Agregar.Location = new System.Drawing.Point(4, 25);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(1024, 533);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // LblIdEstado
            // 
            this.LblIdEstado.AutoSize = true;
            this.LblIdEstado.Location = new System.Drawing.Point(559, 219);
            this.LblIdEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdEstado.Name = "LblIdEstado";
            this.LblIdEstado.Size = new System.Drawing.Size(66, 16);
            this.LblIdEstado.TabIndex = 37;
            this.LblIdEstado.Text = "ID Estado";
            // 
            // LblRutCliente
            // 
            this.LblRutCliente.AutoSize = true;
            this.LblRutCliente.Location = new System.Drawing.Point(544, 166);
            this.LblRutCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRutCliente.Name = "LblRutCliente";
            this.LblRutCliente.Size = new System.Drawing.Size(80, 16);
            this.LblRutCliente.TabIndex = 36;
            this.LblRutCliente.Text = "RUT Cliente";
            // 
            // LblIdDepartamento
            // 
            this.LblIdDepartamento.AutoSize = true;
            this.LblIdDepartamento.Location = new System.Drawing.Point(513, 118);
            this.LblIdDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdDepartamento.Name = "LblIdDepartamento";
            this.LblIdDepartamento.Size = new System.Drawing.Size(109, 16);
            this.LblIdDepartamento.TabIndex = 35;
            this.LblIdDepartamento.Text = "ID Departamento";
            // 
            // LblAbonado
            // 
            this.LblAbonado.AutoSize = true;
            this.LblAbonado.Location = new System.Drawing.Point(520, 68);
            this.LblAbonado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAbonado.Name = "LblAbonado";
            this.LblAbonado.Size = new System.Drawing.Size(103, 16);
            this.LblAbonado.TabIndex = 34;
            this.LblAbonado.Text = "Monto Abonado";
            // 
            // TxtIdEstado
            // 
            this.TxtIdEstado.Location = new System.Drawing.Point(639, 215);
            this.TxtIdEstado.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdEstado.Name = "TxtIdEstado";
            this.TxtIdEstado.Size = new System.Drawing.Size(236, 22);
            this.TxtIdEstado.TabIndex = 33;
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Location = new System.Drawing.Point(639, 162);
            this.TxtRutCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(236, 22);
            this.TxtRutCliente.TabIndex = 32;
            // 
            // TxtIdDepartamento
            // 
            this.TxtIdDepartamento.Location = new System.Drawing.Point(639, 114);
            this.TxtIdDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdDepartamento.Name = "TxtIdDepartamento";
            this.TxtIdDepartamento.Size = new System.Drawing.Size(236, 22);
            this.TxtIdDepartamento.TabIndex = 31;
            // 
            // TxtMontoAbonado
            // 
            this.TxtMontoAbonado.Location = new System.Drawing.Point(639, 64);
            this.TxtMontoAbonado.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMontoAbonado.Name = "TxtMontoAbonado";
            this.TxtMontoAbonado.Size = new System.Drawing.Size(236, 22);
            this.TxtMontoAbonado.TabIndex = 30;
            // 
            // LblIdReserva
            // 
            this.LblIdReserva.AutoSize = true;
            this.LblIdReserva.Location = new System.Drawing.Point(119, 68);
            this.LblIdReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdReserva.Name = "LblIdReserva";
            this.LblIdReserva.Size = new System.Drawing.Size(75, 16);
            this.LblIdReserva.TabIndex = 29;
            this.LblIdReserva.Text = "ID Reserva";
            // 
            // TxtIdReserva
            // 
            this.TxtIdReserva.Location = new System.Drawing.Point(208, 64);
            this.TxtIdReserva.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdReserva.Name = "TxtIdReserva";
            this.TxtIdReserva.Size = new System.Drawing.Size(236, 22);
            this.TxtIdReserva.TabIndex = 28;
            // 
            // LblMontoPagado
            // 
            this.LblMontoPagado.AutoSize = true;
            this.LblMontoPagado.Location = new System.Drawing.Point(97, 262);
            this.LblMontoPagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMontoPagado.Name = "LblMontoPagado";
            this.LblMontoPagado.Size = new System.Drawing.Size(96, 16);
            this.LblMontoPagado.TabIndex = 27;
            this.LblMontoPagado.Text = "Monto Pagado";
            // 
            // LblCantidadPersonas
            // 
            this.LblCantidadPersonas.AutoSize = true;
            this.LblCantidadPersonas.Location = new System.Drawing.Point(72, 219);
            this.LblCantidadPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidadPersonas.Name = "LblCantidadPersonas";
            this.LblCantidadPersonas.Size = new System.Drawing.Size(122, 16);
            this.LblCantidadPersonas.TabIndex = 26;
            this.LblCantidadPersonas.Text = "Cantidad Personas";
            // 
            // LblTerminoReserva
            // 
            this.LblTerminoReserva.AutoSize = true;
            this.LblTerminoReserva.Location = new System.Drawing.Point(83, 176);
            this.LblTerminoReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTerminoReserva.Name = "LblTerminoReserva";
            this.LblTerminoReserva.Size = new System.Drawing.Size(112, 16);
            this.LblTerminoReserva.TabIndex = 25;
            this.LblTerminoReserva.Text = "Termino Reserva";
            // 
            // LblInicioReserva
            // 
            this.LblInicioReserva.AutoSize = true;
            this.LblInicioReserva.Location = new System.Drawing.Point(100, 123);
            this.LblInicioReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInicioReserva.Name = "LblInicioReserva";
            this.LblInicioReserva.Size = new System.Drawing.Size(93, 16);
            this.LblInicioReserva.TabIndex = 24;
            this.LblInicioReserva.Text = "Inicio Reserva";
            // 
            // TxtMontoPagado
            // 
            this.TxtMontoPagado.Location = new System.Drawing.Point(208, 258);
            this.TxtMontoPagado.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMontoPagado.Name = "TxtMontoPagado";
            this.TxtMontoPagado.Size = new System.Drawing.Size(236, 22);
            this.TxtMontoPagado.TabIndex = 23;
            // 
            // TxtCantPersonas
            // 
            this.TxtCantPersonas.Location = new System.Drawing.Point(208, 215);
            this.TxtCantPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantPersonas.Name = "TxtCantPersonas";
            this.TxtCantPersonas.Size = new System.Drawing.Size(236, 22);
            this.TxtCantPersonas.TabIndex = 22;
            // 
            // DTTerminoReserva
            // 
            this.DTTerminoReserva.Location = new System.Drawing.Point(208, 164);
            this.DTTerminoReserva.Margin = new System.Windows.Forms.Padding(4);
            this.DTTerminoReserva.MinimumSize = new System.Drawing.Size(4, 30);
            this.DTTerminoReserva.Name = "DTTerminoReserva";
            this.DTTerminoReserva.Size = new System.Drawing.Size(236, 30);
            this.DTTerminoReserva.TabIndex = 21;
            // 
            // DTInicioReserva
            // 
            this.DTInicioReserva.Location = new System.Drawing.Point(208, 111);
            this.DTInicioReserva.Margin = new System.Windows.Forms.Padding(4);
            this.DTInicioReserva.MinimumSize = new System.Drawing.Size(4, 30);
            this.DTInicioReserva.Name = "DTInicioReserva";
            this.DTInicioReserva.Size = new System.Drawing.Size(236, 30);
            this.DTInicioReserva.TabIndex = 20;
            this.DTInicioReserva.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(559, 320);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(163, 43);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(312, 320);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(163, 43);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 657);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReservas";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Reservas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.tabControl1.ResumeLayout(false);
            this.Listado.ResumeLayout(false);
            this.Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).EndInit();
            this.Agregar.ResumeLayout(false);
            this.Agregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Listado;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DGVListar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private MetroFramework.Controls.MetroDateTime DTInicioReserva;
        private MetroFramework.Controls.MetroDateTime DTTerminoReserva;
        private System.Windows.Forms.TextBox TxtCantPersonas;
        private System.Windows.Forms.Label LblMontoPagado;
        private System.Windows.Forms.Label LblCantidadPersonas;
        private System.Windows.Forms.Label LblTerminoReserva;
        private System.Windows.Forms.Label LblInicioReserva;
        private System.Windows.Forms.TextBox TxtMontoPagado;
        private System.Windows.Forms.TextBox TxtIdReserva;
        private System.Windows.Forms.Label LblIdReserva;
        private System.Windows.Forms.TextBox TxtMontoAbonado;
        private System.Windows.Forms.Label LblIdEstado;
        private System.Windows.Forms.Label LblRutCliente;
        private System.Windows.Forms.Label LblIdDepartamento;
        private System.Windows.Forms.Label LblAbonado;
        private System.Windows.Forms.TextBox TxtIdEstado;
        private System.Windows.Forms.TextBox TxtRutCliente;
        private System.Windows.Forms.TextBox TxtIdDepartamento;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Button BtnCheckIn;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox CbSeleccionar;
    }
}