
namespace TurismoReal.Presentacion
{
    partial class FrmDepartamento
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
            this.components = new System.ComponentModel.Container();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.Listado = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CbSeleccionar = new System.Windows.Forms.CheckBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DGVListar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.cBoxComuna = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblIdComuna = new System.Windows.Forms.Label();
            this.LblCantImagenes = new System.Windows.Forms.Label();
            this.TxtCantImagenes = new System.Windows.Forms.TextBox();
            this.TxtCapacidad = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtLatitud = new System.Windows.Forms.TextBox();
            this.TxtLongitud = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblCapacidad = new System.Windows.Forms.Label();
            this.LblLongitud = new System.Windows.Forms.Label();
            this.LblLatitud = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TabGeneral.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.TabGeneral.TabIndex = 2;
            // 
            // Listado
            // 
            this.Listado.Controls.Add(this.BtnEliminar);
            this.Listado.Controls.Add(this.CbSeleccionar);
            this.Listado.Controls.Add(this.LblTotal);
            this.Listado.Controls.Add(this.BtnRefrescar);
            this.Listado.Controls.Add(this.TxtBuscar);
            this.Listado.Controls.Add(this.DGVListar);
            this.Listado.Location = new System.Drawing.Point(4, 22);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Listado.Size = new System.Drawing.Size(766, 431);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listar";
            this.Listado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(427, 16);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 26);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CbSeleccionar
            // 
            this.CbSeleccionar.AutoSize = true;
            this.CbSeleccionar.Location = new System.Drawing.Point(7, 377);
            this.CbSeleccionar.Name = "CbSeleccionar";
            this.CbSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CbSeleccionar.TabIndex = 7;
            this.CbSeleccionar.Text = "Seleccionar";
            this.CbSeleccionar.UseVisualStyleBackColor = true;
            this.CbSeleccionar.CheckedChanged += new System.EventHandler(this.CbSeleccionar_CheckedChanged);
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
            this.DGVListar.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVListar.Location = new System.Drawing.Point(7, 54);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListar.Size = new System.Drawing.Size(753, 317);
            this.DGVListar.TabIndex = 0;
            this.DGVListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellContentClick);
            this.DGVListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMServicios});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // SMServicios
            // 
            this.SMServicios.Name = "SMServicios";
            this.SMServicios.Size = new System.Drawing.Size(120, 22);
            this.SMServicios.Text = "Servicios";
            this.SMServicios.Click += new System.EventHandler(this.SMServicios_Click);
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.cBoxComuna);
            this.Agregar.Controls.Add(this.BtnModificar);
            this.Agregar.Controls.Add(this.LblIdComuna);
            this.Agregar.Controls.Add(this.LblCantImagenes);
            this.Agregar.Controls.Add(this.TxtCantImagenes);
            this.Agregar.Controls.Add(this.TxtCapacidad);
            this.Agregar.Controls.Add(this.LblPrecio);
            this.Agregar.Controls.Add(this.TxtPrecio);
            this.Agregar.Controls.Add(this.BtnCancelar);
            this.Agregar.Controls.Add(this.BtnAgregar);
            this.Agregar.Controls.Add(this.TxtLatitud);
            this.Agregar.Controls.Add(this.TxtLongitud);
            this.Agregar.Controls.Add(this.TxtDescripcion);
            this.Agregar.Controls.Add(this.TxtDireccion);
            this.Agregar.Controls.Add(this.LblDescripcion);
            this.Agregar.Controls.Add(this.LblCapacidad);
            this.Agregar.Controls.Add(this.LblLongitud);
            this.Agregar.Controls.Add(this.LblLatitud);
            this.Agregar.Controls.Add(this.LblDireccion);
            this.Agregar.Location = new System.Drawing.Point(4, 22);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(766, 431);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // cBoxComuna
            // 
            this.cBoxComuna.FormattingEnabled = true;
            this.cBoxComuna.ItemHeight = 13;
            this.cBoxComuna.Location = new System.Drawing.Point(479, 158);
            this.cBoxComuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxComuna.Name = "cBoxComuna";
            this.cBoxComuna.Size = new System.Drawing.Size(178, 21);
            this.cBoxComuna.TabIndex = 35;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(234, 260);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(122, 35);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblIdComuna
            // 
            this.LblIdComuna.AutoSize = true;
            this.LblIdComuna.Location = new System.Drawing.Point(413, 162);
            this.LblIdComuna.Name = "LblIdComuna";
            this.LblIdComuna.Size = new System.Drawing.Size(60, 13);
            this.LblIdComuna.TabIndex = 34;
            this.LblIdComuna.Text = "ID Comuna";
            // 
            // LblCantImagenes
            // 
            this.LblCantImagenes.AutoSize = true;
            this.LblCantImagenes.Location = new System.Drawing.Point(392, 126);
            this.LblCantImagenes.Name = "LblCantImagenes";
            this.LblCantImagenes.Size = new System.Drawing.Size(81, 13);
            this.LblCantImagenes.TabIndex = 33;
            this.LblCantImagenes.Text = "Cant. Imagenes";
            // 
            // TxtCantImagenes
            // 
            this.TxtCantImagenes.Location = new System.Drawing.Point(479, 123);
            this.TxtCantImagenes.Name = "TxtCantImagenes";
            this.TxtCantImagenes.Size = new System.Drawing.Size(178, 20);
            this.TxtCantImagenes.TabIndex = 6;
            // 
            // TxtCapacidad
            // 
            this.TxtCapacidad.Location = new System.Drawing.Point(479, 87);
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.Size = new System.Drawing.Size(178, 20);
            this.TxtCapacidad.TabIndex = 5;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(113, 126);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 23;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(156, 124);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(178, 20);
            this.TxtPrecio.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(419, 260);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(122, 35);
            this.BtnCancelar.TabIndex = 9;
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
            // TxtLatitud
            // 
            this.TxtLatitud.Location = new System.Drawing.Point(156, 159);
            this.TxtLatitud.Name = "TxtLatitud";
            this.TxtLatitud.Size = new System.Drawing.Size(178, 20);
            this.TxtLatitud.TabIndex = 3;
            // 
            // TxtLongitud
            // 
            this.TxtLongitud.Location = new System.Drawing.Point(479, 52);
            this.TxtLongitud.Name = "TxtLongitud";
            this.TxtLongitud.Size = new System.Drawing.Size(178, 20);
            this.TxtLongitud.TabIndex = 4;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(156, 87);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(178, 20);
            this.TxtDescripcion.TabIndex = 1;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(156, 52);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(178, 20);
            this.TxtDireccion.TabIndex = 0;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(87, 90);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 6;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblCapacidad
            // 
            this.LblCapacidad.AutoSize = true;
            this.LblCapacidad.Location = new System.Drawing.Point(412, 90);
            this.LblCapacidad.Name = "LblCapacidad";
            this.LblCapacidad.Size = new System.Drawing.Size(61, 13);
            this.LblCapacidad.TabIndex = 5;
            this.LblCapacidad.Text = "Capacidad ";
            // 
            // LblLongitud
            // 
            this.LblLongitud.AutoSize = true;
            this.LblLongitud.Location = new System.Drawing.Point(425, 55);
            this.LblLongitud.Name = "LblLongitud";
            this.LblLongitud.Size = new System.Drawing.Size(48, 13);
            this.LblLongitud.TabIndex = 3;
            this.LblLongitud.Text = "Longitud";
            // 
            // LblLatitud
            // 
            this.LblLatitud.AutoSize = true;
            this.LblLatitud.Location = new System.Drawing.Point(111, 162);
            this.LblLatitud.Name = "LblLatitud";
            this.LblLatitud.Size = new System.Drawing.Size(39, 13);
            this.LblLatitud.TabIndex = 2;
            this.LblLatitud.Text = "Latitud";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(102, 55);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 1;
            this.LblDireccion.Text = "Dirección";
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 534);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmDepartamento";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Departamentos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            this.TabGeneral.ResumeLayout(false);
            this.Listado.ResumeLayout(false);
            this.Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox TxtLatitud;
        private System.Windows.Forms.TextBox TxtLongitud;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblCapacidad;
        private System.Windows.Forms.Label LblLongitud;
        private System.Windows.Forms.Label LblLatitud;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCapacidad;
        private System.Windows.Forms.Label LblIdComuna;
        private System.Windows.Forms.Label LblCantImagenes;
        private System.Windows.Forms.TextBox TxtCantImagenes;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.CheckBox CbSeleccionar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SMServicios;
        private System.Windows.Forms.ComboBox cBoxComuna;
    }
}