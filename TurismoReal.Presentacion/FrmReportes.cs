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
using Microsoft.Reporting.WinForms;

namespace TurismoReal.Presentacion
{
    public partial class FrmReportes : MetroFramework.Forms.MetroForm
    {
        private DataTable datable1;
        private DataTable datable2;
        private DataTable datable3;
        private DataTable datable4;
        private DataTable datable5;

        public FrmReportes()
        {
            InitializeComponent();
            InicializarDatos();
        }

        private void InicializarDatos()
        {
            
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            datable1 = NReportes.ReporteInventario();
            datable2 = NReportes.ReporteArticulos();
            datable3 = NReportes.ReporteGanancias(dtInicio.Value, dtTermino.Value);
            datable4 = NReportes.ReporteReservas(dtInicio.Value, dtTermino.Value);
            datable5 = NReportes.ReporteReservasCanceladas(dtInicio.Value, dtTermino.Value);

            rbGanancias.Checked = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInventario.Checked)
            {
                metroLabel3.Visible = false;
                metroGrid1.DataSource = datable1;
            }
            else if (rbArticulo.Checked)
            {
                metroLabel3.Visible = false;
                metroGrid1.DataSource = datable2;
            }
            else if (rbGanancias.Checked)
            {
                metroLabel3.Text = "Se están visualizando los registros entre las fechas " + dtInicio.Value.ToString("dd/MM/yyyy") + " y " + dtTermino.Value.ToString("dd/MM/yyyy");
                metroGrid1.DataSource = datable3;
            }
            else if (rbReservas.Checked)
            {
                metroLabel3.Text = "Se están visualizando los registros entre las fechas " + dtInicio.Value.ToString("dd/MM/yyyy") + " y " + dtTermino.Value.ToString("dd/MM/yyyy");
                metroGrid1.DataSource = datable4;
            }
            else
            {
                metroLabel3.Text = "Se están visualizando los registros entre las fechas " + dtInicio.Value.ToString("dd/MM/yyyy") + " y " + dtTermino.Value.ToString("dd/MM/yyyy");
                metroGrid1.DataSource = datable5;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGenerarReporte frm = new FrmGenerarReporte();

                if (rbInventario.Checked)
                {
                    List<ReporteInventario> lista = new List<ReporteInventario>();
                    lista = ListaInventario();
                    frm.repInventario.AddRange(lista);
                    frm.ShowDialog();
                }
                else if (rbArticulo.Checked)
                {
                    List<ReporteArticulo> lista = new List<ReporteArticulo>();
                    lista = ListaArticulos();
                    frm.repArticulo.AddRange(lista);
                    frm.ShowDialog();
                }
                else if (rbGanancias.Checked) 
                {
                    List<ReporteGanancias> lista = new List<ReporteGanancias>();
                    lista = ListaGanancias();
                    frm.repGanancias.AddRange(lista);
                    frm.fechaInicio = dtInicio.Value.ToString();
                    frm.fechaTermino = dtTermino.Value.ToString();
                    frm.ShowDialog();
                }
                else if (rbReservas.Checked)
                {
                    List<ReporteReservas> lista = new List<ReporteReservas>();
                    lista = ListaReservas();
                    frm.repReservas.AddRange(lista);
                    frm.fechaInicio = dtInicio.Value.ToString();
                    frm.fechaTermino = dtTermino.Value.ToString();
                    frm.ShowDialog();
                }
                else if (rbResCanceladas.Checked)
                {
                    List<ReporteReservasCanceladas> lista = new List<ReporteReservasCanceladas>();
                    lista = ListaReservasCanceladas();
                    frm.repReservasCanceladas.AddRange(lista);
                    frm.fechaInicio = dtInicio.Value.ToString();
                    frm.fechaTermino = dtTermino.Value.ToString();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de informe antes de generar el reporte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message);
            }
        }

        private List<ReporteInventario> ListaInventario()
        {
            List<ReporteInventario> lista = new List<ReporteInventario>();

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow || row.Cells.Count == 0 || (row.Cells[0].Value == null && row.Cells[1].Value == null && row.Cells[2].Value == null && row.Cells[3].Value == null))
                {
                    continue;
                }

                ReporteInventario repInv = new ReporteInventario();

                repInv.idArticulo = int.TryParse(row.Cells[0].Value?.ToString(), out var idArticulo) ? idArticulo : 0;
                repInv.descripcion = row.Cells[1].Value?.ToString() ?? string.Empty;
                repInv.idDepartamento = int.TryParse(row.Cells[2].Value?.ToString(), out var idDepartamento) ? idDepartamento : 0;
                repInv.cantidad = int.TryParse(row.Cells[3].Value?.ToString(), out var cantidad) ? cantidad : 0;

                lista.Add(repInv);
            }

            return lista;
        }

        private List<ReporteArticulo> ListaArticulos()
        {
            List<ReporteArticulo> lista = new List<ReporteArticulo>();

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow || row.Cells.Count == 0 || (row.Cells[0].Value == null && row.Cells[1].Value == null && row.Cells[2].Value == null && row.Cells[3].Value == null))
                {
                    continue;
                }

                ReporteArticulo repArt = new ReporteArticulo();

                repArt.idArticulo = int.TryParse(row.Cells[0].Value?.ToString(), out var idArticulo) ? idArticulo : 0;
                repArt.descripcion = row.Cells[1].Value?.ToString() ?? string.Empty;
                repArt.stock = int.TryParse(row.Cells[2].Value?.ToString(), out var stock) ? stock : 0;
                repArt.precio = int.TryParse(row.Cells[3].Value?.ToString(), out var precio) ? precio : 0;

                lista.Add(repArt);
            }

            return lista;
        }

        private List<ReporteGanancias> ListaGanancias()
        {
            List<ReporteGanancias> lista = new List<ReporteGanancias>();

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow || row.Cells.Count == 0 || (row.Cells[0].Value == null &&
                                                            row.Cells[1].Value == null &&
                                                            row.Cells[2].Value == null &&
                                                            row.Cells[3].Value == null &&
                                                            row.Cells[4].Value == null &&
                                                            row.Cells[5].Value == null))
                {
                    continue;
                }

                ReporteGanancias repGan = new ReporteGanancias();

                repGan.idReserva = int.TryParse(row.Cells[0].Value?.ToString(), out int idReserva) ? idReserva : 0;
                repGan.inicioReserva = DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime inicio) ? inicio : DateTime.MinValue;
                repGan.terminoReserva = DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime termino) ? termino : DateTime.MinValue;
                repGan.ganancias = int.TryParse(row.Cells[3].Value?.ToString(), out int ganancias) ? ganancias : 0;
                repGan.idDepartamento = int.TryParse(row.Cells[4].Value?.ToString(), out int idDepartamento) ? idDepartamento : 0;
                repGan.estadoReserva = row.Cells[5].Value?.ToString() ?? string.Empty;

                lista.Add(repGan);
            }

            return lista;
        }

        private List<ReporteReservas> ListaReservas()
        {
            List<ReporteReservas> lista = new List<ReporteReservas>();

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow || row.Cells.Count == 0 || (row.Cells[0].Value == null && row.Cells[1].Value == null && row.Cells[2].Value == null && row.Cells[3].Value == null))
                {
                    continue;
                }

                ReporteReservas repRes = new ReporteReservas();

                repRes.idDepartamento = int.TryParse(row.Cells[0].Value?.ToString(), out var idDepartamento) ? idDepartamento : 0;
                repRes.cantArriendos = int.TryParse(row.Cells[1].Value?.ToString(), out var cantArriendos) ? cantArriendos : 0;
                repRes.estadoReserva = row.Cells[2].Value?.ToString() ?? string.Empty;
                repRes.totalGenerado = int.TryParse(row.Cells[3].Value?.ToString(), out var totalGenerado) ? totalGenerado : 0;

                lista.Add(repRes);
            }

            return lista;
        }

        private List<ReporteReservasCanceladas> ListaReservasCanceladas()
        {
            List<ReporteReservasCanceladas> lista = new List<ReporteReservasCanceladas>();

            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (row.IsNewRow || row.Cells.Count == 0 || (row.Cells[0].Value == null && row.Cells[1].Value == null && row.Cells[2].Value == null && row.Cells[3].Value == null))
                {
                    continue;
                }

                ReporteReservasCanceladas repResCanc = new ReporteReservasCanceladas();

                repResCanc.idDepartamento = int.TryParse(row.Cells[0].Value?.ToString(), out var idDepartamento) ? idDepartamento : 0;
                repResCanc.cantArriendos = int.TryParse(row.Cells[1].Value?.ToString(), out var cantArriendos) ? cantArriendos : 0;
                repResCanc.estadoReserva = row.Cells[2].Value?.ToString() ?? string.Empty;
                repResCanc.totalGenerado = int.TryParse(row.Cells[3].Value?.ToString(), out var totalGenerado) ? totalGenerado : 0;

                lista.Add(repResCanc);
            }

            return lista;
        }
    }
}
