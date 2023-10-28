using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;

namespace TurismoReal.Datos
{
    public class DDCheckOut
    {
        public DataTable ListarCheckOutDesdeWebService()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para obtener una lista de Check-Out
                checkOut[] listaCheckOut = client.listarCheckOut();

                if (listaCheckOut != null && listaCheckOut.Length > 0)
                {
                    // Configurar las columnas del DataTable
                    dataTable.Columns.Add("IdCheckOut", typeof(int));
                    dataTable.Columns.Add("Hora", typeof(string));
                    dataTable.Columns.Add("Fecha", typeof(DateTime));
                    dataTable.Columns.Add("Multas", typeof(int));
                    dataTable.Columns.Add("PagoCliente", typeof(int));
                    dataTable.Columns.Add("FirmaCliente", typeof(string));
                    dataTable.Columns.Add("IdReserva", typeof(int));
                    dataTable.Columns.Add("FuncionarioRut", typeof(int));

                    foreach (var checkOut in listaCheckOut)
                    {
                        // Crear una nueva fila en el DataTable
                        DataRow row = dataTable.NewRow();

                        // Asignar los valores del Check-Out a las columnas correspondientes
                        row["IdCheckOut"] = checkOut.id_check_out;
                        row["Hora"] = checkOut.hora;
                        row["Fecha"] = checkOut.fecha;
                        row["Multas"] = checkOut.multas;
                        row["PagoCliente"] = checkOut.pago_cliente;
                        row["FirmaCliente"] = checkOut.firma_cliente;
                        row["IdReserva"] = checkOut.id_reserva;
                        row["FuncionarioRut"] = checkOut.funcionario_rut;

                        // Agregar la fila al DataTable
                        dataTable.Rows.Add(row);
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
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
