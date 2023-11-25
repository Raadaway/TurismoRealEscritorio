namespace TurismoReal.Presentacion
{
    partial class FrmDireccion
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLatitud = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtLongitud = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.btnGuardar = new MetroFramework.Controls.MetroTile();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.gMapControl1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(288, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(492, 470);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnGuardar);
            this.metroPanel2.Controls.Add(this.btnBuscar);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtLongitud);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.txtLatitud);
            this.metroPanel2.Controls.Add(this.metroLabel);
            this.metroPanel2.Controls.Add(this.txtDireccion);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(262, 470);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(26, 104);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PromptText = "Busca la dirección deseada";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(214, 23);
            this.txtDireccion.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMark = "Busca la dirección deseada";
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel.Location = new System.Drawing.Point(98, 82);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(65, 19);
            this.metroLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel.TabIndex = 7;
            this.metroLabel.Text = "Dirección";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(103, 267);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Latitud";
            // 
            // txtLatitud
            // 
            // 
            // 
            // 
            this.txtLatitud.CustomButton.Image = null;
            this.txtLatitud.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtLatitud.CustomButton.Name = "";
            this.txtLatitud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLatitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLatitud.CustomButton.TabIndex = 1;
            this.txtLatitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLatitud.CustomButton.UseSelectable = true;
            this.txtLatitud.CustomButton.Visible = false;
            this.txtLatitud.Enabled = false;
            this.txtLatitud.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLatitud.Lines = new string[0];
            this.txtLatitud.Location = new System.Drawing.Point(26, 289);
            this.txtLatitud.MaxLength = 32767;
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.PasswordChar = '\0';
            this.txtLatitud.PromptText = "Latitud de la dirección ingresada";
            this.txtLatitud.ReadOnly = true;
            this.txtLatitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLatitud.SelectedText = "";
            this.txtLatitud.SelectionLength = 0;
            this.txtLatitud.SelectionStart = 0;
            this.txtLatitud.ShortcutsEnabled = true;
            this.txtLatitud.Size = new System.Drawing.Size(214, 23);
            this.txtLatitud.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtLatitud.TabIndex = 8;
            this.txtLatitud.UseSelectable = true;
            this.txtLatitud.WaterMark = "Latitud de la dirección ingresada";
            this.txtLatitud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLatitud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(98, 337);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Longitud";
            // 
            // txtLongitud
            // 
            // 
            // 
            // 
            this.txtLongitud.CustomButton.Image = null;
            this.txtLongitud.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtLongitud.CustomButton.Name = "";
            this.txtLongitud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLongitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLongitud.CustomButton.TabIndex = 1;
            this.txtLongitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLongitud.CustomButton.UseSelectable = true;
            this.txtLongitud.CustomButton.Visible = false;
            this.txtLongitud.Enabled = false;
            this.txtLongitud.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLongitud.Lines = new string[0];
            this.txtLongitud.Location = new System.Drawing.Point(26, 359);
            this.txtLongitud.MaxLength = 32767;
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.PasswordChar = '\0';
            this.txtLongitud.PromptText = "Longitud de la dirección ingresada";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLongitud.SelectedText = "";
            this.txtLongitud.SelectionLength = 0;
            this.txtLongitud.SelectionStart = 0;
            this.txtLongitud.ShortcutsEnabled = true;
            this.txtLongitud.Size = new System.Drawing.Size(214, 23);
            this.txtLongitud.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtLongitud.TabIndex = 10;
            this.txtLongitud.UseSelectable = true;
            this.txtLongitud.WaterMark = "Longitud de la dirección ingresada";
            this.txtLongitud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLongitud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Location = new System.Drawing.Point(70, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 44);
            this.btnBuscar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar Dirección";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnBuscar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveControl = null;
            this.btnGuardar.Location = new System.Drawing.Point(81, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 44);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGuardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(492, 470);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 10D;
            // 
            // FrmDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmDireccion";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Seleccionar Dirección";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmDireccion_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLongitud;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLatitud;
        private MetroFramework.Controls.MetroTile btnGuardar;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}