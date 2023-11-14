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
            }
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            ListarCheckOut();
        }

        private void ListarCheckOut()
        {
            try
            {
                List<CheckOut> checkOuts = NCheckOut.ListarCheckOut(); // Utiliza el método para obtener una lista de Check-Out

                if (checkOuts != null && checkOuts.Count > 0)
                {
                    DGVListar.DataSource = ConvertToDataTable(checkOuts);
                    Formato(DGVListar);
                    LblTotal.Text = "Total de registros: " + Convert.ToString(DGVListar.Rows.Count);
                }
                else
                {
                    DGVListar.DataSource = null;
                    LblTotal.Text = "No hay registros para mostrar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato(DataGridView dataGridView)
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[0].Visible = false; // IdCheckOut
                dataGridView.Columns[1].HeaderText = "Hora";
                dataGridView.Columns[2].HeaderText = "Fecha";
                dataGridView.Columns[3].HeaderText = "Multas";
                dataGridView.Columns[4].HeaderText = "Pago del Cliente";
                dataGridView.Columns[5].HeaderText = "Firma del Cliente";
                dataGridView.Columns[6].HeaderText = "ID de Reserva";
                dataGridView.Columns[7].HeaderText = "RUT del Funcionario";

                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[2].Width = 100;
                dataGridView.Columns[3].Width = 100;
                dataGridView.Columns[4].Width = 100;
                dataGridView.Columns[5].Width = 150;
                dataGridView.Columns[6].Width = 100;
                dataGridView.Columns[7].Width = 100;
            }
        }

        private DataTable ConvertToDataTable(List<CheckOut> checkOuts)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("IdCheckOut", typeof(int));
            dataTable.Columns.Add("Hora", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));
            dataTable.Columns.Add("Multas", typeof(int));
            dataTable.Columns.Add("PagoCliente", typeof(int));
            dataTable.Columns.Add("FirmaCliente", typeof(string));
            dataTable.Columns.Add("IdReserva", typeof(int));
            dataTable.Columns.Add("FuncionarioRut", typeof(int));

            if (checkOuts != null)
            {
                foreach (var checkOut in checkOuts)
                {
                    DataRow row = dataTable.NewRow();

                    row["IdCheckOut"] = checkOut.IdCheckOut;
                    row["Hora"] = checkOut.Hora;
                    row["Fecha"] = checkOut.Fecha;
                    row["Multas"] = checkOut.Multas;
                    row["PagoCliente"] = checkOut.PagoCliente;
                    row["FirmaCliente"] = checkOut.FirmaCliente;
                    row["IdReserva"] = checkOut.IdReserva;
                    row["FuncionarioRut"] = checkOut.FuncionarioRut;

                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;
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

                FrmChecklist frmChecklist = Application.OpenForms.OfType<FrmChecklist>().FirstOrDefault();
                if (frmChecklist != null)
                {
                    // Puedes usar Close() para cerrar el formulario o Hide() para ocultarlo
                    frmChecklist.Close(); // O frmChecklist.Hide();
                }

                Reserva reserva = NReserva.ListarReservaPorId(IdReserva);
                if (reserva.termino_reserva == DateTime.Now.Date)
                {
                    bool resultado = NCheckOut.AgregarCheckOut(multa, multa, firma, IdReserva, RutUsuario);
                    bool nuevoEstado = NActualizarEstados.ActualizarEstadoDepaADisponibleReserva(IdDepartamento);

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
    }
}
