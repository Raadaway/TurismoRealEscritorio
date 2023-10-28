﻿using System;
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
    public partial class FrmCheckIn : MetroFramework.Forms.MetroForm
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            ListarCheckIns();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListarCheckIns()
        {
            try
            {
                List<CheckIn> checkIns = NCheckIn.ListarCheckIn(); // Utiliza el método para obtener una lista de Check-In

                if (checkIns != null && checkIns.Count > 0)
                {
                    DGVListar.DataSource = ConvertToDataTable(checkIns);
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
                dataGridView.Columns[0].Visible = false; // IdCheckIn
                dataGridView.Columns[1].HeaderText = "Hora";
                dataGridView.Columns[2].HeaderText = "Fecha";
                dataGridView.Columns[3].HeaderText = "Firma del Cliente";
                dataGridView.Columns[4].HeaderText = "Pago del Cliente";
                dataGridView.Columns[5].HeaderText = "ID de Reserva";
                dataGridView.Columns[6].HeaderText = "RUT del Funcionario";

                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns[2].Width = 100;
                dataGridView.Columns[3].Width = 150;
                dataGridView.Columns[4].Width = 100;
                dataGridView.Columns[5].Width = 100;
                dataGridView.Columns[6].Width = 100;
            }
        }

        private DataTable ConvertToDataTable(List<CheckIn> checkIns)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("IdCheckIn", typeof(int));
            dataTable.Columns.Add("Hora", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));
            dataTable.Columns.Add("FirmaCliente", typeof(string));
            dataTable.Columns.Add("PagoCliente", typeof(int));
            dataTable.Columns.Add("IdReserva", typeof(int));
            dataTable.Columns.Add("FuncionarioRut", typeof(int));

            foreach (var checkIn in checkIns)
            {
                DataRow row = dataTable.NewRow();

                row["IdCheckIn"] = checkIn.IdCheckIn;
                row["Hora"] = checkIn.Hora;
                row["Fecha"] = checkIn.Fecha;
                row["FirmaCliente"] = checkIn.FirmaCliente;
                row["PagoCliente"] = checkIn.PagoCliente;
                row["IdReserva"] = checkIn.IdReserva;
                row["FuncionarioRut"] = checkIn.FuncionarioRut;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
