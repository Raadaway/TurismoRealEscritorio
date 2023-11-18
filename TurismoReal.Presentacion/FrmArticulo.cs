﻿using System;
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
    public partial class FrmArticulo : MetroFramework.Forms.MetroForm
    {
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                List<Articulo> listaArticulos = NArticulo.ListarArticulos();

                if (listaArticulos != null && listaArticulos.Count > 0)
                {
                    // Crear un DataTable a partir de la lista de Articulos
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id Articulo", typeof(int));
                    dataTable.Columns.Add("Descripcion", typeof(string));
                    dataTable.Columns.Add("Stock", typeof(int));
                    dataTable.Columns.Add("Precio", typeof(int));

                    foreach (Articulo art in listaArticulos)
                    {
                        DataRow row = dataTable.NewRow();
                        row["Id Articulo"] = art.id_articulo;
                        row["Descripcion"] = art.descripcion;
                        row["Stock"] = art.stock;
                        row["Precio"] = art.precio_articulo;

                        dataTable.Rows.Add(row);
                    }

                    DGVListar.DataSource = dataTable;

                    // Llamada a los métodos de formato y limpieza
                    Formato();
                    Limpiar();
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
                        dataView.RowFilter = $"Descripcion LIKE '%{filtroTexto}%' OR Convert(Id Articulo, 'System.String') LIKE '%{filtroTexto}%'";
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
                Listar();
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
            Listar(); // Recarga la lista completa
        }


        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (DGVListar.Columns.Count > 4)
            {
                DGVListar.Columns[0].Visible = false;
                DGVListar.Columns[1].Visible = true;

                // Asegúrate de que las columnas 2, 3 y 4 estén dentro del rango válido
                if (DGVListar.Columns.Count > 2)
                {
                    DGVListar.Columns[2].Width = 400;
                }
                if (DGVListar.Columns.Count > 3)
                {
                    DGVListar.Columns[3].Width = 100;
                }
                if (DGVListar.Columns.Count > 4)
                {
                    DGVListar.Columns[4].Width = 100;
                }
            }
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtDescripcion.Clear();
            TxtPrecio.Clear();
            TxtStock.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
        }

        private void MensajeOk(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this, mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario desde las TextBox
                string descripcion = TxtDescripcion.Text;
                int stock = int.Parse(TxtStock.Text);
                int precio = int.Parse(TxtPrecio.Text);


                // Llamar al método de negocio para agregar un administrador
                bool resultado = NArticulo.Insertar(descripcion, stock, precio);

                // Verificar el resultado y mostrar el cuadro de mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this, "Articulo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this, "Error al agregar articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DGVListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnModificar.Visible = true;
                BtnAgregar.Visible = false;
                TxtId.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Articulo"].Value);
                TxtDescripcion.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Articulo"].Value);
                TxtStock.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Stock"].Value);
                TxtPrecio.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Precio"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Seleccione desde la celda nombre");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el valor del ID del artículo desde el control TxtId
                if (!int.TryParse(TxtId.Text, out int id_art))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor del ID no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si el ID no es válido
                }

                string descripcion = TxtDescripcion.Text;

                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    MetroFramework.MetroMessageBox.Show(this, "La descripción no puede estar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si la descripción está en blanco
                }

                if (!int.TryParse(TxtStock.Text, out int stock))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de stock no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si el stock no es válido
                }

                if (!int.TryParse(TxtPrecio.Text, out int precio))
                {
                    MetroFramework.MetroMessageBox.Show(this, "El valor de precio no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sal del evento si el precio no es válido
                }

                // Llama al método de negocio para actualizar el artículo
                bool resultado = NArticulo.ModificarArticulo(id_art, descripcion, stock, precio);

                // Verifica el resultado y muestra un mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this, "Artículo actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this, "Error al actualizar artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar el articulo?", "Turismo Real", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int codigo;


                    foreach (DataGridViewRow row in DGVListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            // Llamar al método de negocio para eliminar al administrador
                            bool resultado = NArticulo.EliminarArticulo(codigo);

                            if (resultado)
                            {
                                this.MensajeOk("Se eliminó el registro " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError("Error al eliminar el registro " + Convert.ToString(row.Cells[2].Value));
                            }
                        }
                    }

                    // Actualizar la lista después de la eliminación
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    }


