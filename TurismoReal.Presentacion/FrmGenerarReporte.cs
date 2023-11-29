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
using Microsoft.Reporting.WinForms;

namespace TurismoReal.Presentacion
{
    public partial class FrmGenerarReporte : MetroFramework.Forms.MetroForm
    {
        public List<ReporteInventario> repInventario = new List<ReporteInventario>();
        public List<ReporteArticulo> repArticulo = new List<ReporteArticulo>();
        public List<ReporteGanancias> repGanancias = new List<ReporteGanancias>();
        public List<ReporteReservas> repReservas = new List<ReporteReservas>();
        public List<ReporteReservasCanceladas> repReservasCanceladas = new List<ReporteReservasCanceladas>();
        public string fechaInicio;
        public string fechaTermino;

        public FrmGenerarReporte()
        {
            InitializeComponent();
        }

        private void FrmGenerarReporte_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            if (repArticulo.Any())
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", repArticulo));

                reportViewer1.LocalReport.ReportEmbeddedResource = "TurismoReal.Presentacion.Reportes.ReporteArticulo.rdlc";
            }
            else if (repInventario.Any())
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", repInventario));

                reportViewer1.LocalReport.ReportEmbeddedResource = "TurismoReal.Presentacion.Reportes.ReporteInventario.rdlc";
            }
            else if (repGanancias.Any())
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", repGanancias));

                reportViewer1.LocalReport.ReportEmbeddedResource = "TurismoReal.Presentacion.Reportes.ReporteGanancias.rdlc";

                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("rpFechaInicio", fechaInicio);
                parametros[1] = new ReportParameter("rpFechaTermino", fechaTermino);

                reportViewer1.LocalReport.SetParameters(parametros);
            }
            else if (repReservas.Any())
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", repReservas));

                reportViewer1.LocalReport.ReportEmbeddedResource = "TurismoReal.Presentacion.Reportes.ReporteReservas.rdlc";

                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("rpFechaInicio", fechaInicio);
                parametros[1] = new ReportParameter("rpFechaTermino", fechaTermino);

                reportViewer1.LocalReport.SetParameters(parametros);
            }
            else if (repReservasCanceladas.Any())
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", repReservasCanceladas));

                reportViewer1.LocalReport.ReportEmbeddedResource = "TurismoReal.Presentacion.Reportes.ReporteReservasCanceladas.rdlc";

                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("rpFechaInicio", fechaInicio);
                parametros[1] = new ReportParameter("rpFechaTermino", fechaTermino);

                reportViewer1.LocalReport.SetParameters(parametros);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
