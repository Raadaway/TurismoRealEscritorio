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
                List<Transporte> transportes = NTransporte.ListarTransporte(); // Utiliza el nuevo método para obtener una lista de transportes

                if (transportes != null && transportes.Count > 0)
                {
                    DGVListar.DataSource = ConvertToDataTable(transportes);
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
                MetroFramework.MetroMessageBox.Show(this, ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (DGVListar.Columns.Count > 5)
            {
                DGVListar.Columns[0].Visible = false; // IdTransporte
                DGVListar.Columns[1].HeaderText = "Nombre de la Empresa";
                DGVListar.Columns[2].HeaderText = "Horario";
                DGVListar.Columns[3].HeaderText = "Patente";
                DGVListar.Columns[4].HeaderText = "Tarifa Adicional";
                DGVListar.Columns[5].HeaderText = "Rut del Chofer";

                DGVListar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGVListar.Columns[2].Width = 100;
                DGVListar.Columns[3].Width = 100;
                DGVListar.Columns[4].Width = 100;
                DGVListar.Columns[5].Width = 100;
            }
        }

        private DataTable ConvertToDataTable(List<Transporte> transportes)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("IdTransporte", typeof(int));
            dataTable.Columns.Add("NombreEmpresa", typeof(string));
            dataTable.Columns.Add("Horario", typeof(string));
            dataTable.Columns.Add("Patente", typeof(string));
            dataTable.Columns.Add("TarifaAdicional", typeof(int));
            dataTable.Columns.Add("RutChofer", typeof(int));

            foreach (var transporte in transportes)
            {
                DataRow row = dataTable.NewRow();

                row["IdTransporte"] = transporte.IdTransporte;
                row["NombreEmpresa"] = transporte.NombreEmpresa;
                row["Horario"] = transporte.Horario;
                row["Patente"] = transporte.Patente;
                row["TarifaAdicional"] = transporte.TarifaAdicional;
                row["RutChofer"] = transporte.RutChofer;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
