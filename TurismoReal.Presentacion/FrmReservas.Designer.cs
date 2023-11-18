
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TxtMontoAbonado = new MetroFramework.Controls.MetroTextBox();
            this.TxtRutCliente = new MetroFramework.Controls.MetroTextBox();
            this.BtnModificar = new MetroFramework.Controls.MetroTile();
            this.BtnCancelar = new MetroFramework.Controls.MetroTile();
            this.BtnAgregar = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtMontoTotal = new MetroFramework.Controls.MetroTextBox();
            this.TxtCantPersonas = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdReserva = new MetroFramework.Controls.MetroTextBox();
            this.DTInicioReserva = new MetroFramework.Controls.MetroDateTime();
            this.DTTerminoReserva = new MetroFramework.Controls.MetroDateTime();
            this.BtnCheckIn = new MetroFramework.Controls.MetroButton();
            this.BtnCheckOut = new MetroFramework.Controls.MetroButton();
            this.TxtIdDepartamento = new MetroFramework.Controls.MetroTextBox();
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
            this.metroPanel2.Controls.Add(this.BtnCheckOut);
            this.metroPanel2.Controls.Add(this.BtnCheckIn);
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
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListar.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListar.EnableHeadersVisualStyles = false;
            this.DGVListar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVListar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVListar.Location = new System.Drawing.Point(0, 29);
            this.DGVListar.MultiSelect = false;
            this.DGVListar.Name = "DGVListar";
            this.DGVListar.ReadOnly = true;
            this.DGVListar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.metroTabPage2.Controls.Add(this.DTTerminoReserva);
            this.metroTabPage2.Controls.Add(this.DTInicioReserva);
            this.metroTabPage2.Controls.Add(this.TxtMontoAbonado);
            this.metroTabPage2.Controls.Add(this.TxtIdDepartamento);
            this.metroTabPage2.Controls.Add(this.TxtRutCliente);
            this.metroTabPage2.Controls.Add(this.BtnModificar);
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.BtnAgregar);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.TxtMontoTotal);
            this.metroTabPage2.Controls.Add(this.TxtCantPersonas);
            this.metroTabPage2.Controls.Add(this.TxtIdReserva);
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
            // TxtMontoAbonado
            // 
            // 
            // 
            // 
            this.TxtMontoAbonado.CustomButton.Image = null;
            this.TxtMontoAbonado.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtMontoAbonado.CustomButton.Name = "";
            this.TxtMontoAbonado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMontoAbonado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMontoAbonado.CustomButton.TabIndex = 1;
            this.TxtMontoAbonado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMontoAbonado.CustomButton.UseSelectable = true;
            this.TxtMontoAbonado.CustomButton.Visible = false;
            this.TxtMontoAbonado.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtMontoAbonado.Lines = new string[0];
            this.TxtMontoAbonado.Location = new System.Drawing.Point(510, 57);
            this.TxtMontoAbonado.MaxLength = 32767;
            this.TxtMontoAbonado.Name = "TxtMontoAbonado";
            this.TxtMontoAbonado.PasswordChar = '\0';
            this.TxtMontoAbonado.PromptText = "Monto abonado por el cliente";
            this.TxtMontoAbonado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMontoAbonado.SelectedText = "";
            this.TxtMontoAbonado.SelectionLength = 0;
            this.TxtMontoAbonado.SelectionStart = 0;
            this.TxtMontoAbonado.ShortcutsEnabled = true;
            this.TxtMontoAbonado.Size = new System.Drawing.Size(212, 23);
            this.TxtMontoAbonado.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtMontoAbonado.TabIndex = 7;
            this.TxtMontoAbonado.UseSelectable = true;
            this.TxtMontoAbonado.WaterMark = "Monto abonado por el cliente";
            this.TxtMontoAbonado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMontoAbonado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtRutCliente
            // 
            // 
            // 
            // 
            this.TxtRutCliente.CustomButton.Image = null;
            this.TxtRutCliente.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtRutCliente.CustomButton.Name = "";
            this.TxtRutCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRutCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRutCliente.CustomButton.TabIndex = 1;
            this.TxtRutCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRutCliente.CustomButton.UseSelectable = true;
            this.TxtRutCliente.CustomButton.Visible = false;
            this.TxtRutCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRutCliente.Lines = new string[0];
            this.TxtRutCliente.Location = new System.Drawing.Point(510, 170);
            this.TxtRutCliente.MaxLength = 32767;
            this.TxtRutCliente.Name = "TxtRutCliente";
            this.TxtRutCliente.PasswordChar = '\0';
            this.TxtRutCliente.PromptText = "Ingresar RUT del Cliente";
            this.TxtRutCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRutCliente.SelectedText = "";
            this.TxtRutCliente.SelectionLength = 0;
            this.TxtRutCliente.SelectionStart = 0;
            this.TxtRutCliente.ShortcutsEnabled = true;
            this.TxtRutCliente.Size = new System.Drawing.Size(212, 23);
            this.TxtRutCliente.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtRutCliente.TabIndex = 9;
            this.TxtRutCliente.UseSelectable = true;
            this.TxtRutCliente.WaterMark = "Ingresar RUT del Cliente";
            this.TxtRutCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRutCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnModificar
            // 
            this.BtnModificar.ActiveControl = null;
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.metroLabel7.Location = new System.Drawing.Point(393, 59);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Monto Abonado";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(50, 224);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Monto Total";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(424, 172);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "RUT Cliente";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(12, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Cantidad Personas";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(388, 117);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "ID Departamento";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(25, 117);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Término Reserva";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(42, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Inicio Reserva";
            // 
            // TxtMontoTotal
            // 
            // 
            // 
            // 
            this.TxtMontoTotal.CustomButton.Image = null;
            this.TxtMontoTotal.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtMontoTotal.CustomButton.Name = "";
            this.TxtMontoTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMontoTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMontoTotal.CustomButton.TabIndex = 1;
            this.TxtMontoTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMontoTotal.CustomButton.UseSelectable = true;
            this.TxtMontoTotal.CustomButton.Visible = false;
            this.TxtMontoTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtMontoTotal.Lines = new string[0];
            this.TxtMontoTotal.Location = new System.Drawing.Point(140, 222);
            this.TxtMontoTotal.MaxLength = 32767;
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.PasswordChar = '\0';
            this.TxtMontoTotal.PromptText = "Monto total de la reserva";
            this.TxtMontoTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMontoTotal.SelectedText = "";
            this.TxtMontoTotal.SelectionLength = 0;
            this.TxtMontoTotal.SelectionStart = 0;
            this.TxtMontoTotal.ShortcutsEnabled = true;
            this.TxtMontoTotal.Size = new System.Drawing.Size(212, 23);
            this.TxtMontoTotal.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtMontoTotal.TabIndex = 6;
            this.TxtMontoTotal.UseSelectable = true;
            this.TxtMontoTotal.WaterMark = "Monto total de la reserva";
            this.TxtMontoTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMontoTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtCantPersonas
            // 
            // 
            // 
            // 
            this.TxtCantPersonas.CustomButton.Image = null;
            this.TxtCantPersonas.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtCantPersonas.CustomButton.Name = "";
            this.TxtCantPersonas.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCantPersonas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCantPersonas.CustomButton.TabIndex = 1;
            this.TxtCantPersonas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCantPersonas.CustomButton.UseSelectable = true;
            this.TxtCantPersonas.CustomButton.Visible = false;
            this.TxtCantPersonas.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtCantPersonas.Lines = new string[0];
            this.TxtCantPersonas.Location = new System.Drawing.Point(140, 170);
            this.TxtCantPersonas.MaxLength = 32767;
            this.TxtCantPersonas.Name = "TxtCantPersonas";
            this.TxtCantPersonas.PasswordChar = '\0';
            this.TxtCantPersonas.PromptText = "Ingresar Cantidad de personas";
            this.TxtCantPersonas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCantPersonas.SelectedText = "";
            this.TxtCantPersonas.SelectionLength = 0;
            this.TxtCantPersonas.SelectionStart = 0;
            this.TxtCantPersonas.ShortcutsEnabled = true;
            this.TxtCantPersonas.Size = new System.Drawing.Size(212, 23);
            this.TxtCantPersonas.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtCantPersonas.TabIndex = 5;
            this.TxtCantPersonas.UseSelectable = true;
            this.TxtCantPersonas.WaterMark = "Ingresar Cantidad de personas";
            this.TxtCantPersonas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCantPersonas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdReserva
            // 
            // 
            // 
            // 
            this.TxtIdReserva.CustomButton.Image = null;
            this.TxtIdReserva.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtIdReserva.CustomButton.Name = "";
            this.TxtIdReserva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdReserva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdReserva.CustomButton.TabIndex = 1;
            this.TxtIdReserva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdReserva.CustomButton.UseSelectable = true;
            this.TxtIdReserva.CustomButton.Visible = false;
            this.TxtIdReserva.Enabled = false;
            this.TxtIdReserva.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIdReserva.Lines = new string[0];
            this.TxtIdReserva.Location = new System.Drawing.Point(451, 222);
            this.TxtIdReserva.MaxLength = 32767;
            this.TxtIdReserva.Name = "TxtIdReserva";
            this.TxtIdReserva.PasswordChar = '\0';
            this.TxtIdReserva.PromptText = "ID Reserva invisible";
            this.TxtIdReserva.ReadOnly = true;
            this.TxtIdReserva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdReserva.SelectedText = "";
            this.TxtIdReserva.SelectionLength = 0;
            this.TxtIdReserva.SelectionStart = 0;
            this.TxtIdReserva.ShortcutsEnabled = true;
            this.TxtIdReserva.Size = new System.Drawing.Size(212, 23);
            this.TxtIdReserva.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtIdReserva.TabIndex = 2;
            this.TxtIdReserva.UseSelectable = true;
            this.TxtIdReserva.Visible = false;
            this.TxtIdReserva.WaterMark = "ID Reserva invisible";
            this.TxtIdReserva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdReserva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DTInicioReserva
            // 
            this.DTInicioReserva.Location = new System.Drawing.Point(140, 54);
            this.DTInicioReserva.MinDate = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            this.DTInicioReserva.MinimumSize = new System.Drawing.Size(0, 29);
            this.DTInicioReserva.Name = "DTInicioReserva";
            this.DTInicioReserva.Size = new System.Drawing.Size(212, 29);
            this.DTInicioReserva.Style = MetroFramework.MetroColorStyle.Orange;
            this.DTInicioReserva.TabIndex = 23;
            // 
            // DTTerminoReserva
            // 
            this.DTTerminoReserva.Location = new System.Drawing.Point(140, 112);
            this.DTTerminoReserva.MinDate = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            this.DTTerminoReserva.MinimumSize = new System.Drawing.Size(0, 29);
            this.DTTerminoReserva.Name = "DTTerminoReserva";
            this.DTTerminoReserva.Size = new System.Drawing.Size(212, 29);
            this.DTTerminoReserva.Style = MetroFramework.MetroColorStyle.Orange;
            this.DTTerminoReserva.TabIndex = 24;
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCheckIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCheckIn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnCheckIn.Location = new System.Drawing.Point(364, 0);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(111, 23);
            this.BtnCheckIn.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnCheckIn.TabIndex = 8;
            this.BtnCheckIn.Text = "Realizar Check-In";
            this.BtnCheckIn.UseSelectable = true;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCheckOut.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCheckOut.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BtnCheckOut.Location = new System.Drawing.Point(475, 0);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(125, 23);
            this.BtnCheckOut.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnCheckOut.TabIndex = 9;
            this.BtnCheckOut.Text = "Realizar Check-Out";
            this.BtnCheckOut.UseSelectable = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // TxtIdDepartamento
            // 
            // 
            // 
            // 
            this.TxtIdDepartamento.CustomButton.Image = null;
            this.TxtIdDepartamento.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtIdDepartamento.CustomButton.Name = "";
            this.TxtIdDepartamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdDepartamento.CustomButton.TabIndex = 1;
            this.TxtIdDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdDepartamento.CustomButton.UseSelectable = true;
            this.TxtIdDepartamento.CustomButton.Visible = false;
            this.TxtIdDepartamento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIdDepartamento.Lines = new string[0];
            this.TxtIdDepartamento.Location = new System.Drawing.Point(510, 115);
            this.TxtIdDepartamento.MaxLength = 32767;
            this.TxtIdDepartamento.Name = "TxtIdDepartamento";
            this.TxtIdDepartamento.PasswordChar = '\0';
            this.TxtIdDepartamento.PromptText = "Ingresar correo electrónico";
            this.TxtIdDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdDepartamento.SelectedText = "";
            this.TxtIdDepartamento.SelectionLength = 0;
            this.TxtIdDepartamento.SelectionStart = 0;
            this.TxtIdDepartamento.ShortcutsEnabled = true;
            this.TxtIdDepartamento.Size = new System.Drawing.Size(212, 23);
            this.TxtIdDepartamento.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtIdDepartamento.TabIndex = 8;
            this.TxtIdDepartamento.UseSelectable = true;
            this.TxtIdDepartamento.WaterMark = "Ingresar correo electrónico";
            this.TxtIdDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmReservas";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Reservas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmReservas_Load);
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
        private MetroFramework.Controls.MetroTextBox TxtMontoAbonado;
        private MetroFramework.Controls.MetroTextBox TxtRutCliente;
        private MetroFramework.Controls.MetroTile BtnModificar;
        private MetroFramework.Controls.MetroTile BtnCancelar;
        private MetroFramework.Controls.MetroTile BtnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtMontoTotal;
        private MetroFramework.Controls.MetroTextBox TxtCantPersonas;
        private MetroFramework.Controls.MetroTextBox TxtIdReserva;
        private MetroFramework.Controls.MetroDateTime DTInicioReserva;
        private MetroFramework.Controls.MetroDateTime DTTerminoReserva;
        private MetroFramework.Controls.MetroButton BtnCheckIn;
        private MetroFramework.Controls.MetroButton BtnCheckOut;
        private MetroFramework.Controls.MetroTextBox TxtIdDepartamento;
    }
}