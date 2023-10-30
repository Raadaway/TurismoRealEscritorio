
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
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.Listado = new System.Windows.Forms.TabPage();
            this.CbSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.BtnCheckIn = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DGVListar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.BtnModificar = new System.Windows.Forms.Button();
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
            this.TabGeneral.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).BeginInit();
            this.Agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.Listado);
            this.TabGeneral.Controls.Add(this.Agregar);
            this.TabGeneral.Location = new System.Drawing.Point(1, 54);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(774, 457);
            this.TabGeneral.TabIndex = 4;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.CbSeleccionar);
            this.Listado.Controls.Add(this.BtnCheckOut);
            this.Listado.Controls.Add(this.BtnCheckIn);
            this.Listado.Controls.Add(this.BtnEliminar);
            this.Listado.Controls.Add(this.LblTotal);
            this.Listado.Controls.Add(this.BtnRefrescar);
            this.Listado.Controls.Add(this.TxtBuscar);
            this.Listado.Controls.Add(this.DGVListar);
            this.Listado.Location = new System.Drawing.Point(4, 22);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(3);
            this.Listado.Size = new System.Drawing.Size(766, 431);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listar";
            this.Listado.UseVisualStyleBackColor = true;
            // 
            // CbSeleccionar
            // 
            this.CbSeleccionar.AutoSize = true;
            this.CbSeleccionar.Location = new System.Drawing.Point(7, 377);
            this.CbSeleccionar.Name = "CbSeleccionar";
            this.CbSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CbSeleccionar.TabIndex = 9;
            this.CbSeleccionar.Text = "Seleccionar";
            this.CbSeleccionar.UseVisualStyleBackColor = true;
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Location = new System.Drawing.Point(650, 16);
            this.BtnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(107, 26);
            this.BtnCheckOut.TabIndex = 8;
            this.BtnCheckOut.Text = "Realizar Check-Out";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.Location = new System.Drawing.Point(538, 16);
            this.BtnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(107, 26);
            this.BtnCheckIn.TabIndex = 7;
            this.BtnCheckIn.Text = "Realizar Check-In";
            this.BtnCheckIn.UseVisualStyleBackColor = true;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(427, 16);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 26);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(613, 384);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total:";
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Location = new System.Drawing.Point(314, 16);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(107, 26);
            this.BtnRefrescar.TabIndex = 4;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(7, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(301, 20);
            this.TxtBuscar.TabIndex = 3;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DGVListar
            // 
            this.DGVListar.AllowUserToAddRows = false;
            this.DGVListar.AllowUserToDeleteRows = false;
            this.DGVListar.AllowUserToOrderColumns = true;
            this.DGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVListar.Location = new System.Drawing.Point(7, 54);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.RowHeadersWidth = 51;
            this.DGVListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListar.Size = new System.Drawing.Size(753, 317);
            this.DGVListar.TabIndex = 0;
            this.DGVListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellContentClick);
            this.DGVListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellDoubleClick);
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
            this.Agregar.Controls.Add(this.BtnModificar);
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
            this.Agregar.Location = new System.Drawing.Point(4, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(766, 431);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(234, 261);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(122, 34);
            this.BtnModificar.TabIndex = 38;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblIdEstado
            // 
            this.LblIdEstado.AutoSize = true;
            this.LblIdEstado.Location = new System.Drawing.Point(419, 178);
            this.LblIdEstado.Name = "LblIdEstado";
            this.LblIdEstado.Size = new System.Drawing.Size(54, 13);
            this.LblIdEstado.TabIndex = 37;
            this.LblIdEstado.Text = "ID Estado";
            // 
            // LblRutCliente
            // 
            this.LblRutCliente.AutoSize = true;
            this.LblRutCliente.Location = new System.Drawing.Point(408, 135);
            this.LblRutCliente.Name = "LblRutCliente";
            this.LblRutCliente.Size = new System.Drawing.Size(65, 13);
            this.LblRutCliente.TabIndex = 36;
            this.LblRutCliente.Text = "RUT Cliente";
            // 
            // LblIdDepartamento
            // 
            this.LblIdDepartamento.AutoSize = true;
            this.LblIdDepartamento.Location = new System.Drawing.Point(385, 96);
            this.LblIdDepartamento.Name = "LblIdDepartamento";
            this.LblIdDepartamento.Size = new System.Drawing.Size(88, 13);
            this.LblIdDepartamento.TabIndex = 35;
            this.LblIdDepartamento.Text = "ID Departamento";
            // 
            // LblAbonado
            // 
            this.LblAbonado.AutoSize = true;
            this.LblAbonado.Location = new System.Drawing.Point(390, 55);
            this.LblAbonado.Name = "LblAbonado";
            this.LblAbonado.Size = new System.Drawing.Size(83, 13);
            this.LblAbonado.TabIndex = 34;
            this.LblAbonado.Text = "Monto Abonado";
            // 
            // TxtIdEstado
            // 
            this.TxtIdEstado.Location = new System.Drawing.Point(479, 175);
            this.TxtIdEstado.Name = "TxtIdEstado";
            this.TxtIdEstado.Size = new System.Drawing.Size(178, 20);
            this.TxtIdEstado.TabIndex = 33;
            // 
            // TxtRutCliente
            // 
            this.TxtRutCliente.Location = new System.Drawing.Point(479, 132);
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.Size = new System.Drawing.Size(178, 20);
            this.TxtRutCliente.TabIndex = 32;
            // 
            // TxtIdDepartamento
            // 
            this.TxtIdDepartamento.Location = new System.Drawing.Point(479, 93);
            this.TxtIdDepartamento.Name = "TxtIdDepartamento";
            this.TxtIdDepartamento.Size = new System.Drawing.Size(178, 20);
            this.TxtIdDepartamento.TabIndex = 31;
            // 
            // TxtMontoAbonado
            // 
            this.TxtMontoAbonado.Location = new System.Drawing.Point(479, 52);
            this.TxtMontoAbonado.Name = "TxtMontoAbonado";
            this.TxtMontoAbonado.Size = new System.Drawing.Size(178, 20);
            this.TxtMontoAbonado.TabIndex = 30;
            // 
            // LblIdReserva
            // 
            this.LblIdReserva.AutoSize = true;
            this.LblIdReserva.Location = new System.Drawing.Point(89, 55);
            this.LblIdReserva.Name = "LblIdReserva";
            this.LblIdReserva.Size = new System.Drawing.Size(61, 13);
            this.LblIdReserva.TabIndex = 29;
            this.LblIdReserva.Text = "ID Reserva";
            // 
            // TxtIdReserva
            // 
            this.TxtIdReserva.Location = new System.Drawing.Point(156, 52);
            this.TxtIdReserva.Name = "TxtIdReserva";
            this.TxtIdReserva.Size = new System.Drawing.Size(178, 20);
            this.TxtIdReserva.TabIndex = 28;
            // 
            // LblMontoPagado
            // 
            this.LblMontoPagado.AutoSize = true;
            this.LblMontoPagado.Location = new System.Drawing.Point(73, 213);
            this.LblMontoPagado.Name = "LblMontoPagado";
            this.LblMontoPagado.Size = new System.Drawing.Size(77, 13);
            this.LblMontoPagado.TabIndex = 27;
            this.LblMontoPagado.Text = "Monto Pagado";
            // 
            // LblCantidadPersonas
            // 
            this.LblCantidadPersonas.AutoSize = true;
            this.LblCantidadPersonas.Location = new System.Drawing.Point(54, 178);
            this.LblCantidadPersonas.Name = "LblCantidadPersonas";
            this.LblCantidadPersonas.Size = new System.Drawing.Size(96, 13);
            this.LblCantidadPersonas.TabIndex = 26;
            this.LblCantidadPersonas.Text = "Cantidad Personas";
            // 
            // LblTerminoReserva
            // 
            this.LblTerminoReserva.AutoSize = true;
            this.LblTerminoReserva.Location = new System.Drawing.Point(62, 143);
            this.LblTerminoReserva.Name = "LblTerminoReserva";
            this.LblTerminoReserva.Size = new System.Drawing.Size(88, 13);
            this.LblTerminoReserva.TabIndex = 25;
            this.LblTerminoReserva.Text = "Termino Reserva";
            // 
            // LblInicioReserva
            // 
            this.LblInicioReserva.AutoSize = true;
            this.LblInicioReserva.Location = new System.Drawing.Point(75, 100);
            this.LblInicioReserva.Name = "LblInicioReserva";
            this.LblInicioReserva.Size = new System.Drawing.Size(75, 13);
            this.LblInicioReserva.TabIndex = 24;
            this.LblInicioReserva.Text = "Inicio Reserva";
            // 
            // TxtMontoPagado
            // 
            this.TxtMontoPagado.Location = new System.Drawing.Point(156, 210);
            this.TxtMontoPagado.Name = "TxtMontoPagado";
            this.TxtMontoPagado.Size = new System.Drawing.Size(178, 20);
            this.TxtMontoPagado.TabIndex = 23;
            // 
            // TxtCantPersonas
            // 
            this.TxtCantPersonas.Location = new System.Drawing.Point(156, 175);
            this.TxtCantPersonas.Name = "TxtCantPersonas";
            this.TxtCantPersonas.Size = new System.Drawing.Size(178, 20);
            this.TxtCantPersonas.TabIndex = 22;
            // 
            // DTTerminoReserva
            // 
            this.DTTerminoReserva.Location = new System.Drawing.Point(156, 133);
            this.DTTerminoReserva.MinimumSize = new System.Drawing.Size(4, 29);
            this.DTTerminoReserva.Name = "DTTerminoReserva";
            this.DTTerminoReserva.Size = new System.Drawing.Size(178, 29);
            this.DTTerminoReserva.TabIndex = 21;
            // 
            // DTInicioReserva
            // 
            this.DTInicioReserva.Location = new System.Drawing.Point(156, 90);
            this.DTInicioReserva.MinimumSize = new System.Drawing.Size(4, 29);
            this.DTInicioReserva.Name = "DTInicioReserva";
            this.DTInicioReserva.Size = new System.Drawing.Size(178, 29);
            this.DTInicioReserva.TabIndex = 20;
            this.DTInicioReserva.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(419, 260);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(122, 35);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(234, 260);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(122, 35);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 534);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmReservas";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Reservas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.TabGeneral.ResumeLayout(false);
            this.Listado.ResumeLayout(false);
            this.Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).EndInit();
            this.Agregar.ResumeLayout(false);
            this.Agregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage Listado;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnRefrescar;
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
        private System.Windows.Forms.Button BtnModificar;
    }
}