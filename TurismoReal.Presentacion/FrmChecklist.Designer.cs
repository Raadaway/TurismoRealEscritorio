namespace TurismoReal.Presentacion
{
    partial class FrmChecklist
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvInventario = new MetroFramework.Controls.MetroGrid();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.BtnAgregar = new MetroFramework.Controls.MetroTile();
            this.cbSeleccionar = new MetroFramework.Controls.MetroCheckBox();
            this.btnSuma = new MetroFramework.Controls.MetroButton();
            this.btnResta = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(315, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Por favor, verifique el inventario del departamento";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInventario.Location = new System.Drawing.Point(23, 106);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.RowHeadersWidth = 50;
            this.dgvInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(554, 318);
            this.dgvInventario.Style = MetroFramework.MetroColorStyle.Orange;
            this.dgvInventario.TabIndex = 14;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
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
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblTotal.Location = new System.Drawing.Point(416, 430);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 19);
            this.LblTotal.Style = MetroFramework.MetroColorStyle.Orange;
            this.LblTotal.TabIndex = 15;
            this.LblTotal.Text = "Total:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPrecio.Location = new System.Drawing.Point(463, 430);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.ActiveControl = null;
            this.BtnAgregar.Location = new System.Drawing.Point(239, 430);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(99, 44);
            this.BtnAgregar.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Registrar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregar.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.BtnAgregar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbSeleccionar
            // 
            this.cbSeleccionar.AutoSize = true;
            this.cbSeleccionar.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbSeleccionar.Location = new System.Drawing.Point(23, 430);
            this.cbSeleccionar.Name = "cbSeleccionar";
            this.cbSeleccionar.Size = new System.Drawing.Size(92, 19);
            this.cbSeleccionar.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbSeleccionar.TabIndex = 22;
            this.cbSeleccionar.Text = "Seleccionar";
            this.cbSeleccionar.UseSelectable = true;
            this.cbSeleccionar.CheckedChanged += new System.EventHandler(this.cbSeleccionar_CheckedChanged);
            // 
            // btnSuma
            // 
            this.btnSuma.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSuma.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSuma.Location = new System.Drawing.Point(123, 430);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(23, 23);
            this.btnSuma.TabIndex = 23;
            this.btnSuma.Text = "+";
            this.btnSuma.UseSelectable = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnResta.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnResta.Location = new System.Drawing.Point(152, 430);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(23, 23);
            this.btnResta.TabIndex = 24;
            this.btnResta.Text = "-";
            this.btnResta.UseSelectable = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // FrmChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.cbSeleccionar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmChecklist";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "CheckList";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvInventario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private MetroFramework.Controls.MetroLabel LblTotal;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroTile BtnAgregar;
        private MetroFramework.Controls.MetroCheckBox cbSeleccionar;
        private MetroFramework.Controls.MetroButton btnSuma;
        private MetroFramework.Controls.MetroButton btnResta;
    }
}