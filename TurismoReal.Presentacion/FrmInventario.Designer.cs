
namespace TurismoReal.Presentacion
{
    partial class FrmInventario
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CbSeleccionar = new System.Windows.Forms.CheckBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DGVListar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.ComboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtIdDepartamento = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblIdArticulo = new System.Windows.Forms.Label();
            this.LblIdDepto = new System.Windows.Forms.Label();
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
            this.TabGeneral.Location = new System.Drawing.Point(1, 66);
            this.TabGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1032, 562);
            this.TabGeneral.TabIndex = 3;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.BtnEliminar);
            this.Listado.Controls.Add(this.CbSeleccionar);
            this.Listado.Controls.Add(this.LblTotal);
            this.Listado.Controls.Add(this.BtnRefrescar);
            this.Listado.Controls.Add(this.TxtBuscar);
            this.Listado.Controls.Add(this.DGVListar);
            this.Listado.Location = new System.Drawing.Point(4, 25);
            this.Listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Listado.Size = new System.Drawing.Size(1024, 533);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listar";
            this.Listado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(569, 20);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(143, 32);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CbSeleccionar
            // 
            this.CbSeleccionar.AutoSize = true;
            this.CbSeleccionar.Location = new System.Drawing.Point(9, 464);
            this.CbSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbSeleccionar.Name = "CbSeleccionar";
            this.CbSeleccionar.Size = new System.Drawing.Size(98, 20);
            this.CbSeleccionar.TabIndex = 10;
            this.CbSeleccionar.Text = "Seleccionar";
            this.CbSeleccionar.UseVisualStyleBackColor = true;
            this.CbSeleccionar.CheckedChanged += new System.EventHandler(this.CbSeleccionar_CheckedChanged);
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
            // BtnRefrescar
            // 
            this.BtnRefrescar.Location = new System.Drawing.Point(419, 20);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(143, 32);
            this.BtnRefrescar.TabIndex = 4;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(9, 25);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(400, 22);
            this.TxtBuscar.TabIndex = 3;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
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
            this.DGVListar.Location = new System.Drawing.Point(9, 66);
            this.DGVListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListar.Size = new System.Drawing.Size(1004, 390);
            this.DGVListar.TabIndex = 0;
            this.DGVListar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellClick);
            this.DGVListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellContentClick);
            this.DGVListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.ComboBoxArticulo);
            this.Agregar.Controls.Add(this.BtnModificar);
            this.Agregar.Controls.Add(this.BtnCancelar);
            this.Agregar.Controls.Add(this.BtnAgregar);
            this.Agregar.Controls.Add(this.TxtCantidad);
            this.Agregar.Controls.Add(this.TxtIdDepartamento);
            this.Agregar.Controls.Add(this.LblCantidad);
            this.Agregar.Controls.Add(this.LblIdArticulo);
            this.Agregar.Controls.Add(this.LblIdDepto);
            this.Agregar.Location = new System.Drawing.Point(4, 25);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(1024, 533);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // ComboBoxArticulo
            // 
            this.ComboBoxArticulo.FormattingEnabled = true;
            this.ComboBoxArticulo.Location = new System.Drawing.Point(208, 107);
            this.ComboBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxArticulo.Name = "ComboBoxArticulo";
            this.ComboBoxArticulo.Size = new System.Drawing.Size(236, 24);
            this.ComboBoxArticulo.TabIndex = 21;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(312, 320);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(163, 43);
            this.BtnModificar.TabIndex = 20;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(559, 320);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(163, 43);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(312, 320);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(163, 43);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(208, 151);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(236, 22);
            this.TxtCantidad.TabIndex = 11;
            // 
            // TxtIdDepartamento
            // 
            this.TxtIdDepartamento.Location = new System.Drawing.Point(208, 64);
            this.TxtIdDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIdDepartamento.Name = "TxtIdDepartamento";
            this.TxtIdDepartamento.Size = new System.Drawing.Size(236, 22);
            this.TxtIdDepartamento.TabIndex = 10;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(141, 155);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(61, 16);
            this.LblCantidad.TabIndex = 2;
            this.LblCantidad.Text = "Cantidad";
            this.LblCantidad.Click += new System.EventHandler(this.LblStock_Click);
            // 
            // LblIdArticulo
            // 
            this.LblIdArticulo.AutoSize = true;
            this.LblIdArticulo.Location = new System.Drawing.Point(135, 111);
            this.LblIdArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdArticulo.Name = "LblIdArticulo";
            this.LblIdArticulo.Size = new System.Drawing.Size(65, 16);
            this.LblIdArticulo.TabIndex = 1;
            this.LblIdArticulo.Text = "Id Articulo";
            // 
            // LblIdDepto
            // 
            this.LblIdDepto.AutoSize = true;
            this.LblIdDepto.Location = new System.Drawing.Point(139, 68);
            this.LblIdDepto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdDepto.Name = "LblIdDepto";
            this.LblIdDepto.Size = new System.Drawing.Size(61, 16);
            this.LblIdDepto.TabIndex = 0;
            this.LblIdDepto.Text = "Id Depto.";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 657);
            this.Controls.Add(this.TabGeneral);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInventario";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Inventario";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmInventario_Load);
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
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtIdDepartamento;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblIdArticulo;
        private System.Windows.Forms.Label LblIdDepto;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.CheckBox CbSeleccionar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ComboBox ComboBoxArticulo;
    }
}