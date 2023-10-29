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
                    //this.Formato();
                    //this.Limpiar();
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ListarReservas();
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
            ListarReservas(); // Recarga la lista completa
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    // Obtener el ID de reserva de la fila seleccionada
                    int idReserva = Convert.ToInt32(DGVListar.SelectedRows[0].Cells["id_reserva"].Value);

                    // Abrir el formulario FrmCheckIn y pasar el ID de reserva como parámetro
                    FrmCheckIn frmCheckIn = new FrmCheckIn(idReserva, RutUsuario);
                    frmCheckIn.ShowDialog();
                }
                else
                {
                    // Mostrar un mensaje de error si no se ha seleccionado una reserva
                    MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione una reserva para realizar el check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
