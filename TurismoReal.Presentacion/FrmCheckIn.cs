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
using System.Windows.Media.TextFormatting;
using System.ServiceModel.Channels;

namespace TurismoReal.Presentacion
{
    public partial class FrmCheckIn : MetroFramework.Forms.MetroForm
    {

        private int IdReserva;
        private int RutUsuario;
        private int IdDepartamento;

        public FrmCheckIn()
        {
            InitializeComponent();
            Limpiar();
            ListarCheckIns();
        }

        public FrmCheckIn(int idRes, int rut, int idDepa) : this()
        {
            IdReserva = idRes;
            RutUsuario = rut;
            IdDepartamento = idDepa;
            TabGeneral.SelectedIndex = 1;

            Reserva reserva = NReserva.ListarReservaPorId(idRes);
            if ( reserva != null )
            {
                txtIdReserva.Text = idRes.ToString();
                txtPago.Text = (reserva.monto_total - reserva.monto_abonado).ToString();
                TxtRutFunc.Text = RutUsuario.ToString();
            }
        }

        private void ListarCheckIns()
        {
            try
            {
                DataTable dataTable = NCheckIn.ListarCheckIn();

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
            txtPago.Clear();
            txtFirma.Clear();
            TxtRutFunc.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string firma = txtFirma.Text;
                int pago = int.Parse(txtPago.Text);

                bool resultado = NCheckIn.AgregarCheckIn(firma, pago, IdReserva, RutUsuario);
                bool nuevoEstado = NActualizarEstados.ActualizarEstadoDepaAOcupado(IdDepartamento);

                if (resultado && nuevoEstado)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Check-In realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al realizar Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChecklist_Click(object sender, EventArgs e)
        {
            FrmChecklist frmChecklist = new FrmChecklist(IdDepartamento, true);
            frmChecklist.MdiParent = this.MdiParent;
            frmChecklist.Show();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarCheckIns(); // Recarga la lista completa
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
            txtIdCheckIn.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-In"].Value);
            txtIdReserva.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Id Reserva"].Value);
            txtPago.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Pago Cliente"].Value);
            txtFirma.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Firma Cliente"].Value);
            TxtRutFunc.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Rut Funcionario"].Value);
            TabGeneral.SelectedIndex = 1;
            txtIdReserva.ReadOnly = true;
            txtPago.ReadOnly = false;
            txtPago.Enabled = true;
            TxtRutFunc.ReadOnly = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el valor del rut desde el control TxtRut
                int idCheckIn = int.Parse(txtIdCheckIn.Text);
                string firma = txtFirma.Text;
                int pago = int.Parse(txtPago.Text);

                // Llama al método de negocio para actualizar el administrador
                bool resultado = NCheckIn.ModificarCheckIn(idCheckIn, firma, pago);

                // Verifica el resultado y muestra un mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Check-In actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al actualizar Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea eliminar el Check-In?", "Turismo Real", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int codigo;


                    foreach (DataGridViewRow row in DGVListar.Rows)
                    {
                        if (Convert.ToBoolean(DGVListar.CurrentRow.Cells["Seleccionar"].Value))
                        {
                            codigo = Convert.ToInt32(DGVListar.CurrentRow.Cells["Id Check-In"].Value);

                            // Llamar al método de negocio para eliminar al administrador
                            bool resultado = NCheckIn.EliminarCheckIn(codigo);

                            if (resultado)
                            {
                                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Se eliminó el registro " + Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-In"].Value), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al eliminar el registro " + Convert.ToString(DGVListar.CurrentRow.Cells["Id Check-In"].Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    // Actualizar la lista después de la eliminación
                    this.ListarCheckIns();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
