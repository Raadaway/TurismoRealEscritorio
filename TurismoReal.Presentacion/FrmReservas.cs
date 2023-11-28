using MetroFramework.Controls;
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
using System.Text.RegularExpressions;

namespace TurismoReal.Presentacion
{
    public partial class FrmReservas : MetroFramework.Forms.MetroForm
    {

        private int RutUsuario;

        public FrmReservas()
        {
            InitializeComponent();
        }

        public FrmReservas(int rutUser) : this()
        {
            RutUsuario = rutUser;
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            this.ListarReservas();
        }

        private void ListarReservas()
        {
            try
            {
                List<Reserva> reservas = NReserva.ListarReservas();

                if (reservas != null && reservas.Count > 0)
                {
                    DGVListar.DataSource = reservas;
                    this.Formato();
                    this.Limpiar();
                    LblTotal.Text = "Total de reservas: " + Convert.ToString(reservas.Count);
                }
                else
                {
                    DGVListar.DataSource = null; // Limpiar el control DataGridView
                    LblTotal.Text = "No hay reservas para mostrar";
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarReservas();
        }

        private void FiltrarReservas()
        {
            string textoBusqueda = TxtBuscar.Text.Trim().ToLower();

            List<Reserva> reservas = NReserva.ListarReservas();

            reservas = reservas
                .Where(r => r.estado_reserva.ToLower().Contains(textoBusqueda) || r.cliente_rut.ToString().Equals(textoBusqueda)).ToList();

            if (reservas != null && reservas.Count > 0)
            {
                DGVListar.DataSource = reservas;
                LblTotal.Text = "Total de reservas: " + Convert.ToString(reservas.Count);
            }
            else
            {
                DGVListar.DataSource = null; // Limpiar el control DataGridView
                LblTotal.Text = "No hay reservas para mostrar";
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarReservas(); // Recarga la lista completa
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtIdReserva.Clear();
            ((MetroDateTime)DTInicioReserva).Value = DateTime.Now;
            ((MetroDateTime)DTTerminoReserva).Value = DateTime.Now.AddDays(1);
            TxtCantPersonas.Clear();
            TxtMontoTotal.Clear();
            TxtMontoAbonado.Clear();
            TxtIdDepartamento.Clear();
            TxtRutCliente.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
            BtnCheckIn.Visible = false;
            BtnCheckOut.Visible = false;
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

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSeleccionar.Checked)
            {
                DGVListar.Columns[0].Visible = true;
                BtnEliminar.Visible = true;
                BtnCheckIn.Visible = true;
                BtnCheckOut.Visible = true;
            }
            else
            {
                DGVListar.Columns[0].Visible = false;
                BtnEliminar.Visible = false;
                BtnCheckIn.Visible = false;
                BtnCheckOut.Visible = false;
            }
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (DGVListar.SelectedRows.Count > 0)
                {
                    String estReserva = Convert.ToString(DGVListar.SelectedRows[0].Cells["estado_reserva"].Value);

                    if (estReserva == "Reservado")
                    {
                        int idReserva = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["id_reserva"].Value);
                        int idDepa = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["departamento_id_departamento"].Value);

                        FrmCheckIn frmCheckIn = new FrmCheckIn(idReserva, RutUsuario, idDepa);
                        frmCheckIn.MdiParent = this.MdiParent;
                        frmCheckIn.Show();
                    }
                    else if (estReserva == "En Proceso")
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "El check-In ya fué realizado para esta reserva, por favor seleccione una reserva válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Esta reserva ya se encuentra finalizada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado una reserva
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, seleccione una reserva para realizar el check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (DGVListar.SelectedRows.Count > 0)
                {
                    String estReserva = Convert.ToString(DGVListar.SelectedRows[0].Cells["estado_reserva"].Value);

                    if (estReserva == "Reservado")
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Esta reserva aún no ha pasado por el check-in", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (estReserva == "En Proceso")
                    {
                        int idReserva = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["id_reserva"].Value);
                        int idDepa = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["departamento_id_departamento"].Value);

                        FrmCheckOut frmCheckOut = new FrmCheckOut(idReserva, RutUsuario, idDepa);
                        frmCheckOut.MdiParent = this.MdiParent;
                        frmCheckOut.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Esta reserva ya se encuentra finalizada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado una reserva
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, seleccione una reserva para realizar el check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            NReserva negocioReserva = new NReserva(); // Crear una instancia de la clase NReserva

            try
            {
                // Obtener las fechas de inicio y término desde los controles
                DateTime inicioReserva = DTInicioReserva.Value;
                DateTime terminoReserva = DTTerminoReserva.Value;

                // Validar que la fecha de término de la reserva no sea anterior a la fecha de inicio
                if (terminoReserva < inicioReserva)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "La fecha de término de la reserva no puede ser anterior a la fecha de inicio", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si la validación falla
                }

                // Obtener los montos desde los controles
                int montoTotal = int.Parse(TxtMontoTotal.Text);
                int montoAbonado = int.Parse(TxtMontoAbonado.Text);

                // Validar que el monto abonado sea menor o igual al monto total
                if (montoAbonado > montoTotal)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "El monto abonado no puede ser mayor al monto total", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si la validación falla
                }

                // Crear una nueva instancia de la entidad "Reserva" y asignar los valores desde los controles
                Reserva nuevaReserva = new Reserva
                {
                    id_reserva = int.Parse(TxtIdReserva.Text),
                    inicio_reserva = inicioReserva,
                    termino_reserva = terminoReserva,
                    cant_personas = int.Parse(TxtCantPersonas.Text),
                    monto_total = montoTotal,
                    monto_abonado = montoAbonado,
                    departamento_id_departamento = int.Parse(TxtIdDepartamento.Text),
                    cliente_rut = int.Parse(TxtRutCliente.Text)
                };

                // Llamar al método de la capa de negocio para agregar la reserva
                bool resultado = negocioReserva.AgregarReserva(nuevaReserva);

                if (resultado)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Reserva agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Puedes realizar otras acciones después de agregar la reserva si es necesario
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al agregar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (DGVListar.SelectedRows.Count > 0)
                {
                    int idReserva = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["id_reserva"].Value);

                    // Recopila los datos de los controles en tu formulario
                    DateTime inicioReserva = DTInicioReserva.Value;
                    DateTime terminoReserva = DTTerminoReserva.Value;
                    int cantPersonas, montoTotal, montoAbonado, idDepartamento;

                    if (!int.TryParse(TxtCantPersonas.Text, out cantPersonas) ||
                        !int.TryParse(TxtMontoTotal.Text, out montoTotal) ||
                        !int.TryParse(TxtMontoAbonado.Text, out montoAbonado) ||
                        !int.TryParse(TxtIdDepartamento.Text, out idDepartamento))
                    {
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Los valores ingresados no son válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Sal del evento si los valores no son válidos
                    }

                    // Llama al método de negocio para modificar la reserva
                    bool resultado = NReserva.ModificarReserva(idReserva, inicioReserva, terminoReserva, cantPersonas, montoTotal, montoAbonado, idDepartamento);

                    // Verifica el resultado y muestra un mensaje correspondiente
                    if (resultado)
                    {
                        // Operación exitosa
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Reserva modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Error
                        MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al modificar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado una reserva
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, seleccione una reserva para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Limpiar();
            BtnModificar.Visible = true;
            BtnAgregar.Visible = false;
            TxtIdReserva.Text = Convert.ToString(DGVListar.CurrentRow.Cells["ID Reserva"].Value);
            TxtCantPersonas.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Cantidad Personas"].Value);
            TxtMontoTotal.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Monto Pagado"].Value);
            TxtMontoAbonado.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Monto Abonado"].Value);
            TxtIdDepartamento.Text = Convert.ToString(DGVListar.CurrentRow.Cells["ID Departamento"].Value);
            TxtRutCliente.Text = Convert.ToString(DGVListar.CurrentRow.Cells["RUT Cliente"].Value);
            TabGeneral.SelectedIndex = 1;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (DGVListar.SelectedRows.Count > 0)
                {
                    int idReserva = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["id_reserva"].Value);

                    // Mostrar un mensaje de confirmación
                    DialogResult opcion = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea eliminar la reserva?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (opcion == DialogResult.OK)
                    {
                        // Llama al método de negocio para eliminar la reserva
                        bool resultado = NReserva.EliminarReserva(idReserva);

                        // Verifica el resultado y muestra un mensaje correspondiente
                        if (resultado)
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Reserva eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Puedes realizar otras acciones después de eliminar la reserva si es necesario
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al eliminar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado una reserva
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Por favor, seleccione una reserva para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
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
