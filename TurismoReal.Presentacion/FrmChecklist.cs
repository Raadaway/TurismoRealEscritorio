using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoReal.Entidades;
using TurismoReal.Negocio;

namespace TurismoReal.Presentacion
{
    public partial class FrmChecklist : MetroFramework.Forms.MetroForm
    {

        private int IdDepartamento;
        private int Total;

        public FrmChecklist()
        {
            InitializeComponent();
            lblPrecio.Text = Total.ToString();
        }

        public FrmChecklist(int idDepa) : this()
        {
            IdDepartamento = idDepa;
        }

        private void ListarInventarioPorIdDepa(int idDepa)
        {

            try
            {
                List<Inventario> inv = NInventario.ListarInventarioPorId(IdDepartamento);

                if (inv != null && inv.Count > 0)
                {
                    dgvInventario.DataSource = inv;
                    Formato();
                }
                else
                {
                    dgvInventario.DataSource = null; // Limpiar el control DataGridView
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmChecklist_Load(object sender, EventArgs e)
        {
            ListarInventarioPorIdDepa(IdDepartamento);
        }

        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (dgvInventario.Columns.Count > 1)
            {
                dgvInventario.Columns["clmnSeleccionar"].Visible = false;
            }
        }

        private void cbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeleccionar.Checked)
            {
                dgvInventario.Columns["clmnSeleccionar"].Visible = true;
                btnSuma.Visible = true;
                btnResta.Visible = true;
            }
            else
            {
                dgvInventario.Columns["clmnSeleccionar"].Visible = false;
                btnSuma.Visible = false;
                btnResta.Visible = false;
            }
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInventario.Columns["clmnSeleccionar"].Index)
            {
                DataGridViewCheckBoxCell seleccion = (DataGridViewCheckBoxCell)dgvInventario.Rows[e.RowIndex].Cells["clmnSeleccionar"];
                seleccion.Value = !Convert.ToBoolean(seleccion.Value);
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvInventario.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                // Obtiene el valor actual de la columna "clmnCantidad" como entero
                int cantidad = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);

                // Suma 1 al valor actual
                cantidad++;

                // Actualiza el valor en la celda
                selectedRow.Cells["cantidad"].Value = cantidad;

                int precio = Convert.ToInt32(selectedRow.Cells["precio"].Value);
                Total -= precio;
                lblPrecio.Text = Total.ToString();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvInventario.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                // Obtiene el valor actual de la columna "clmnCantidad" como entero
                int cantidad = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);

                // Suma 1 al valor actual
                cantidad--;

                // Actualiza el valor en la celda
                selectedRow.Cells["cantidad"].Value = cantidad;

                int precio = Convert.ToInt32(selectedRow.Cells["precio"].Value);
                Total += precio;
                lblPrecio.Text = Total.ToString();
            }
        }
    }
}
