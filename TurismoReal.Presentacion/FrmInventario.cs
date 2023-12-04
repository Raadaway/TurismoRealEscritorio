using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoReal.Negocio;
using TurismoReal.Presentacion.WSportafolio;
using TurismoReal.Entidades;

namespace TurismoReal.Presentacion
{
    public partial class FrmInventario : MetroFramework.Forms.MetroForm
    {
        private int idDepartamento; // Campo para almacenar el ID del departamento

        public FrmInventario()
        {
            InitializeComponent();
            ListarInventario();
            CargarArticulos();
        }

        public FrmInventario(int idDepa) : this()
        {
            this.idDepartamento = idDepa; // Almacena el ID del departamento
            TabGeneral.SelectedIndex = 1;
            TxtIdDepartamento.Text = idDepartamento.ToString();
            TxtIdDepartamento.ReadOnly = true;
        }

        private void ListarInventario()
        {
            try
            {
                DataTable dataTable = NInventario.ListarInventario();

                if (dataTable != null)
                {
                    DGVListar.DataSource = dataTable;
                    this.Formato();
                    this.Limpiar();
                    LblTotal.Text = "Total de registros: " + Convert.ToString(DGVListar.Rows.Count);
                }
                else
                {
                    DGVListar.DataSource = null; // Limpiar el control DataGridView
                    LblTotal.Text = "No hay registros para mostrar";
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message + ex.StackTrace);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtroTexto = TxtBuscar.Text;

            if (DGVListar.DataSource != null)
            {
                DataTable dataTable = (DataTable)DGVListar.DataSource;
                DataView dataView = dataTable.DefaultView;

                try
                {
                    if (!string.IsNullOrEmpty(filtroTexto))
                    {
                        dataView.RowFilter = $"Convert(Id Departamento, 'System.String') LIKE '%{filtroTexto}%' OR Articulo LIKE '%{filtroTexto}%'";
                    }
                    else
                    {
                        dataView.RowFilter = string.Empty;
                    }

                    DGVListar.DataSource = dataView.ToTable();
                    LblTotal.Text = "Total de registros: " + Convert.ToString(dataView.Count);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (por ejemplo, mostrar un mensaje al usuario o restaurar la vista original)
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al aplicar el filtro: " + ex.Message);
                }
            }
            else
            {
                ListarInventario();
            }
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                TxtBuscar_TextChanged((object)sender, e);
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarInventario(); // Recarga la lista completa
        }

        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (DGVListar.Columns.Count > 4)
            {
                DGVListar.Columns[0].Visible = false;
                DGVListar.Columns[1].Visible = true;
                DGVListar.Columns[2].Width = 200;
                DGVListar.Columns[3].Width = 200;
                DGVListar.Columns[4].Width = 200;
            }
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtIdDepartamento.Clear();
            TxtCantidad.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
            CbSeleccionar.Checked = false;
        }

        private void CargarArticulos()
        {
            try
            {
                List<Articulo> lista = NArticulo.ListarArticuloCB();

                ComboBoxArticulo.DisplayMember = "descripcion";
                ComboBoxArticulo.ValueMember = "id_articulo";
                ComboBoxArticulo.DataSource = lista;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message + ex.StackTrace);
            }
        }

        private void MensajeOk(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this.MdiParent, mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this.MdiParent, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxArticulo.SelectedItem != null)
                {
                    int idArticulo = (int)ComboBoxArticulo.SelectedValue; // Obtiene el id del artículo seleccionado

                    if (int.TryParse(TxtIdDepartamento.Text, out int idDepartamento) &&
                        int.TryParse(TxtCantidad.Text, out int cantidad))
                    {
                        // Llamar al método de negocio para agregar inventario
                        bool resultado = NInventario.AgregarInventario(idArticulo, idDepartamento, cantidad);

                        if (resultado)
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Inventario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCantidad.Clear();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al agregar inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, ingrese valores válidos para ID de departamento y cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, seleccione un artículo del ComboBox de Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxArticulo.SelectedItem != null)
                {
                    // Obtén el artículo seleccionado
                    Articulo articuloSeleccionado = (Articulo)ComboBoxArticulo.SelectedItem;
                    int idArtAntiguo = int.Parse(txtIDArticulo.Text);

                    // Verifica que la selección sea válida
                    if (articuloSeleccionado != null)
                    {
                        int idArticulo = articuloSeleccionado.id_articulo;

                        if (int.TryParse(TxtIdDepartamento.Text, out int idDepartamento) &&
                            int.TryParse(TxtCantidad.Text, out int cantidad))
                        {

                            // Llamar al método de negocio para modificar el inventario
                            bool resultado = NInventario.ModificarInventario(idDepartamento, idArtAntiguo, idArticulo, cantidad);

                            if (resultado)
                            {
                                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Inventario modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al modificar inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, ingrese valores válidos para ID de departamento y cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "La selección de artículo no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, seleccione un artículo del ComboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnModificar.Visible = true;
                BtnAgregar.Visible = false;
                TxtIdDepartamento.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Departamento"].Value);
                TxtCantidad.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Cantidad"].Value);
                txtIDArticulo.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Articulo"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Seleccione desde la celda nombre");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea eliminar el inventario?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int id_depa, id_art;

                    foreach (DataGridViewRow row in DGVListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            // Obtén el ID de departamento e ID de artículo de la fila seleccionada
                            id_depa = Convert.ToInt32(row.Cells["Id Departamento"].Value);
                            id_art = Convert.ToInt32(row.Cells["Id Articulo"].Value);

                            // Llama al método de negocio para eliminar el inventario
                            bool resultado = NInventario.EliminarInventario(id_depa, id_art);

                            if (resultado)
                            {
                                this.MensajeOk("Inventario eliminado correctamente.");
                            }
                            else
                            {
                                this.MensajeError("Error al eliminar inventario.");
                            }
                        }
                    }

                    // Actualiza la lista después de la eliminación
                    this.ListarInventario();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSeleccionar.Checked)
            {
                DGVListar.Columns[0].Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DGVListar.Columns[0].Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void DGVListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell CbEliminar = (DataGridViewCheckBoxCell)DGVListar.Rows[e.RowIndex].Cells["Seleccionar"];
                CbEliminar.Value = !Convert.ToBoolean(CbEliminar.Value);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarInventario(); // Recarga la lista completa
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {

        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }
    }
}
