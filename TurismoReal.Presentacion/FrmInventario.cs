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
        }

        public FrmInventario(int idDepartamento) : this()
        {
            this.idDepartamento = idDepartamento; // Almacena el ID del departamento
            TabGeneral.SelectedIndex = 1;
            TxtIdDepartamento.Text = idDepartamento.ToString();
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + ex.StackTrace);
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
                    MetroFramework.MetroMessageBox.Show(this, "Error al aplicar el filtro: " + ex.Message);
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


        private void FrmInventario_Load(object sender, EventArgs e)
        {
            ListarInventario();
            ConfigurarComboBoxArticulo();
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

        private void ConfigurarComboBoxArticulo()
        {
            try
            {
                // Obtén la lista de Articulos desde la capa de negocio de Articulo
                List<Articulo> listaArticulos = NArticulo.ListarArticulos();

                // Configura el ComboBox de Articulo para mostrar la propiedad "descripcion"
                // de los objetos Articulo
                ComboBoxArticulo.DisplayMember = "descripcion";

                // Configura el ComboBox de Articulo para usar la propiedad "id_articulo"
                // como el valor de cada elemento
                ComboBoxArticulo.ValueMember = "id_articulo";

                // Asigna la lista de Articulos al ComboBox de Articulo
                ComboBoxArticulo.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error al cargar los datos del ComboBox de Articulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void MensajeOk(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this, mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MetroFramework.MetroMessageBox.Show(this, "Inventario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCantidad.Clear();
                            TxtIdDepartamento.Clear();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Error al agregar inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Por favor, ingrese valores válidos para ID de departamento y cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un artículo del ComboBox de Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblStock_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxArticulo.SelectedItem != null)
                {
                    // Obtén el artículo seleccionado
                    Articulo articuloSeleccionado = (Articulo)ComboBoxArticulo.SelectedItem;

                    // Verifica que la selección sea válida
                    if (articuloSeleccionado != null)
                    {
                        int idArticulo = articuloSeleccionado.id_articulo;

                        if (int.TryParse(TxtIdDepartamento.Text, out int idDepartamento) &&
                            int.TryParse(TxtCantidad.Text, out int cantidad))
                        {
                            // Crear un objeto Inventario con los datos del formulario
                            Inventario inv = new Inventario
                            {
                                id_articulo = idArticulo,
                                id_departamento = idDepartamento,
                                cantidad = cantidad
                            };

                            // Llamar al método de negocio para modificar el inventario
                            bool resultado = NInventario.ModificarInventario(inv.id_departamento, inv.id_articulo, inv.cantidad);

                            if (resultado)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Inventario modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Error al modificar inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Por favor, ingrese valores válidos para ID de departamento y cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "La selección de artículo no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un artículo del ComboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione desde la celda nombre");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar el inventario?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DGVListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene el valor de la celda de la columna que muestra el ID
                int id_art = Convert.ToInt32(DGVListar.Rows[e.RowIndex].Cells["Id Articulo"].Value);
                // Asigna el valor a un campo oculto o bloqueado en tu formulario (por ejemplo, TxtId)
                TxtIdDepartamento.Text = id_art.ToString();
            }
        }
    }
}
