namespace TurismoReal.Presentacion
{
    partial class FrmReportes
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
            this.rbInventario = new MetroFramework.Controls.MetroRadioButton();
            this.rbArticulo = new MetroFramework.Controls.MetroRadioButton();
            this.rbGanancias = new MetroFramework.Controls.MetroRadioButton();
            this.rbReservas = new MetroFramework.Controls.MetroRadioButton();
            this.rbResCanceladas = new MetroFramework.Controls.MetroRadioButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dtInicio = new MetroFramework.Controls.MetroDateTime();
            this.dtTermino = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnReporte = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInventario
            // 
            this.rbInventario.AutoSize = true;
            this.rbInventario.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbInventario.Location = new System.Drawing.Point(23, 499);
            this.rbInventario.Name = "rbInventario";
            this.rbInventario.Size = new System.Drawing.Size(139, 19);
            this.rbInventario.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbInventario.TabIndex = 0;
            this.rbInventario.Text = "Reporte Inventario";
            this.rbInventario.UseSelectable = true;
            this.rbInventario.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbArticulo
            // 
            this.rbArticulo.AutoSize = true;
            this.rbArticulo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbArticulo.Location = new System.Drawing.Point(183, 499);
            this.rbArticulo.Name = "rbArticulo";
            this.rbArticulo.Size = new System.Drawing.Size(130, 19);
            this.rbArticulo.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbArticulo.TabIndex = 1;
            this.rbArticulo.Text = "Reporte Artículos";
            this.rbArticulo.UseSelectable = true;
            this.rbArticulo.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbGanancias
            // 
            this.rbGanancias.AutoSize = true;
            this.rbGanancias.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbGanancias.Location = new System.Drawing.Point(334, 499);
            this.rbGanancias.Name = "rbGanancias";
            this.rbGanancias.Size = new System.Drawing.Size(139, 19);
            this.rbGanancias.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbGanancias.TabIndex = 2;
            this.rbGanancias.Text = "Reporte Ganancias";
            this.rbGanancias.UseSelectable = true;
            this.rbGanancias.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbReservas
            // 
            this.rbReservas.AutoSize = true;
            this.rbReservas.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbReservas.Location = new System.Drawing.Point(494, 499);
            this.rbReservas.Name = "rbReservas";
            this.rbReservas.Size = new System.Drawing.Size(130, 19);
            this.rbReservas.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbReservas.TabIndex = 3;
            this.rbReservas.Text = "Reporte Reservas";
            this.rbReservas.UseSelectable = true;
            this.rbReservas.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbResCanceladas
            // 
            this.rbResCanceladas.AutoSize = true;
            this.rbResCanceladas.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbResCanceladas.Location = new System.Drawing.Point(645, 489);
            this.rbResCanceladas.Name = "rbResCanceladas";
            this.rbResCanceladas.Size = new System.Drawing.Size(130, 38);
            this.rbResCanceladas.Style = MetroFramework.MetroColorStyle.Orange;
            this.rbResCanceladas.TabIndex = 4;
            this.rbResCanceladas.Text = "Reporte Reservas\r\nCanceladas";
            this.rbResCanceladas.UseSelectable = true;
            this.rbResCanceladas.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 146);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(754, 323);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 5;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(22, 87);
            this.dtInicio.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtInicio.MinDate = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            this.dtInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 29);
            this.dtInicio.Style = MetroFramework.MetroColorStyle.Orange;
            this.dtInicio.TabIndex = 6;
            this.dtInicio.Value = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            // 
            // dtTermino
            // 
            this.dtTermino.Location = new System.Drawing.Point(299, 87);
            this.dtTermino.MaxDate = new System.DateTime(2031, 1, 31, 0, 0, 0, 0);
            this.dtTermino.MinDate = new System.DateTime(2023, 11, 2, 0, 0, 0, 0);
            this.dtTermino.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(200, 29);
            this.dtTermino.Style = MetroFramework.MetroColorStyle.Orange;
            this.dtTermino.TabIndex = 7;
            this.dtTermino.Value = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(82, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Fecha Inicio";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(351, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Fecha Término";
            // 
            // btnReporte
            // 
            this.btnReporte.ActiveControl = null;
            this.btnReporte.Location = new System.Drawing.Point(573, 73);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(122, 51);
            this.btnReporte.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnReporte.TabIndex = 28;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReporte.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnReporte.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnReporte.UseSelectable = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 29;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtTermino);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.rbResCanceladas);
            this.Controls.Add(this.rbReservas);
            this.Controls.Add(this.rbGanancias);
            this.Controls.Add(this.rbArticulo);
            this.Controls.Add(this.rbInventario);
            this.MaximizeBox = false;
            this.Name = "FrmReportes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Reportes";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rbInventario;
        private MetroFramework.Controls.MetroRadioButton rbArticulo;
        private MetroFramework.Controls.MetroRadioButton rbGanancias;
        private MetroFramework.Controls.MetroRadioButton rbReservas;
        private MetroFramework.Controls.MetroRadioButton rbResCanceladas;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroDateTime dtInicio;
        private MetroFramework.Controls.MetroDateTime dtTermino;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnReporte;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}