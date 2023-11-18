using MetroFramework.Controls;
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
using TurismoReal.Presentacion.WSportafolio;

namespace TurismoReal.Presentacion
{
    public partial class FrmDepartamento : MetroFramework.Forms.MetroForm
    {

        private NComuna nComuna = new NComuna();

        public FrmDepartamento()
        {
            InitializeComponent();
            CargarComunas();
        }

        private void CargarComunas()
        {
            try
            {
                List<Comuna> lista = nComuna.ListarComunas();

                cBoxComuna.DisplayMember = "nombreComuna";
                cBoxComuna.ValueMember = "idComuna";
                cBoxComuna.DataSource = lista;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + ex.StackTrace);
            }
        }

        private void ListarDepartamentos()
        {
            try
            {
                NDepartamento negocioDepartamento = new NDepartamento();
                DataTable dataTable = negocioDepartamento.Listar();

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
                        dataView.RowFilter = $"Direccion LIKE '%{filtroTexto}%' OR Convert(ID, 'System.String') LIKE '%{filtroTexto}%'";
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
                ListarDepartamentos();
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
            ListarDepartamentos(); // Recarga la lista completa
        }


        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (DGVListar.Columns.Count > 10)
            {
                DGVListar.Columns[0].Visible = false;
                DGVListar.Columns[1].Visible = true;
                DGVListar.Columns[2].Width = 100;
                DGVListar.Columns[3].Width = 100;
                DGVListar.Columns[4].Width = 100;
                DGVListar.Columns[5].Width = 100;
                DGVListar.Columns[6].Width = 100;
                DGVListar.Columns[7].Width = 100;
                DGVListar.Columns[8].Width = 100;
                DGVListar.Columns[9].Width = 100;
                DGVListar.Columns[10].Width = 100;
            }
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtDireccion.Clear();
            TxtDescripcion.Clear();
            TxtPrecio.Clear();
            TxtLatitud.Clear();
            TxtLongitud.Clear();
            TxtCapacidad.Clear();
            TxtCantImagenes.Clear();
            cBoxComuna.SelectedIndex = 0;
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
            BtnAgregarServicios.Visible = false;
            BtnAgregarInventario.Visible = false;
            CbSeleccionar.Checked = false;
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            this.ListarDepartamentos();
        }

        private void DGVListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell CbEliminar = (DataGridViewCheckBoxCell)DGVListar.Rows[e.RowIndex].Cells["Seleccionar"];
                CbEliminar.Value = !Convert.ToBoolean(CbEliminar.Value);
            }
        }



        private void DGVListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            BtnModificar.Visible = true;
            BtnAgregar.Visible = false;

            if (DGVListar.CurrentRow != null)
            {
                TxtIdDepa.Text = Convert.ToString(DGVListar.CurrentRow.Cells["ID"].Value);
                TxtDireccion.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Direccion"].Value);
                TxtDescripcion.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Descripcion"].Value);
                TxtPrecio.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Precio"].Value);
                TxtLatitud.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Latitud"].Value);
                TxtLongitud.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Longitud"].Value);
                TxtCapacidad.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Capacidad"].Value);

                // Verificar si la celda no está vacía o nula antes de convertir
                if (DGVListar.CurrentRow.Cells["Comuna"].Value != null)
                {
                    int comunaValue;
                    if (int.TryParse(Convert.ToString(DGVListar.CurrentRow.Cells["Comuna"].Value), out comunaValue))
                    {
                        cBoxComuna.SelectedValue = comunaValue;
                    }
                    else
                    {
                        // Manejo de error, ya que la conversión falló
                    }
                }

                TabGeneral.SelectedIndex = 1;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int idComuna = (int)cBoxComuna.SelectedValue;
                string direccion = TxtDireccion.Text;
                string descripcion = TxtDescripcion.Text;
                int idDepa = int.Parse(TxtIdDepa.Text);
                if (!int.TryParse(TxtPrecio.Text, out int precio))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de precio no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si el precio no es válido
                }

                if (!float.TryParse(TxtLatitud.Text, out float latitud))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de latitud no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si la latitud no es válida
                }

                if (!float.TryParse(TxtLongitud.Text, out float longitud))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de longitud no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si la longitud no es válida
                }

                if (!int.TryParse(TxtCapacidad.Text, out int capacidadPersona))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de capacidad de personas no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si la capacidad de personas no es válida
                }

                if (!int.TryParse(TxtCantImagenes.Text, out int cantidadImagenes))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de cantidad de imágenes no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si la cantidad de imágenes no es válida
                }

                if (!int.TryParse(TxtHabitaciones.Text, out int habitaciones))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de cantidad de habitaciones no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si la cantidad de imágenes no es válida
                }

                // Llama al método de negocio para modificar el departamento
                bool resultado = NDepartamento.ModificarDepartamento(idDepa, direccion, descripcion, precio, latitud, longitud, capacidadPersona, cantidadImagenes, habitaciones, idComuna);

                // Verifica el resultado y muestra un mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this, "Departamento modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this, "Error al modificar el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSeleccionar.Checked)
            {
                DGVListar.Columns[0].Visible = true;
                BtnEliminar.Visible = true;
                BtnAgregarServicios.Visible = true;
                BtnAgregarInventario.Visible = true;
            }
            else
            {
                DGVListar.Columns[0].Visible = false;
                BtnEliminar.Visible = false;
                BtnAgregarServicios.Visible = false;
                BtnAgregarInventario.Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar el departamento?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int id_departamento;

                    foreach (DataGridViewRow row in DGVListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            id_departamento = Convert.ToInt32(row.Cells["ID"].Value);

                            // Llamar al método de negocio para eliminar el departamento
                            bool resultado = NDepartamento.EliminarDepartamento(id_departamento);

                            if (resultado)
                            {
                                this.MensajeOk("Se eliminó el departamento con ID " + id_departamento);
                            }
                            else
                            {
                                this.MensajeError("Error al eliminar el departamento con ID " + id_departamento);
                            }
                        }
                    }

                    // Actualizar la lista después de la eliminación
                    this.ListarDepartamentos();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string direccion = TxtDireccion.Text;
                string descripcion = TxtDescripcion.Text;
                int precio = int.Parse(TxtPrecio.Text);
                float latitud = float.Parse(TxtLatitud.Text);
                float longitud = float.Parse(TxtLongitud.Text);
                int capacidadPersona = int.Parse(TxtCapacidad.Text);
                int cantidadImagenes = int.Parse(TxtCantImagenes.Text);
                int habitaciones = int.Parse (TxtHabitaciones.Text);
                int idComuna = (int)cBoxComuna.SelectedValue;

                bool resultado = NDepartamento.AgregarDepartamento(direccion, descripcion, precio, latitud, longitud, capacidadPersona, cantidadImagenes, habitaciones, idComuna);

                if (resultado)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Departamento agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error al agregar departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarServicios_Click(object sender, EventArgs e)
        {
            if (DGVListar.SelectedRows.Count > 0)
            {
                int idDepartamento = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["ID"].Value);
                // Crea una nueva instancia de FrmServicio
                FrmServicio frmServicio = new FrmServicio(idDepartamento);
                frmServicio.MdiParent = this.MdiParent;
                frmServicio.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro antes de agregar un servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarInventario_Click(object sender, EventArgs e)
        {
            if (DGVListar.SelectedRows.Count > 0)
            {
                int idDepartamento = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["ID"].Value);
                // Crea una nueva instancia de FrmInventario
                FrmInventario frmInventario = new FrmInventario(idDepartamento);
                frmInventario.MdiParent = this.MdiParent;
                frmInventario.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro antes de agregar inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
