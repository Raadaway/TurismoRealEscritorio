﻿
namespace TurismoReal.Presentacion
{
    partial class FrmCheckOut
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboxFormaPago = new MetroFramework.Controls.MetroComboBox();
            this.cbConformidad = new MetroFramework.Controls.MetroCheckBox();
            this.txtIdCheckOut = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.TxtRutFunc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMulta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdReserva = new MetroFramework.Controls.MetroTextBox();
            this.BtnModificar = new MetroFramework.Controls.MetroTile();
            this.BtnCancelar = new MetroFramework.Controls.MetroTile();
            this.BtnAgregar = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
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
            this.TabGeneral.SelectedIndex = 1;
            this.TabGeneral.Size = new System.Drawing.Size(760, 470);
            this.TabGeneral.Style = MetroFramework.MetroColorStyle.Orange;
            this.TabGeneral.TabIndex = 4;
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
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
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
            this.BtnEliminar.Visible = false;
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
            this.TxtBuscar.PromptText = "Buscar por Rut de cliente o funcionario";
            this.TxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.ShortcutsEnabled = true;
            this.TxtBuscar.Size = new System.Drawing.Size(214, 23);
            this.TxtBuscar.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtBuscar.TabIndex = 5;
            this.TxtBuscar.UseSelectable = true;
            this.TxtBuscar.WaterMark = "Buscar por Rut de cliente o funcionario";
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
            this.DGVListar.MultiSelect = false;
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
            this.DGVListar.RowHeadersWidth = 50;
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
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.cboxFormaPago);
            this.metroTabPage2.Controls.Add(this.cbConformidad);
            this.metroTabPage2.Controls.Add(this.txtIdCheckOut);
            this.metroTabPage2.Controls.Add(this.metroTile1);
            this.metroTabPage2.Controls.Add(this.TxtRutFunc);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.txtMulta);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.txtIdReserva);
            this.metroTabPage2.Controls.Add(this.BtnModificar);
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.BtnAgregar);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(230, 266);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(167, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Forma de Pago del cliente";
            // 
            // cboxFormaPago
            // 
            this.cboxFormaPago.FormattingEnabled = true;
            this.cboxFormaPago.ItemHeight = 23;
            this.cboxFormaPago.Location = new System.Drawing.Point(403, 261);
            this.cboxFormaPago.Name = "cboxFormaPago";
            this.cboxFormaPago.Size = new System.Drawing.Size(121, 29);
            this.cboxFormaPago.TabIndex = 34;
            this.cboxFormaPago.UseSelectable = true;
            // 
            // cbConformidad
            // 
            this.cbConformidad.AutoSize = true;
            this.cbConformidad.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbConformidad.Location = new System.Drawing.Point(99, 188);
            this.cbConformidad.Name = "cbConformidad";
            this.cbConformidad.Size = new System.Drawing.Size(215, 38);
            this.cbConformidad.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbConformidad.TabIndex = 32;
            this.cbConformidad.Text = "¿El cliente está de acuerdo\r\ncon la realización del Check-In?";
            this.cbConformidad.UseSelectable = true;
            // 
            // txtIdCheckOut
            // 
            // 
            // 
            // 
            this.txtIdCheckOut.CustomButton.Image = null;
            this.txtIdCheckOut.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtIdCheckOut.CustomButton.Name = "";
            this.txtIdCheckOut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdCheckOut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdCheckOut.CustomButton.TabIndex = 1;
            this.txtIdCheckOut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdCheckOut.CustomButton.UseSelectable = true;
            this.txtIdCheckOut.CustomButton.Visible = false;
            this.txtIdCheckOut.Enabled = false;
            this.txtIdCheckOut.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdCheckOut.Lines = new string[0];
            this.txtIdCheckOut.Location = new System.Drawing.Point(3, 402);
            this.txtIdCheckOut.MaxLength = 32767;
            this.txtIdCheckOut.Name = "txtIdCheckOut";
            this.txtIdCheckOut.PasswordChar = '\0';
            this.txtIdCheckOut.PromptText = "ID Check-Out invisible";
            this.txtIdCheckOut.ReadOnly = true;
            this.txtIdCheckOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdCheckOut.SelectedText = "";
            this.txtIdCheckOut.SelectionLength = 0;
            this.txtIdCheckOut.SelectionStart = 0;
            this.txtIdCheckOut.ShortcutsEnabled = true;
            this.txtIdCheckOut.Size = new System.Drawing.Size(147, 23);
            this.txtIdCheckOut.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtIdCheckOut.TabIndex = 30;
            this.txtIdCheckOut.UseSelectable = true;
            this.txtIdCheckOut.Visible = false;
            this.txtIdCheckOut.WaterMark = "ID Check-Out invisible";
            this.txtIdCheckOut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdCheckOut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(312, 42);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(128, 44);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 29;
            this.metroTile1.Text = "CheckList Artículos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.BtnChecklist_Click);
            // 
            // TxtRutFunc
            // 
            // 
            // 
            // 
            this.TxtRutFunc.CustomButton.Image = null;
            this.TxtRutFunc.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtRutFunc.CustomButton.Name = "";
            this.TxtRutFunc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRutFunc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRutFunc.CustomButton.TabIndex = 1;
            this.TxtRutFunc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRutFunc.CustomButton.UseSelectable = true;
            this.TxtRutFunc.CustomButton.Visible = false;
            this.TxtRutFunc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRutFunc.Lines = new string[0];
            this.TxtRutFunc.Location = new System.Drawing.Point(497, 196);
            this.TxtRutFunc.MaxLength = 32767;
            this.TxtRutFunc.Name = "TxtRutFunc";
            this.TxtRutFunc.PasswordChar = '\0';
            this.TxtRutFunc.PromptText = "RUT del funcionario que realiza el Check-In";
            this.TxtRutFunc.ReadOnly = true;
            this.TxtRutFunc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRutFunc.SelectedText = "";
            this.TxtRutFunc.SelectionLength = 0;
            this.TxtRutFunc.SelectionStart = 0;
            this.TxtRutFunc.ShortcutsEnabled = true;
            this.TxtRutFunc.Size = new System.Drawing.Size(212, 23);
            this.TxtRutFunc.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtRutFunc.TabIndex = 27;
            this.TxtRutFunc.UseSelectable = true;
            this.TxtRutFunc.WaterMark = "RUT del funcionario que realiza el Check-In";
            this.TxtRutFunc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRutFunc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(382, 198);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "RUT Funcionario";
            // 
            // txtMulta
            // 
            // 
            // 
            // 
            this.txtMulta.CustomButton.Image = null;
            this.txtMulta.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtMulta.CustomButton.Name = "";
            this.txtMulta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMulta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMulta.CustomButton.TabIndex = 1;
            this.txtMulta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMulta.CustomButton.UseSelectable = true;
            this.txtMulta.CustomButton.Visible = false;
            this.txtMulta.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMulta.Lines = new string[0];
            this.txtMulta.Location = new System.Drawing.Point(497, 126);
            this.txtMulta.MaxLength = 32767;
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.PasswordChar = '\0';
            this.txtMulta.PromptText = "Total a pagar por el cliente";
            this.txtMulta.ReadOnly = true;
            this.txtMulta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMulta.SelectedText = "";
            this.txtMulta.SelectionLength = 0;
            this.txtMulta.SelectionStart = 0;
            this.txtMulta.ShortcutsEnabled = true;
            this.txtMulta.Size = new System.Drawing.Size(212, 23);
            this.txtMulta.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMulta.TabIndex = 23;
            this.txtMulta.UseSelectable = true;
            this.txtMulta.WaterMark = "Total a pagar por el cliente";
            this.txtMulta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMulta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(403, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Total a Pagar";
            // 
            // txtIdReserva
            // 
            // 
            // 
            // 
            this.txtIdReserva.CustomButton.Image = null;
            this.txtIdReserva.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtIdReserva.CustomButton.Name = "";
            this.txtIdReserva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdReserva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdReserva.CustomButton.TabIndex = 1;
            this.txtIdReserva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdReserva.CustomButton.UseSelectable = true;
            this.txtIdReserva.CustomButton.Visible = false;
            this.txtIdReserva.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdReserva.Lines = new string[0];
            this.txtIdReserva.Location = new System.Drawing.Point(119, 126);
            this.txtIdReserva.MaxLength = 32767;
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.PasswordChar = '\0';
            this.txtIdReserva.PromptText = "ID de la reserva";
            this.txtIdReserva.ReadOnly = true;
            this.txtIdReserva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdReserva.SelectedText = "";
            this.txtIdReserva.SelectionLength = 0;
            this.txtIdReserva.SelectionStart = 0;
            this.txtIdReserva.ShortcutsEnabled = true;
            this.txtIdReserva.Size = new System.Drawing.Size(212, 23);
            this.txtIdReserva.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtIdReserva.TabIndex = 7;
            this.txtIdReserva.UseSelectable = true;
            this.txtIdReserva.WaterMark = "ID de la reserva";
            this.txtIdReserva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdReserva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
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
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(39, 128);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(74, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "ID Reserva";
            // 
            // FrmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.TabGeneral);
            this.MaximizeBox = false;
            this.Name = "FrmCheckOut";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Check Out";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmCheckOut_Load);
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
        private MetroFramework.Controls.MetroTextBox txtIdCheckOut;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox TxtRutFunc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMulta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIdReserva;
        private MetroFramework.Controls.MetroTile BtnModificar;
        private MetroFramework.Controls.MetroTile BtnCancelar;
        private MetroFramework.Controls.MetroTile BtnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox cbConformidad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboxFormaPago;
    }
}