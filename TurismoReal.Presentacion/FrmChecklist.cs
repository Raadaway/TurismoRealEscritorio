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
        private Dictionary<int, int> CantidadesIniciales = new Dictionary<int, int>();
        private bool CheckIn;

        public FrmChecklist()
        {
            InitializeComponent();
            lblPrecio.Text = Total.ToString();
        }

        public FrmChecklist(int idDepa, bool checkIn) : this()
        {
            IdDepartamento = idDepa;
            CheckIn = checkIn;
            LblTotal.Visible = false;
            lblPrecio.Visible = false;
        }

        private static FrmChecklist instance;

        public static FrmChecklist GetInstance(int idDepa)
        {
            if (instance == null)
            {
                instance = new FrmChecklist();
                instance.IdDepartamento = idDepa;
            }
            return instance;
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

                    CantidadesIniciales.Clear();
                    foreach (DataGridViewRow row in dgvInventario.Rows)
                    {
                        int cantidadInicial = Convert.ToInt32(row.Cells["cantidad"].Value);
                        CantidadesIniciales[row.Index] = cantidadInicial;
                    }
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
                int rowIndex = selectedRow.Index;
                int cantidad = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                int precio = Convert.ToInt32(selectedRow.Cells["precio"].Value);

                if (CheckIn)
                {
                    cantidad++;
                    selectedRow.Cells["cantidad"].Value = cantidad;
                }
                else
                {
                    // Comprueba si el nuevo valor es menor o igual al valor inicial
                    if (cantidad + 1 <= CantidadesIniciales[rowIndex])
                    {
                        cantidad++;
                        selectedRow.Cells["cantidad"].Value = cantidad;
                        Total -= precio;
                        lblPrecio.Text = Total.ToString();
                    }
                }
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvInventario.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (selectedRow != null)
            {
                int rowIndex = selectedRow.Index;
                int cantidad = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                int precio = Convert.ToInt32(selectedRow.Cells["precio"].Value);

                if (CheckIn)
                {
                    cantidad--;
                    selectedRow.Cells["cantidad"].Value = cantidad;
                }
                else
                {
                    // Comprueba si el nuevo valor es menor o igual al valor inicial
                    if (cantidad - 1 <= CantidadesIniciales[rowIndex])
                    {
                        cantidad--;
                        selectedRow.Cells["cantidad"].Value = cantidad;
                        Total += precio;
                        lblPrecio.Text = Total.ToString();
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (CheckIn)
            {
                foreach (DataGridViewRow row in dgvInventario.Rows)
                {
                    int idArticulo = Convert.ToInt32(row.Cells["id_articulo"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);

                    NInventario.ModificarInventario(IdDepartamento, idArticulo, cantidad);
                }
                this.Close();
            }
            else
            {
                FrmCheckOut frmCheckOut = Application.OpenForms.OfType<FrmCheckOut>().FirstOrDefault();

                if (frmCheckOut != null)
                {
                    foreach (DataGridViewRow row in dgvInventario.Rows)
                    {
                        int idArticulo = Convert.ToInt32(row.Cells["id_articulo"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);

                        NInventario.ModificarInventario(IdDepartamento, idArticulo, cantidad);

                        int precio = Convert.ToInt32(lblPrecio.Text);
                        frmCheckOut.ActualizarPrecio(precio);
                    }
                    this.Hide();
                }
            }
        }
    }
}
