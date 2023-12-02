﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabGeneral = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.BtnAgregarInventario = new MetroFramework.Controls.MetroButton();
            this.BtnAgregarServicios = new MetroFramework.Controls.MetroButton();
            this.BtnRefrescar = new MetroFramework.Controls.MetroButton();
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.TxtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CbSeleccionar = new MetroFramework.Controls.MetroCheckBox();
            this.LblTotal = new MetroFramework.Controls.MetroLabel();
            this.DGVListar = new MetroFramework.Controls.MetroGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnImagenes = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMapa = new MetroFramework.Controls.MetroTile();
            this.BtnModificar = new MetroFramework.Controls.MetroTile();
            this.BtnCancelar = new MetroFramework.Controls.MetroTile();
            this.BtnAgregar = new MetroFramework.Controls.MetroTile();
            this.TxtIdDepa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtHabitaciones = new MetroFramework.Controls.MetroTextBox();
            this.cBoxComuna = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.TxtCapacidad = new MetroFramework.Controls.MetroTextBox();
            this.TxtLongitud = new MetroFramework.Controls.MetroTextBox();
            this.TxtLatitud = new MetroFramework.Controls.MetroTextBox();
            this.TxtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.TxtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.TabGeneral.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.metroTabPage1);
            this.TabGeneral.Controls.Add(this.metroTabPage2);
            this.TabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabGeneral.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.TabGeneral.Location = new System.Drawing.Point(20, 60);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(760, 470);
            this.TabGeneral.Style = MetroFramework.MetroColorStyle.Orange;
            this.TabGeneral.TabIndex = 2;
            this.TabGeneral.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.DGVListar);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 428);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Lista";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.BtnAgregarInventario);
            this.metroPanel2.Controls.Add(this.BtnAgregarServicios);
            this.metroPanel2.Controls.Add(this.BtnRefrescar);
            this.metroPanel2.Controls.Add(this.BtnEliminar);
            this.metroPanel2.Controls.Add(this.TxtBuscar);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(752, 23);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // BtnAgregarInventario
            // 
            this.BtnAgregarInventario.AutoSize = true;
            this.BtnAgregarInventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAgregarInventario.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAgregarInventario.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnAgregarInventario.Location = new System.Drawing.Point(488, 0);
            this.BtnAgregarInventario.Name = "BtnAgregarInventario";
            this.BtnAgregarInventario.Size = new System.Drawing.Size(127, 23);
            this.BtnAgregarInventario.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnAgregarInventario.TabIndex = 9;
            this.BtnAgregarInventario.Text = "Agregar inventario";
            this.BtnAgregarInventario.UseSelectable = true;
            this.BtnAgregarInventario.Click += new System.EventHandler(this.BtnAgregarInventario_Click);
            // 
            // BtnAgregarServicios
            // 
            this.BtnAgregarServicios.AutoSize = true;
            this.BtnAgregarServicios.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAgregarServicios.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAgregarServicios.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnAgregarServicios.Location = new System.Drawing.Point(365, 0);
            this.BtnAgregarServicios.Name = "BtnAgregarServicios";
            this.BtnAgregarServicios.Size = new System.Drawing.Size(123, 23);
            this.BtnAgregarServicios.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnAgregarServicios.TabIndex = 8;
            this.BtnAgregarServicios.Text = "Agregar servicios";
            this.BtnAgregarServicios.UseSelectable = true;
            this.BtnAgregarServicios.Click += new System.EventHandler(this.BtnAgregarServicios_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.AutoSize = true;
            this.BtnRefrescar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRefrescar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnRefrescar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnRefrescar.Location = new System.Drawing.Point(289, 0);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(76, 23);
            this.BtnRefrescar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnRefrescar.TabIndex = 6;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseSelectable = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnEliminar.Location = new System.Drawing.Point(214, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseSelectable = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBuscar
            // 
            // 
            // 
            // 
            this.TxtBuscar.CustomButton.Image = null;
            this.TxtBuscar.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.TxtBuscar.CustomButton.Name = "";
            this.TxtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBuscar.CustomButton.TabIndex = 1;
            this.TxtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBuscar.CustomButton.UseSelectable = true;
            this.TxtBuscar.CustomButton.Visible = false;
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtBuscar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtBuscar.Lines = new string[0];
            this.TxtBuscar.Location = new System.Drawing.Point(0, 0);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PromptText = "Buscar por ID o dirección";
            this.TxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.ShortcutsEnabled = true;
            this.TxtBuscar.Size = new System.Drawing.Size(214, 23);
            this.TxtBuscar.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtBuscar.TabIndex = 5;
            this.TxtBuscar.UseSelectable = true;
            this.TxtBuscar.WaterMark = "Buscar por ID o dirección";
            this.TxtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyUp);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.CbSeleccionar);
            this.metroPanel1.Controls.Add(this.LblTotal);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 406);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(752, 22);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CbSeleccionar
            // 
            this.CbSeleccionar.AutoSize = true;
            this.CbSeleccionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbSeleccionar.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.CbSeleccionar.Location = new System.Drawing.Point(0, 0);
            this.CbSeleccionar.Name = "CbSeleccionar";
            this.CbSeleccionar.Size = new System.Drawing.Size(92, 22);
            this.CbSeleccionar.Style = MetroFramework.MetroColorStyle.Orange;
            this.CbSeleccionar.TabIndex = 3;
            this.CbSeleccionar.Text = "Seleccionar";
            this.CbSeleccionar.UseSelectable = true;
            this.CbSeleccionar.CheckedChanged += new System.EventHandler(this.CbSeleccionar_CheckedChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblTotal.Location = new System.Drawing.Point(711, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 19);
            this.LblTotal.Style = MetroFramework.MetroColorStyle.Orange;
            this.LblTotal.TabIndex = 4;
            this.LblTotal.Text = "Total:";
            // 
            // DGVListar
            // 
            this.DGVListar.AllowUserToAddRows = false;
            this.DGVListar.AllowUserToDeleteRows = false;
            this.DGVListar.AllowUserToOrderColumns = true;
            this.DGVListar.AllowUserToResizeRows = false;
            this.DGVListar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVListar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVListar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVListar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListar.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListar.EnableHeadersVisualStyles = false;
            this.DGVListar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVListar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVListar.Location = new System.Drawing.Point(0, 29);
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListar.RowHeadersWidth = 51;
            this.DGVListar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListar.Size = new System.Drawing.Size(752, 371);
            this.DGVListar.Style = MetroFramework.MetroColorStyle.Orange;
            this.DGVListar.TabIndex = 2;
            this.DGVListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellContentClick);
            this.DGVListar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListar_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Width = 70;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnImagenes);
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel);
            this.metroTabPage2.Controls.Add(this.btnMapa);
            this.metroTabPage2.Controls.Add(this.BtnModificar);
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.BtnAgregar);
            this.metroTabPage2.Controls.Add(this.TxtIdDepa);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.TxtHabitaciones);
            this.metroTabPage2.Controls.Add(this.cBoxComuna);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.TxtDescripcion);
            this.metroTabPage2.Controls.Add(this.TxtCapacidad);
            this.metroTabPage2.Controls.Add(this.TxtLongitud);
            this.metroTabPage2.Controls.Add(this.TxtLatitud);
            this.metroTabPage2.Controls.Add(this.TxtPrecio);
            this.metroTabPage2.Controls.Add(this.TxtDireccion);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 428);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Agregar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnImagenes
            // 
            this.btnImagenes.ActiveControl = null;
            this.btnImagenes.Location = new System.Drawing.Point(31, 302);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(105, 44);
            this.btnImagenes.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnImagenes.TabIndex = 41;
            this.btnImagenes.Text = "Subir Imagenes";
            this.btnImagenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImagenes.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnImagenes.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnImagenes.UseSelectable = true;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Location = new System.Drawing.Point(142, 302);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(585, 44);
            this.flowLayoutPanel.TabIndex = 40;
            // 
            // btnMapa
            // 
            this.btnMapa.ActiveControl = null;
            this.btnMapa.Location = new System.Drawing.Point(193, 81);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(99, 44);
            this.btnMapa.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnMapa.TabIndex = 30;
            this.btnMapa.Text = "Abrir Mapa";
            this.btnMapa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMapa.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnMapa.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMapa.UseSelectable = true;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.ActiveControl = null;
            this.BtnModificar.Location = new System.Drawing.Point(327, 359);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(99, 44);
            this.BtnModificar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnModificar.TabIndex = 29;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.BtnModificar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnModificar.UseSelectable = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ActiveControl = null;
            this.BtnCancelar.Location = new System.Drawing.Point(432, 359);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 44);
            this.BtnCancelar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnCancelar.TabIndex = 28;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.BtnCancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnCancelar.UseSelectable = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ActiveControl = null;
            this.BtnAgregar.Location = new System.Drawing.Point(222, 359);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(99, 44);
            this.BtnAgregar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.BtnAgregar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtIdDepa
            // 
            // 
            // 
            // 
            this.TxtIdDepa.CustomButton.Image = null;
            this.TxtIdDepa.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.TxtIdDepa.CustomButton.Name = "";
            this.TxtIdDepa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdDepa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdDepa.CustomButton.TabIndex = 1;
            this.TxtIdDepa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdDepa.CustomButton.UseSelectable = true;
            this.TxtIdDepa.CustomButton.Visible = false;
            this.TxtIdDepa.Enabled = false;
            this.TxtIdDepa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIdDepa.Lines = new string[0];
            this.TxtIdDepa.Location = new System.Drawing.Point(0, 359);
            this.TxtIdDepa.MaxLength = 32767;
            this.TxtIdDepa.Name = "TxtIdDepa";
            this.TxtIdDepa.PasswordChar = '\0';
            this.TxtIdDepa.PromptText = "ID Depa invisible";
            this.TxtIdDepa.ReadOnly = true;
            this.TxtIdDepa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdDepa.SelectedText = "";
            this.TxtIdDepa.SelectionLength = 0;
            this.TxtIdDepa.SelectionStart = 0;
            this.TxtIdDepa.ShortcutsEnabled = true;
            this.TxtIdDepa.Size = new System.Drawing.Size(152, 23);
            this.TxtIdDepa.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtIdDepa.TabIndex = 26;
            this.TxtIdDepa.TabStop = false;
            this.TxtIdDepa.UseSelectable = true;
            this.TxtIdDepa.Visible = false;
            this.TxtIdDepa.WaterMark = "ID Depa invisible";
            this.TxtIdDepa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdDepa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(14, 227);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Cant. Habitaciones";
            // 
            // TxtHabitaciones
            // 
            // 
            // 
            // 
            this.TxtHabitaciones.CustomButton.Image = null;
            this.TxtHabitaciones.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtHabitaciones.CustomButton.Name = "";
            this.TxtHabitaciones.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtHabitaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtHabitaciones.CustomButton.TabIndex = 1;
            this.TxtHabitaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtHabitaciones.CustomButton.UseSelectable = true;
            this.TxtHabitaciones.CustomButton.Visible = false;
            this.TxtHabitaciones.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtHabitaciones.Lines = new string[0];
            this.TxtHabitaciones.Location = new System.Drawing.Point(143, 225);
            this.TxtHabitaciones.MaxLength = 32767;
            this.TxtHabitaciones.Name = "TxtHabitaciones";
            this.TxtHabitaciones.PasswordChar = '\0';
            this.TxtHabitaciones.PromptText = "Ingresar cantidad de habitaciones";
            this.TxtHabitaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtHabitaciones.SelectedText = "";
            this.TxtHabitaciones.SelectionLength = 0;
            this.TxtHabitaciones.SelectionStart = 0;
            this.TxtHabitaciones.ShortcutsEnabled = true;
            this.TxtHabitaciones.Size = new System.Drawing.Size(204, 23);
            this.TxtHabitaciones.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtHabitaciones.TabIndex = 24;
            this.TxtHabitaciones.UseSelectable = true;
            this.TxtHabitaciones.WaterMark = "Ingresar cantidad de habitaciones";
            this.TxtHabitaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtHabitaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtHabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // cBoxComuna
            // 
            this.cBoxComuna.DropDownHeight = 150;
            this.cBoxComuna.FormattingEnabled = true;
            this.cBoxComuna.IntegralHeight = false;
            this.cBoxComuna.ItemHeight = 23;
            this.cBoxComuna.Location = new System.Drawing.Point(143, 260);
            this.cBoxComuna.Name = "cBoxComuna";
            this.cBoxComuna.Size = new System.Drawing.Size(204, 29);
            this.cBoxComuna.Style = MetroFramework.MetroColorStyle.Orange;
            this.cBoxComuna.TabIndex = 23;
            this.cBoxComuna.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(515, 17);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(79, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Descripción";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(76, 265);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Comuna";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(65, 189);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Capacidad";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(91, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Precio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(72, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Dirección";
            // 
            // TxtDescripcion
            // 
            // 
            // 
            // 
            this.TxtDescripcion.CustomButton.Image = null;
            this.TxtDescripcion.CustomButton.Location = new System.Drawing.Point(98, 2);
            this.TxtDescripcion.CustomButton.Name = "";
            this.TxtDescripcion.CustomButton.Size = new System.Drawing.Size(245, 245);
            this.TxtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescripcion.CustomButton.TabIndex = 1;
            this.TxtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescripcion.CustomButton.UseSelectable = true;
            this.TxtDescripcion.CustomButton.Visible = false;
            this.TxtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtDescripcion.Lines = new string[0];
            this.TxtDescripcion.Location = new System.Drawing.Point(381, 39);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.PromptText = "Ingresar una descripción para el departamento";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.ShortcutsEnabled = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(346, 250);
            this.TxtDescripcion.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtDescripcion.TabIndex = 9;
            this.TxtDescripcion.UseSelectable = true;
            this.TxtDescripcion.WaterMark = "Ingresar una descripción para el departamento";
            this.TxtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtCapacidad
            // 
            // 
            // 
            // 
            this.TxtCapacidad.CustomButton.Image = null;
            this.TxtCapacidad.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtCapacidad.CustomButton.Name = "";
            this.TxtCapacidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCapacidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCapacidad.CustomButton.TabIndex = 1;
            this.TxtCapacidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCapacidad.CustomButton.UseSelectable = true;
            this.TxtCapacidad.CustomButton.Visible = false;
            this.TxtCapacidad.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtCapacidad.Lines = new string[0];
            this.TxtCapacidad.Location = new System.Drawing.Point(143, 187);
            this.TxtCapacidad.MaxLength = 32767;
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.PasswordChar = '\0';
            this.TxtCapacidad.PromptText = "Establecer capacidad de personas";
            this.TxtCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCapacidad.SelectedText = "";
            this.TxtCapacidad.SelectionLength = 0;
            this.TxtCapacidad.SelectionStart = 0;
            this.TxtCapacidad.ShortcutsEnabled = true;
            this.TxtCapacidad.Size = new System.Drawing.Size(204, 23);
            this.TxtCapacidad.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtCapacidad.TabIndex = 6;
            this.TxtCapacidad.UseSelectable = true;
            this.TxtCapacidad.WaterMark = "Establecer capacidad de personas";
            this.TxtCapacidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCapacidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TxtLongitud
            // 
            // 
            // 
            // 
            this.TxtLongitud.CustomButton.Image = null;
            this.TxtLongitud.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.TxtLongitud.CustomButton.Name = "";
            this.TxtLongitud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLongitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLongitud.CustomButton.TabIndex = 1;
            this.TxtLongitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLongitud.CustomButton.UseSelectable = true;
            this.TxtLongitud.CustomButton.Visible = false;
            this.TxtLongitud.Enabled = false;
            this.TxtLongitud.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtLongitud.Lines = new string[0];
            this.TxtLongitud.Location = new System.Drawing.Point(0, 405);
            this.TxtLongitud.MaxLength = 32767;
            this.TxtLongitud.Name = "TxtLongitud";
            this.TxtLongitud.PasswordChar = '\0';
            this.TxtLongitud.PromptText = "Ingresar longitud";
            this.TxtLongitud.ReadOnly = true;
            this.TxtLongitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLongitud.SelectedText = "";
            this.TxtLongitud.SelectionLength = 0;
            this.TxtLongitud.SelectionStart = 0;
            this.TxtLongitud.ShortcutsEnabled = true;
            this.TxtLongitud.Size = new System.Drawing.Size(152, 23);
            this.TxtLongitud.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtLongitud.TabIndex = 5;
            this.TxtLongitud.UseSelectable = true;
            this.TxtLongitud.Visible = false;
            this.TxtLongitud.WaterMark = "Ingresar longitud";
            this.TxtLongitud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLongitud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtLatitud
            // 
            // 
            // 
            // 
            this.TxtLatitud.CustomButton.Image = null;
            this.TxtLatitud.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.TxtLatitud.CustomButton.Name = "";
            this.TxtLatitud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLatitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLatitud.CustomButton.TabIndex = 1;
            this.TxtLatitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLatitud.CustomButton.UseSelectable = true;
            this.TxtLatitud.CustomButton.Visible = false;
            this.TxtLatitud.Enabled = false;
            this.TxtLatitud.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtLatitud.Lines = new string[0];
            this.TxtLatitud.Location = new System.Drawing.Point(0, 382);
            this.TxtLatitud.MaxLength = 32767;
            this.TxtLatitud.Name = "TxtLatitud";
            this.TxtLatitud.PasswordChar = '\0';
            this.TxtLatitud.PromptText = "Ingresar latitud";
            this.TxtLatitud.ReadOnly = true;
            this.TxtLatitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLatitud.SelectedText = "";
            this.TxtLatitud.SelectionLength = 0;
            this.TxtLatitud.SelectionStart = 0;
            this.TxtLatitud.ShortcutsEnabled = true;
            this.TxtLatitud.Size = new System.Drawing.Size(152, 23);
            this.TxtLatitud.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtLatitud.TabIndex = 4;
            this.TxtLatitud.UseSelectable = true;
            this.TxtLatitud.Visible = false;
            this.TxtLatitud.WaterMark = "Ingresar latitud";
            this.TxtLatitud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLatitud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPrecio
            // 
            // 
            // 
            // 
            this.TxtPrecio.CustomButton.Image = null;
            this.TxtPrecio.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtPrecio.CustomButton.Name = "";
            this.TxtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrecio.CustomButton.TabIndex = 1;
            this.TxtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrecio.CustomButton.UseSelectable = true;
            this.TxtPrecio.CustomButton.Visible = false;
            this.TxtPrecio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPrecio.Lines = new string[0];
            this.TxtPrecio.Location = new System.Drawing.Point(143, 149);
            this.TxtPrecio.MaxLength = 32767;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.PasswordChar = '\0';
            this.TxtPrecio.PromptText = "Ingresar precio";
            this.TxtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrecio.SelectedText = "";
            this.TxtPrecio.SelectionLength = 0;
            this.TxtPrecio.SelectionStart = 0;
            this.TxtPrecio.ShortcutsEnabled = true;
            this.TxtPrecio.Size = new System.Drawing.Size(204, 23);
            this.TxtPrecio.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtPrecio.TabIndex = 3;
            this.TxtPrecio.UseSelectable = true;
            this.TxtPrecio.WaterMark = "Ingresar precio";
            this.TxtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TxtDireccion
            // 
            // 
            // 
            // 
            this.TxtDireccion.CustomButton.Image = null;
            this.TxtDireccion.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtDireccion.CustomButton.Name = "";
            this.TxtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDireccion.CustomButton.TabIndex = 1;
            this.TxtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDireccion.CustomButton.UseSelectable = true;
            this.TxtDireccion.CustomButton.Visible = false;
            this.TxtDireccion.Enabled = false;
            this.TxtDireccion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtDireccion.Lines = new string[0];
            this.TxtDireccion.Location = new System.Drawing.Point(143, 39);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.PromptText = "Ingresar dirección";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.ShortcutsEnabled = true;
            this.TxtDireccion.Size = new System.Drawing.Size(204, 23);
            this.TxtDireccion.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtDireccion.TabIndex = 2;
            this.TxtDireccion.UseSelectable = true;
            this.TxtDireccion.WaterMark = "Ingresar dirección";
            this.TxtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.TabGeneral);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartamento";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Departamentos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            this.TabGeneral.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListar)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabGeneral;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton BtnAgregarInventario;
        private MetroFramework.Controls.MetroButton BtnAgregarServicios;
        private MetroFramework.Controls.MetroButton BtnRefrescar;
        private MetroFramework.Controls.MetroButton BtnEliminar;
        private MetroFramework.Controls.MetroTextBox TxtBuscar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox CbSeleccionar;
        private MetroFramework.Controls.MetroLabel LblTotal;
        private MetroFramework.Controls.MetroGrid DGVListar;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtDescripcion;
        private MetroFramework.Controls.MetroTextBox TxtCapacidad;
        private MetroFramework.Controls.MetroTextBox TxtLongitud;
        private MetroFramework.Controls.MetroTextBox TxtLatitud;
        private MetroFramework.Controls.MetroTextBox TxtPrecio;
        private MetroFramework.Controls.MetroTextBox TxtDireccion;
        private MetroFramework.Controls.MetroComboBox cBoxComuna;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtHabitaciones;
        private MetroFramework.Controls.MetroTextBox TxtIdDepa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private MetroFramework.Controls.MetroTile BtnModificar;
        private MetroFramework.Controls.MetroTile BtnCancelar;
        private MetroFramework.Controls.MetroTile BtnAgregar;
        private MetroFramework.Controls.MetroTile btnMapa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private MetroFramework.Controls.MetroTile btnImagenes;
    }
}