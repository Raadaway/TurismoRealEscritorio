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
    public partial class FrmTransporte : MetroFramework.Forms.MetroForm
    {
        public FrmTransporte()
        {
            InitializeComponent();
        }

        private void FrmTransporte_Load(object sender, EventArgs e)
        {
            this.ListarTransportes();
        }

        private void ListarTransportes()
        {
            try
            {
                DataTable dataTable = NTransporte.ListarTransporte(); // Utiliza el nuevo método para obtener un DataTable

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    DGVListar.DataSource = dataTable;
                    this.Formato();
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            if (DGVListar.Columns.Count > 6)
            {
                DGVListar.Columns[0].Visible = false;
                DGVListar.Columns[1].Visible = true;
                DGVListar.Columns[2].Width = 100;
                DGVListar.Columns[3].Width = 100;
                DGVListar.Columns[4].Width = 100;
                DGVListar.Columns[5].Width = 100;
                DGVListar.Columns[6].Width = 100;
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarTransportes(); // Recarga la lista completa
        }
    }
}
