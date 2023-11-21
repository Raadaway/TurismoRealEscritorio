﻿using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TurismoReal.Entidades;
using TurismoReal.Negocio;
using TurismoReal.Presentacion.WSportafolio;
namespace TurismoReal.Presentacion
{
    public partial class FrmMantenimiento : MetroFramework.Forms.MetroForm
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            this.ListarMantenimientos();
        }

        private void ListarMantenimientos()
        {
            try
            {
                DataTable dataTable = NMantenimiento.ListarMantenimiento();

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

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtDescripcion.Clear();
            ((MetroDateTime)DTFechaInicio).Value = DateTime.Now;
            ((MetroDateTime)DTFechaTermino).Value = DateTime.Now.AddDays(1);
            TxtIdDepartamento.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;
            CbSeleccionar.Checked = false;
        }

        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (DGVListar.Columns.Count > 9)
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
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            NMantenimiento negocioMantenimiento = new NMantenimiento();

            try
            {
                // Crear una nueva instancia de la entidad "Mantenimiento" y asignar los valores desde los controles
                Entidades.Mantenimiento nuevoMantenimiento = new Entidades.Mantenimiento
                {
                    DescMantenimiento = TxtDescripcion.Text,
                    FechaInicio = DTFechaInicio.Value,
                    FechaTermino = DTFechaTermino.Value,
                    IdDepartamento = int.Parse(TxtIdDepartamento.Text)
                };

                // Llamar al método de la capa de negocio para agregar el mantenimiento
                bool resultado = negocioMantenimiento.AgregarMantenimiento(nuevoMantenimiento);

                if (resultado)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mantenimiento agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Puedes realizar otras acciones después de agregar el mantenimiento si es necesario
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error al agregar el mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            NMantenimiento negocioMantenimiento = new NMantenimiento();

            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (DGVListar.SelectedRows.Count > 0)
                {
                    int idMantenimiento = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["IdMantenimiento"].Value);

                    // Recopila los datos de los controles en tu formulario
                    DateTime fechaInicio = DTFechaInicio.Value;
                    DateTime fechaTermino = DTFechaTermino.Value;

                    // Crear una nueva instancia de la entidad "Mantenimiento" y asignar los valores desde los controles
                    Entidades.Mantenimiento nuevoMantenimiento = new Entidades.Mantenimiento
                    {
                        IdMantenimiento = idMantenimiento,
                        DescMantenimiento = TxtDescripcion.Text,
                        FechaInicio = fechaInicio,
                        FechaTermino = fechaTermino
                    };

                    // Llama al método de negocio para modificar el mantenimiento
                    bool resultado = negocioMantenimiento.ModificarMantenimiento(idMantenimiento, nuevoMantenimiento);

                    // Verifica el resultado y muestra un mensaje correspondiente
                    if (resultado)
                    {
                        // Operación exitosa
                        MetroFramework.MetroMessageBox.Show(this, "Mantenimiento modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Error
                        MetroFramework.MetroMessageBox.Show(this, "Error al modificar el mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado un mantenimiento
                    MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un mantenimiento para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
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
                TxtDescripcion.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Descripcion"].Value);
                TxtIdDepartamento.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Departamento"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre");
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
            NMantenimiento negocioMantenimiento = new NMantenimiento();

            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (DGVListar.SelectedRows.Count > 0)
                {
                    int idMantenimiento = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["IdMantenimiento"].Value);

                    // Mostrar un mensaje de confirmación
                    DialogResult opcion = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar el mantenimiento?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (opcion == DialogResult.OK)
                    {
                        // Llama al método de negocio para eliminar el mantenimiento
                        bool resultado = negocioMantenimiento.EliminarMantenimiento(idMantenimiento);

                        // Verifica el resultado y muestra un mensaje correspondiente
                        if (resultado)
                        {
                            // Operación exitosa
                            MetroFramework.MetroMessageBox.Show(this, "Mantenimiento eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Puedes realizar otras acciones después de eliminar el mantenimiento si es necesario
                        }
                        else
                        {
                            // Error
                            MetroFramework.MetroMessageBox.Show(this, "Error al eliminar el mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado un mantenimiento
                    MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un mantenimiento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
