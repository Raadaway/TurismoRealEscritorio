using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos.WSportafolio;

namespace TurismoReal.Datos
{
    public class DDReportes
    {
        public DataTable ReporteInventario()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                reporteInventario[] lista = client.reportesInventarios();

                if (lista != null && lista.Length > 0)
                {
                    dataTable.Columns.Add("ID Artículo", typeof(int));
                    dataTable.Columns.Add("Descripción", typeof(string));
                    dataTable.Columns.Add("ID Departamento", typeof(int));
                    dataTable.Columns.Add("Cantidad", typeof(int));

                    foreach (var rep in lista)
                    {
                        DataRow row = dataTable.NewRow();

                        row["ID Artículo"] = rep.id_articulo;
                        row["Descripción"] = rep.descripcion;
                        row["ID Departamento"] = rep.id_departamento;
                        row["Cantidad"] = rep.cantidad;

                        dataTable.Rows.Add(row);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        public DataTable ReporteArticulo()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                reporteArticulos[] lista = client.reportesArticulos();

                if (lista != null && lista.Length > 0)
                {
                    dataTable.Columns.Add("ID Artículo", typeof(int));
                    dataTable.Columns.Add("Descripción", typeof(string));
                    dataTable.Columns.Add("Stock", typeof(int));
                    dataTable.Columns.Add("Precio", typeof(int));

                    foreach (var rep in lista)
                    {
                        DataRow row = dataTable.NewRow();

                        row["ID Artículo"] = rep.id_articulo;
                        row["Descripción"] = rep.descripcion;
                        row["Stock"] = rep.stock;
                        row["Precio"] = rep.precio_articulo;

                        dataTable.Rows.Add(row);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        public DataTable ReporteGanancias(DateTime fechaInicio, DateTime fechaTermino)
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                var fechaInicioStr = fechaInicio.ToString("yyyy-MM-dd");
                var fechaTerminoStr = fechaTermino.ToString("yyyy-MM-dd");

                client = new WSPortafolioClient();

                reporteGanancias[] lista = client.reportesGanancias(fechaInicioStr, fechaTerminoStr);

                if (lista != null && lista.Length > 0)
                {
                    dataTable.Columns.Add("ID Reserva", typeof(int));
                    dataTable.Columns.Add("Fecha Inicio", typeof(DateTime));
                    dataTable.Columns.Add("Fecha Término", typeof(DateTime));
                    dataTable.Columns.Add("Ganancias", typeof(int));
                    dataTable.Columns.Add("ID Departamento", typeof(int));
                    dataTable.Columns.Add("Estado Reserva", typeof(string));

                    foreach (var rep in lista)
                    {
                        DataRow row = dataTable.NewRow();

                        row["ID Reserva"] = rep.id_reserva;
                        row["Fecha Inicio"] = rep.inicio_reserva;
                        row["Fecha Término"] = rep.termino_reserva;
                        row["Ganancias"] = rep.ganancias;
                        row["ID Departamento"] = rep.departamento;
                        row["Estado Reserva"] = rep.estado_reserva;

                        dataTable.Rows.Add(row);
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        public DataTable ReporteReservas(DateTime fechaInicio, DateTime fechaTermino)
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                var fechaInicioStr = fechaInicio.ToString("yyyy-MM-dd");
                var fechaTerminoStr = fechaTermino.ToString("yyyy-MM-dd");

                client = new WSPortafolioClient();

                reporteReservas[] lista = client.reportesReservas(fechaInicioStr, fechaTerminoStr);

                if (lista != null && lista.Length > 0)
                {
                    dataTable.Columns.Add("ID Departamento", typeof(int));
                    dataTable.Columns.Add("Cantidad Arriendos", typeof(int));
                    dataTable.Columns.Add("Estado Reserva", typeof(string));
                    dataTable.Columns.Add("Generado en Multas", typeof(int));

                    foreach (var rep in lista)
                    {
                        DataRow row = dataTable.NewRow();

                        row["ID Departamento"] = rep.departamento;
                        row["Cantidad Arriendos"] = rep.cantidad_arriendos;
                        row["Estado Reserva"] = rep.estado_reserva;
                        row["Generado en Multas"] = rep.generado_multas;

                        dataTable.Rows.Add(row);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        public DataTable ReporteReservasCanceladas(DateTime fechaInicio, DateTime fechaTermino)
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                var fechaInicioStr = fechaInicio.ToString("yyyy-MM-dd");
                var fechaTerminoStr = fechaTermino.ToString("yyyy-MM-dd");

                client = new WSPortafolioClient();

                reporteCancelaciones[] lista = client.reportesReservasCanceladas(fechaInicioStr, fechaTerminoStr);

                if (lista != null && lista.Length > 0)
                {
                    dataTable.Columns.Add("ID Departamento", typeof(int));
                    dataTable.Columns.Add("Cantidad Arriendos", typeof(int));
                    dataTable.Columns.Add("Estado Reserva", typeof(string));
                    dataTable.Columns.Add("Generado en Multas", typeof(int));

                    foreach (var rep in lista)
                    {
                        DataRow row = dataTable.NewRow();

                        row["ID Departamento"] = rep.departamento;
                        row["Cantidad Arriendos"] = rep.cantidad_arriendos;
                        row["Estado Reserva"] = rep.estado_reserva;
                        row["Generado en Multas"] = rep.generado;

                        dataTable.Rows.Add(row);
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }
    }
}
