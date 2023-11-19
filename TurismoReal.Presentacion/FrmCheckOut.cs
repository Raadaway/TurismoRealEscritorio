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
    public partial class FrmCheckOut : MetroFramework.Forms.MetroForm
    {

        private int IdReserva;
        private int RutUsuario;
        private int IdDepartamento;

        public FrmCheckOut()
        {
            InitializeComponent();
            Limpiar();
            ListarCheckOut();
        }

        public FrmCheckOut(int idRes, int rut, int idDepa) : this ()
        {
            IdReserva = idRes;
            RutUsuario = rut;
            IdDepartamento = idDepa;
            TabGeneral.SelectedIndex = 1;

            Reserva reserva = NReserva.ListarReservaPorId(IdReserva);
            if (reserva != null)
            {
                txtIdReserva.Text = IdReserva.ToString();
                TxtRutFunc.Text = RutUsuario.ToString();
            }
        }

        private void ListarCheckOut()
        {
            try
            {
                DataTable dataTable = NCheckOut.ListarCheckOut();

                if (dataTable != null)
                {
                    DGVListar.DataSource = dataTable;
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
            txtIdReserva.Clear();
            txtMulta.Clear();
            txtFirma.Clear();
            TxtRutFunc.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
        }

        public void ActualizarPrecio(int precio)
        {
            // Actualiza el lblPrecio en FrmCheckOut con el nuevo valor
            txtMulta.Text = precio.ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string firma = txtFirma.Text;
                int multa = int.Parse(txtMulta.Text);

                Reserva reserva = NReserva.ListarReservaPorId(IdReserva);
                if (reserva.termino_reserva == DateTime.Now.Date)
                {
                    bool resultado = NCheckOut.AgregarCheckOut(multa, multa, firma, IdReserva, RutUsuario);
                    bool nuevoEstado = NActualizarEstados.ActualizarEstadoDepaADisponibleReserva(IdDepartamento);
                    FrmChecklist frmChecklist = Application.OpenForms.OfType<FrmChecklist>().FirstOrDefault();
                    if (frmChecklist != null)
                    {
                        // Puedes usar Close() para cerrar el formulario o Hide() para ocultarlo
                        frmChecklist.Close(); // O frmChecklist.Hide();
                    }

                    if (resultado && nuevoEstado)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Check-Out realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error al realizar Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "La fecha de término de la reserva no coincide con la fecha de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChecklist_Click(object sender, EventArgs e)
        {
            FrmChecklist frmChecklist = FrmChecklist.GetInstance(IdDepartamento);
            frmChecklist.MdiParent = this.MdiParent;
            frmChecklist.Show();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarCheckOut(); // Recarga la lista completa
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
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

        private void DGVListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            BtnModificar.Visible = true;
            BtnAgregar.Visible = false;
            txtIdCheckOut.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-Out"].Value);
            txtIdReserva.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Reserva"].Value);
            txtMulta.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Pago Cliente"].Value);
            txtFirma.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Firma Cliente"].Value);
            TxtRutFunc.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Rut Funcionario"].Value);
            TabGeneral.SelectedIndex = 1;
            txtIdReserva.ReadOnly = true;
            txtMulta.ReadOnly = false;
            txtMulta.Enabled = true;
            TxtRutFunc.ReadOnly = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el valor del rut desde el control TxtRut
                int idCheckOut = int.Parse(txtIdCheckOut.Text);
                string firma = txtFirma.Text;
                int pago = int.Parse(txtMulta.Text);

                // Llama al método de negocio para actualizar el administrador
                bool resultado = NCheckOut.ModificarCheckOut(idCheckOut, pago, pago, firma);

                // Verifica el resultado y muestra un mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this, "Check-Out actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this, "Error al actualizar Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this, "¿Desea eliminar el Check-Out?", "Turismo Real", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int codigo;

                    foreach (DataGridViewRow row in DGVListar.Rows)
                    {
                        if (Convert.ToBoolean(DGVListar.CurrentRow.Cells["Seleccionar"].Value))
                        {
                            codigo = Convert.ToInt32(DGVListar.CurrentRow.Cells["Id Check-Out"].Value);

                            // Llamar al método de negocio para eliminar al administrador
                            bool resultado = NCheckOut.EliminarCheckOut(codigo);

                            if (resultado)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Se eliminó el registro " + Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-Out"].Value), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Error al eliminar el registro " + Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-Out"].Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    // Actualizar la lista después de la eliminación
                    this.ListarCheckOut();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
