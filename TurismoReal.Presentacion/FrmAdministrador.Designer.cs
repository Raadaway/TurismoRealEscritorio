
namespace TurismoReal.Presentacion
{
    partial class FrmAdministrador
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
            this.TxtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.TxtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.TxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.BtnModificar = new MetroFramework.Controls.MetroTile();
            this.TxtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.BtnCancelar = new MetroFramework.Controls.MetroTile();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.BtnAgregar = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtApellidoM = new MetroFramework.Controls.MetroTextBox();
            this.TxtApellidoP = new MetroFramework.Controls.MetroTextBox();
            this.TxtNombre = new MetroFramework.Controls.MetroTextBox();
            this.TxtDv = new MetroFramework.Controls.MetroTextBox();
            this.TxtRut = new MetroFramework.Controls.MetroTextBox();
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
            this.TabGeneral.TabIndex = 1;
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
            this.metroTabPage2.Controls.Add(this.TxtTelefono);
            this.metroTabPage2.Controls.Add(this.TxtCorreo);
            this.metroTabPage2.Controls.Add(this.TxtUsuario);
            this.metroTabPage2.Controls.Add(this.BtnModificar);
            this.metroTabPage2.Controls.Add(this.TxtContrasena);
            this.metroTabPage2.Controls.Add(this.BtnCancelar);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.BtnAgregar);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.TxtApellidoM);
            this.metroTabPage2.Controls.Add(this.TxtApellidoP);
            this.metroTabPage2.Controls.Add(this.TxtNombre);
            this.metroTabPage2.Controls.Add(this.TxtDv);
            this.metroTabPage2.Controls.Add(this.TxtRut);
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
            // TxtTelefono
            // 
            // 
            // 
            // 
            this.TxtTelefono.CustomButton.Image = null;
            this.TxtTelefono.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtTelefono.CustomButton.Name = "";
            this.TxtTelefono.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTelefono.CustomButton.TabIndex = 1;
            this.TxtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTelefono.CustomButton.UseSelectable = true;
            this.TxtTelefono.CustomButton.Visible = false;
            this.TxtTelefono.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtTelefono.Lines = new string[0];
            this.TxtTelefono.Location = new System.Drawing.Point(506, 40);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.PromptText = "Ingresar n° celular";
            this.TxtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.ShortcutsEnabled = true;
            this.TxtTelefono.Size = new System.Drawing.Size(212, 23);
            this.TxtTelefono.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.UseSelectable = true;
            this.TxtTelefono.WaterMark = "Ingresar n° celular";
            this.TxtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTelefono.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtCorreo
            // 
            // 
            // 
            // 
            this.TxtCorreo.CustomButton.Image = null;
            this.TxtCorreo.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtCorreo.CustomButton.Name = "";
            this.TxtCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCorreo.CustomButton.TabIndex = 1;
            this.TxtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCorreo.CustomButton.UseSelectable = true;
            this.TxtCorreo.CustomButton.Visible = false;
            this.TxtCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtCorreo.Lines = new string[0];
            this.TxtCorreo.Location = new System.Drawing.Point(506, 91);
            this.TxtCorreo.MaxLength = 32767;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.PasswordChar = '\0';
            this.TxtCorreo.PromptText = "Ingresar correo electrónico";
            this.TxtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCorreo.SelectedText = "";
            this.TxtCorreo.SelectionLength = 0;
            this.TxtCorreo.SelectionStart = 0;
            this.TxtCorreo.ShortcutsEnabled = true;
            this.TxtCorreo.Size = new System.Drawing.Size(212, 23);
            this.TxtCorreo.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtCorreo.TabIndex = 8;
            this.TxtCorreo.UseSelectable = true;
            this.TxtCorreo.WaterMark = "Ingresar correo electrónico";
            this.TxtCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtUsuario
            // 
            // 
            // 
            // 
            this.TxtUsuario.CustomButton.Image = null;
            this.TxtUsuario.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtUsuario.CustomButton.Name = "";
            this.TxtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsuario.CustomButton.TabIndex = 1;
            this.TxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsuario.CustomButton.UseSelectable = true;
            this.TxtUsuario.CustomButton.Visible = false;
            this.TxtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtUsuario.Lines = new string[0];
            this.TxtUsuario.Location = new System.Drawing.Point(506, 142);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.PromptText = "Ingresar nombre de usuario";
            this.TxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.ShortcutsEnabled = true;
            this.TxtUsuario.Size = new System.Drawing.Size(212, 23);
            this.TxtUsuario.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtUsuario.TabIndex = 9;
            this.TxtUsuario.UseSelectable = true;
            this.TxtUsuario.WaterMark = "Ingresar nombre de usuario";
            this.TxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // TxtContrasena
            // 
            // 
            // 
            // 
            this.TxtContrasena.CustomButton.Image = null;
            this.TxtContrasena.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtContrasena.CustomButton.Name = "";
            this.TxtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtContrasena.CustomButton.TabIndex = 1;
            this.TxtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtContrasena.CustomButton.UseSelectable = true;
            this.TxtContrasena.CustomButton.Visible = false;
            this.TxtContrasena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtContrasena.Lines = new string[0];
            this.TxtContrasena.Location = new System.Drawing.Point(506, 193);
            this.TxtContrasena.MaxLength = 32767;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '\0';
            this.TxtContrasena.PromptText = "Ingresar contraseña";
            this.TxtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtContrasena.SelectedText = "";
            this.TxtContrasena.SelectionLength = 0;
            this.TxtContrasena.SelectionStart = 0;
            this.TxtContrasena.ShortcutsEnabled = true;
            this.TxtContrasena.Size = new System.Drawing.Size(212, 23);
            this.TxtContrasena.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtContrasena.TabIndex = 10;
            this.TxtContrasena.UseSelectable = true;
            this.TxtContrasena.WaterMark = "Ingresar contraseña";
            this.TxtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(421, 195);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(79, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Contraseña";
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
            this.metroLabel7.Location = new System.Drawing.Point(440, 42);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Teléfono";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(32, 246);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Apellido Materno";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(444, 144);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Usuario";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(37, 195);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Apellido Paterno";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(449, 93);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Correo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(88, 144);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(34, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Dígito verificador";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(117, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Rut";
            // 
            // TxtApellidoM
            // 
            // 
            // 
            // 
            this.TxtApellidoM.CustomButton.Image = null;
            this.TxtApellidoM.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtApellidoM.CustomButton.Name = "";
            this.TxtApellidoM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtApellidoM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtApellidoM.CustomButton.TabIndex = 1;
            this.TxtApellidoM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtApellidoM.CustomButton.UseSelectable = true;
            this.TxtApellidoM.CustomButton.Visible = false;
            this.TxtApellidoM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtApellidoM.Lines = new string[0];
            this.TxtApellidoM.Location = new System.Drawing.Point(153, 244);
            this.TxtApellidoM.MaxLength = 32767;
            this.TxtApellidoM.Name = "TxtApellidoM";
            this.TxtApellidoM.PasswordChar = '\0';
            this.TxtApellidoM.PromptText = "Ingresar apellido materno";
            this.TxtApellidoM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtApellidoM.SelectedText = "";
            this.TxtApellidoM.SelectionLength = 0;
            this.TxtApellidoM.SelectionStart = 0;
            this.TxtApellidoM.ShortcutsEnabled = true;
            this.TxtApellidoM.Size = new System.Drawing.Size(212, 23);
            this.TxtApellidoM.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtApellidoM.TabIndex = 6;
            this.TxtApellidoM.UseSelectable = true;
            this.TxtApellidoM.WaterMark = "Ingresar apellido materno";
            this.TxtApellidoM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtApellidoM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtApellidoP
            // 
            // 
            // 
            // 
            this.TxtApellidoP.CustomButton.Image = null;
            this.TxtApellidoP.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtApellidoP.CustomButton.Name = "";
            this.TxtApellidoP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtApellidoP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtApellidoP.CustomButton.TabIndex = 1;
            this.TxtApellidoP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtApellidoP.CustomButton.UseSelectable = true;
            this.TxtApellidoP.CustomButton.Visible = false;
            this.TxtApellidoP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtApellidoP.Lines = new string[0];
            this.TxtApellidoP.Location = new System.Drawing.Point(153, 193);
            this.TxtApellidoP.MaxLength = 32767;
            this.TxtApellidoP.Name = "TxtApellidoP";
            this.TxtApellidoP.PasswordChar = '\0';
            this.TxtApellidoP.PromptText = "Ingresar apellido paterno";
            this.TxtApellidoP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtApellidoP.SelectedText = "";
            this.TxtApellidoP.SelectionLength = 0;
            this.TxtApellidoP.SelectionStart = 0;
            this.TxtApellidoP.ShortcutsEnabled = true;
            this.TxtApellidoP.Size = new System.Drawing.Size(212, 23);
            this.TxtApellidoP.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtApellidoP.TabIndex = 5;
            this.TxtApellidoP.UseSelectable = true;
            this.TxtApellidoP.WaterMark = "Ingresar apellido paterno";
            this.TxtApellidoP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtApellidoP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtNombre
            // 
            // 
            // 
            // 
            this.TxtNombre.CustomButton.Image = null;
            this.TxtNombre.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtNombre.CustomButton.Name = "";
            this.TxtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNombre.CustomButton.TabIndex = 1;
            this.TxtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNombre.CustomButton.UseSelectable = true;
            this.TxtNombre.CustomButton.Visible = false;
            this.TxtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtNombre.Lines = new string[0];
            this.TxtNombre.Location = new System.Drawing.Point(153, 142);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PromptText = "Ingresar nombre";
            this.TxtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(212, 23);
            this.TxtNombre.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.UseSelectable = true;
            this.TxtNombre.WaterMark = "Ingresar nombre";
            this.TxtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtDv
            // 
            // 
            // 
            // 
            this.TxtDv.CustomButton.Image = null;
            this.TxtDv.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtDv.CustomButton.Name = "";
            this.TxtDv.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDv.CustomButton.TabIndex = 1;
            this.TxtDv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDv.CustomButton.UseSelectable = true;
            this.TxtDv.CustomButton.Visible = false;
            this.TxtDv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtDv.Lines = new string[0];
            this.TxtDv.Location = new System.Drawing.Point(153, 91);
            this.TxtDv.MaxLength = 32767;
            this.TxtDv.Name = "TxtDv";
            this.TxtDv.PasswordChar = '\0';
            this.TxtDv.PromptText = "Ingresar dígito verificador del Rut";
            this.TxtDv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDv.SelectedText = "";
            this.TxtDv.SelectionLength = 0;
            this.TxtDv.SelectionStart = 0;
            this.TxtDv.ShortcutsEnabled = true;
            this.TxtDv.Size = new System.Drawing.Size(212, 23);
            this.TxtDv.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtDv.TabIndex = 3;
            this.TxtDv.UseSelectable = true;
            this.TxtDv.WaterMark = "Ingresar dígito verificador del Rut";
            this.TxtDv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtRut
            // 
            // 
            // 
            // 
            this.TxtRut.CustomButton.Image = null;
            this.TxtRut.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.TxtRut.CustomButton.Name = "";
            this.TxtRut.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRut.CustomButton.TabIndex = 1;
            this.TxtRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRut.CustomButton.UseSelectable = true;
            this.TxtRut.CustomButton.Visible = false;
            this.TxtRut.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRut.Lines = new string[0];
            this.TxtRut.Location = new System.Drawing.Point(153, 40);
            this.TxtRut.MaxLength = 32767;
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.PasswordChar = '\0';
            this.TxtRut.PromptText = "Ingresar Rut sin puntos ni dígito verificador";
            this.TxtRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRut.SelectedText = "";
            this.TxtRut.SelectionLength = 0;
            this.TxtRut.SelectionStart = 0;
            this.TxtRut.ShortcutsEnabled = true;
            this.TxtRut.Size = new System.Drawing.Size(212, 23);
            this.TxtRut.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtRut.TabIndex = 2;
            this.TxtRut.UseSelectable = true;
            this.TxtRut.WaterMark = "Ingresar Rut sin puntos ni dígito verificador";
            this.TxtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmAdministrador";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Administradores";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
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
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTile BtnModificar;
        private MetroFramework.Controls.MetroTile BtnCancelar;
        private MetroFramework.Controls.MetroTile BtnAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtContrasena;
        private MetroFramework.Controls.MetroTextBox TxtUsuario;
        private MetroFramework.Controls.MetroTextBox TxtCorreo;
        private MetroFramework.Controls.MetroTextBox TxtTelefono;
        private MetroFramework.Controls.MetroTextBox TxtApellidoM;
        private MetroFramework.Controls.MetroTextBox TxtApellidoP;
        private MetroFramework.Controls.MetroTextBox TxtNombre;
        private MetroFramework.Controls.MetroTextBox TxtDv;
        private MetroFramework.Controls.MetroTextBox TxtRut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}