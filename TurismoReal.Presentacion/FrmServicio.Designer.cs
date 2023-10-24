
namespace TurismoReal.Presentacion
{
    partial class FrmServicio
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DGVListar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.LblIDDepartamento = new System.Windows.Forms.Label();
            this.TxtIdDepartamento = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CheckBoxPiscina = new System.Windows.Forms.CheckBox();
            this.CheckBoxAire = new System.Windows.Forms.CheckBox();
            this.CheckBoxParking = new System.Windows.Forms.CheckBox();
            this.CheckBoxLavadora = new System.Windows.Forms.CheckBox();
            this.CheckBoxWifi = new System.Windows.Forms.CheckBox();
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
            this.TabGeneral.TabIndex = 5;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.CbSeleccionar);
            this.Listado.Controls.Add(this.BtnEliminar);
            this.Listado.Controls.Add(this.LblTotal);
            this.Listado.Controls.Add(this.BtnBuscar);
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
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(427, 16);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 26);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
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
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(314, 16);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(107, 26);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(7, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(301, 20);
            this.TxtBuscar.TabIndex = 3;
            // 
            // DGVListar
            // 
            this.DGVListar.AllowUserToAddRows = false;
            this.DGVListar.AllowUserToDeleteRows = false;
            this.DGVListar.AllowUserToOrderColumns = true;
            this.DGVListar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVListar.Location = new System.Drawing.Point(7, 54);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListar.Size = new System.Drawing.Size(753, 317);
            this.DGVListar.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.CheckBoxWifi);
            this.Agregar.Controls.Add(this.CheckBoxLavadora);
            this.Agregar.Controls.Add(this.CheckBoxParking);
            this.Agregar.Controls.Add(this.CheckBoxAire);
            this.Agregar.Controls.Add(this.CheckBoxPiscina);
            this.Agregar.Controls.Add(this.LblIDDepartamento);
            this.Agregar.Controls.Add(this.TxtIdDepartamento);
            this.Agregar.Controls.Add(this.BtnModificar);
            this.Agregar.Controls.Add(this.BtnCancelar);
            this.Agregar.Controls.Add(this.BtnAgregar);
            this.Agregar.Location = new System.Drawing.Point(4, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(766, 431);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // LblIDDepartamento
            // 
            this.LblIDDepartamento.AutoSize = true;
            this.LblIDDepartamento.Location = new System.Drawing.Point(62, 55);
            this.LblIDDepartamento.Name = "LblIDDepartamento";
            this.LblIDDepartamento.Size = new System.Drawing.Size(88, 13);
            this.LblIDDepartamento.TabIndex = 23;
            this.LblIDDepartamento.Text = "ID Departamento";
            // 
            // TxtIdDepartamento
            // 
            this.TxtIdDepartamento.Location = new System.Drawing.Point(156, 52);
            this.TxtIdDepartamento.Name = "TxtIdDepartamento";
            this.TxtIdDepartamento.Size = new System.Drawing.Size(178, 20);
            this.TxtIdDepartamento.TabIndex = 22;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(234, 301);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(122, 35);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
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
            // CheckBoxPiscina
            // 
            this.CheckBoxPiscina.AutoSize = true;
            this.CheckBoxPiscina.Location = new System.Drawing.Point(156, 96);
            this.CheckBoxPiscina.Name = "CheckBoxPiscina";
            this.CheckBoxPiscina.Size = new System.Drawing.Size(60, 17);
            this.CheckBoxPiscina.TabIndex = 24;
            this.CheckBoxPiscina.Text = "Piscina";
            this.CheckBoxPiscina.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAire
            // 
            this.CheckBoxAire.AutoSize = true;
            this.CheckBoxAire.Location = new System.Drawing.Point(234, 96);
            this.CheckBoxAire.Name = "CheckBoxAire";
            this.CheckBoxAire.Size = new System.Drawing.Size(118, 17);
            this.CheckBoxAire.TabIndex = 25;
            this.CheckBoxAire.Text = "Aire Acondicionado";
            this.CheckBoxAire.UseVisualStyleBackColor = true;
            // 
            // CheckBoxParking
            // 
            this.CheckBoxParking.AutoSize = true;
            this.CheckBoxParking.Location = new System.Drawing.Point(156, 130);
            this.CheckBoxParking.Name = "CheckBoxParking";
            this.CheckBoxParking.Size = new System.Drawing.Size(62, 17);
            this.CheckBoxParking.TabIndex = 26;
            this.CheckBoxParking.Text = "Parking";
            this.CheckBoxParking.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLavadora
            // 
            this.CheckBoxLavadora.AutoSize = true;
            this.CheckBoxLavadora.Location = new System.Drawing.Point(234, 130);
            this.CheckBoxLavadora.Name = "CheckBoxLavadora";
            this.CheckBoxLavadora.Size = new System.Drawing.Size(71, 17);
            this.CheckBoxLavadora.TabIndex = 27;
            this.CheckBoxLavadora.Text = "Lavadora";
            this.CheckBoxLavadora.UseVisualStyleBackColor = true;
            // 
            // CheckBoxWifi
            // 
            this.CheckBoxWifi.AutoSize = true;
            this.CheckBoxWifi.Location = new System.Drawing.Point(156, 164);
            this.CheckBoxWifi.Name = "CheckBoxWifi";
            this.CheckBoxWifi.Size = new System.Drawing.Size(50, 17);
            this.CheckBoxWifi.TabIndex = 28;
            this.CheckBoxWifi.Text = "Wi-Fi";
            this.CheckBoxWifi.UseVisualStyleBackColor = true;
            // 
            // FrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 534);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmServicio";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Servicios";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmServicio_Load);
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
        private System.Windows.Forms.CheckBox CbSeleccionar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DGVListar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.Label LblIDDepartamento;
        private System.Windows.Forms.TextBox TxtIdDepartamento;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.CheckBox CheckBoxParking;
        private System.Windows.Forms.CheckBox CheckBoxAire;
        private System.Windows.Forms.CheckBox CheckBoxPiscina;
        private System.Windows.Forms.CheckBox CheckBoxLavadora;
        private System.Windows.Forms.CheckBox CheckBoxWifi;
    }
}