﻿
namespace TurismoReal.Presentacion
{
    partial class FrmMantenimiento
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
            this.BtnRefrescar = new MetroFramework.Controls.MetroButton();
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.TxtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CbSeleccionar = new MetroFramework.Controls.MetroCheckBox();
            this.LblTotal = new MetroFramework.Controls.MetroLabel();
            this.DGVListar = new MetroFramework.Controls.MetroGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtIdDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.DTFechaTermino = new MetroFramework.Controls.MetroDateTime();
            this.DTFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.BtnModificar = new MetroFramework.Controls.MetroTile();
            this.BtnCancelar = new MetroFramework.Controls.MetroTile();
            this.BtnAgregar = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            this.TabGeneral.TabIndex = 3;
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
            // BtnRefrescar
            // 
            this.BtnRefrescar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRefrescar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnRefrescar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnRefrescar.Location = new System.Drawing.Point(289, 0);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.BtnRefrescar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnRefrescar.TabIndex = 6;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseSelectable = true;
            // 
            // BtnEliminar
            // 
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
            this.TxtBuscar.PromptText = "Buscar por Rut o Nombre";
            this.TxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.ShortcutsEnabled = true;
            this.TxtBuscar.Size = new System.Drawing.Size(214, 23);
            this.TxtBuscar.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtBuscar.TabIndex = 5;
            this.TxtBuscar.UseSelectable = true;
            this.TxtBuscar.WaterMark = "Buscar por Rut o Nombre";
            this.TxtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Seleccionar.Width = 125;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.TxtIdDepartamento);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.TxtDescripcion);
            this.metroTabPage2.Controls.Add(this.DTFechaTermino);
            this.metroTabPage2.Controls.Add(this.DTFechaInicio);
            this.metroTabPage2.Controls.Add(this.BtnModificar);
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.BtnAgregar);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(480, 136);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "ID Depto.";
            // 
            // TxtIdDepartamento
            // 
            // 
            // 
            // 
            this.TxtIdDepartamento.CustomButton.Image = null;
            this.TxtIdDepartamento.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.TxtIdDepartamento.CustomButton.Name = "";
            this.TxtIdDepartamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdDepartamento.CustomButton.TabIndex = 1;
            this.TxtIdDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdDepartamento.CustomButton.UseSelectable = true;
            this.TxtIdDepartamento.CustomButton.Visible = false;
            this.TxtIdDepartamento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIdDepartamento.Lines = new string[0];
            this.TxtIdDepartamento.Location = new System.Drawing.Point(554, 136);
            this.TxtIdDepartamento.MaxLength = 32767;
            this.TxtIdDepartamento.Name = "TxtIdDepartamento";
            this.TxtIdDepartamento.PasswordChar = '\0';
            this.TxtIdDepartamento.PromptText = "Ingresar Id del Departamento";
            this.TxtIdDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdDepartamento.SelectedText = "";
            this.TxtIdDepartamento.SelectionLength = 0;
            this.TxtIdDepartamento.SelectionStart = 0;
            this.TxtIdDepartamento.ShortcutsEnabled = true;
            this.TxtIdDepartamento.Size = new System.Drawing.Size(152, 23);
            this.TxtIdDepartamento.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtIdDepartamento.TabIndex = 27;
            this.TxtIdDepartamento.UseSelectable = true;
            this.TxtIdDepartamento.WaterMark = "Ingresar Id del Departamento";
            this.TxtIdDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(451, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Fecha Termino";
            // 
            // TxtDescripcion
            // 
            // 
            // 
            // 
            this.TxtDescripcion.CustomButton.Image = null;
            this.TxtDescripcion.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.TxtDescripcion.CustomButton.Name = "";
            this.TxtDescripcion.CustomButton.Size = new System.Drawing.Size(223, 223);
            this.TxtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescripcion.CustomButton.TabIndex = 1;
            this.TxtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescripcion.CustomButton.UseSelectable = true;
            this.TxtDescripcion.CustomButton.Visible = false;
            this.TxtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtDescripcion.Lines = new string[0];
            this.TxtDescripcion.Location = new System.Drawing.Point(108, 40);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.PromptText = "Ingresar una descripción para el mantenimiento";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.ShortcutsEnabled = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(328, 228);
            this.TxtDescripcion.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtDescripcion.TabIndex = 25;
            this.TxtDescripcion.UseSelectable = true;
            this.TxtDescripcion.WaterMark = "Ingresar una descripción para el mantenimiento";
            this.TxtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DTFechaTermino
            // 
            this.DTFechaTermino.Location = new System.Drawing.Point(554, 86);
            this.DTFechaTermino.MinimumSize = new System.Drawing.Size(4, 29);
            this.DTFechaTermino.Name = "DTFechaTermino";
            this.DTFechaTermino.Size = new System.Drawing.Size(152, 29);
            this.DTFechaTermino.TabIndex = 24;
            // 
            // DTFechaInicio
            // 
            this.DTFechaInicio.Location = new System.Drawing.Point(554, 40);
            this.DTFechaInicio.MinimumSize = new System.Drawing.Size(4, 29);
            this.DTFechaInicio.Name = "DTFechaInicio";
            this.DTFechaInicio.Size = new System.Drawing.Size(152, 29);
            this.DTFechaInicio.TabIndex = 23;
            // 
            // BtnModificar
            // 
            this.BtnModificar.ActiveControl = null;
            this.BtnModificar.Location = new System.Drawing.Point(327, 337);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(99, 44);
            this.BtnModificar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnModificar.TabIndex = 22;
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
            this.BtnCancelar.Location = new System.Drawing.Point(432, 337);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 44);
            this.BtnCancelar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnCancelar.TabIndex = 21;
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
            this.BtnAgregar.Location = new System.Drawing.Point(222, 337);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(99, 44);
            this.BtnAgregar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.BtnAgregar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnAgregar.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(468, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Fecha Inicio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Descripcion";
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmMantenimiento";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Mantenimiento";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            this.TabGeneral.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroButton BtnRefrescar;
        private MetroFramework.Controls.MetroButton BtnEliminar;
        private MetroFramework.Controls.MetroTextBox TxtBuscar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox CbSeleccionar;
        private MetroFramework.Controls.MetroLabel LblTotal;
        private MetroFramework.Controls.MetroGrid DGVListar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtIdDepartamento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtDescripcion;
        private MetroFramework.Controls.MetroDateTime DTFechaTermino;
        private MetroFramework.Controls.MetroDateTime DTFechaInicio;
        private MetroFramework.Controls.MetroTile BtnModificar;
        private MetroFramework.Controls.MetroTile BtnCancelar;
        private MetroFramework.Controls.MetroTile BtnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}