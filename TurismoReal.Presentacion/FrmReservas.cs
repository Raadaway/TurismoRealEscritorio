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
        public FrmReservas()
        {
            InitializeComponent();
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
