﻿namespace TurismoReal.Presentacion
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.clmnSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnSeleccionar});
            this.dgvInventario.Location = new System.Drawing.Point(12, 84);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(546, 261);
            this.dgvInventario.TabIndex = 0;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // clmnSeleccionar
            // 
            this.clmnSeleccionar.HeaderText = "Seleccionar";
            this.clmnSeleccionar.Name = "clmnSeleccionar";
            this.clmnSeleccionar.ReadOnly = true;
            this.clmnSeleccionar.Width = 80;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(10, 375);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Por favor, verifique el inventario del departamento";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(237, 391);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(97, 27);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar Cambios";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(46, 375);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 9;
            // 
            // cbSeleccionar
            // 
            this.cbSeleccionar.AutoSize = true;
            this.cbSeleccionar.Location = new System.Drawing.Point(12, 349);
            this.cbSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.cbSeleccionar.Name = "cbSeleccionar";
            this.cbSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.cbSeleccionar.TabIndex = 10;
            this.cbSeleccionar.Text = "Seleccionar";
            this.cbSeleccionar.UseVisualStyleBackColor = true;
            this.cbSeleccionar.CheckedChanged += new System.EventHandler(this.cbSeleccionar_CheckedChanged);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(122, 349);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(17, 19);
            this.btnSuma.TabIndex = 11;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Visible = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(144, 349);
            this.btnResta.Margin = new System.Windows.Forms.Padding(2);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(17, 19);
            this.btnResta.TabIndex = 12;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Visible = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // FrmChecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 440);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.cbSeleccionar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.dgvInventario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmChecklist";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "FrmChecklist";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmChecklist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.CheckBox cbSeleccionar;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnSeleccionar;
    }
}