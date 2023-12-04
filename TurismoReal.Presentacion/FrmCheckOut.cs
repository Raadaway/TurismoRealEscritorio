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
            CargarFormaPago();
        }

        public FrmCheckOut(int idRes, int rut, int idDepa) : this()
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

        private void CargarFormaPago()
        {
            try
            {
                // Obtener la lista de formas de pago desde la capa de negocios
                List<FormaPago> lista = NFormaPago.ListarFormaPago();

                // Filtrar y ocultar la forma de pago con idFormaPago igual a 1
                var formaPagoOcultar = lista.FirstOrDefault(fp => fp.idFormaPago == 1);
                if (formaPagoOcultar != null)
                {
                    lista.Remove(formaPagoOcultar);
                }

                cboxFormaPago.DisplayMember = "nombre";
                cboxFormaPago.ValueMember = "idFormaPago";
                cboxFormaPago.DataSource = lista;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message + ex.StackTrace);
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
                MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            txtIdReserva.Clear();
            txtMulta.Clear();
            cbConformidad.Checked = false;
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
                int multa = int.Parse(txtMulta.Text);

                if (cbConformidad.Checked)
                {
                    Reserva reserva = NReserva.ListarReservaPorId(int.Parse(txtIdReserva.Text));

                    string fechaActual = DateTime.Now.ToString("yyyyMMdd");
                    string fechaTermino = reserva.termino_reserva.ToString("yyyyMMdd");

                    if (fechaTermino == fechaActual)
                    {
                        bool resultado = NCheckOut.AgregarCheckOut(multa, multa, "Cliente de Acuerdo", IdReserva, RutUsuario);
                        bool nuevoEstado = NActualizarEstados.ActualizarEstadoDepaADisponibleReserva(IdReserva);
                        bool agregarPago = NFormaPago.AgregarPago(multa, IdReserva, (int)cboxFormaPago.SelectedIndex);

                        FrmChecklist frmChecklist = Application.OpenForms.OfType<FrmChecklist>().FirstOrDefault();

                        if (frmChecklist != null)
                        {
                            frmChecklist.Close();
                        }

                        if (resultado && nuevoEstado)
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Check-Out realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al realizar Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "La fecha de término de la reserva no coincide con la fecha de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "El cliente debe estar conforme con la realización del Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string conforme = Convert.ToString(DGVListar.CurrentRow.Cells["Firma Cliente"].Value);
            if (!string.IsNullOrEmpty(conforme))
            {
                cbConformidad.Checked = true;
            }
            else
            {
                cbConformidad.Checked = false;
            }
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
                int idCheckOut = int.Parse(txtIdCheckOut.Text);
                int pago = int.Parse(txtMulta.Text);

                if (cbConformidad.Checked)
                {
                    bool resultado = NCheckOut.ModificarCheckOut(idCheckOut, pago, pago, "Cliente de Acuerdo");

                    if (resultado)
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Check-Out actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al actualizar Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "El cliente debe estar conforme con la realización del Check-Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea eliminar el Check-Out?", "Turismo Real", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se eliminó el registro " + Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-Out"].Value), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al eliminar el registro " + Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-Out"].Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    // Actualizar la lista después de la eliminación
                    this.ListarCheckOut();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
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
