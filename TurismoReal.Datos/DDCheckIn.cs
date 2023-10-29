using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;

namespace TurismoReal.Datos
{
    public class DDCheckIn
    {
        public DataTable ListarCheckInDesdeWebService()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para obtener una lista de Check-In
                checkIn[] listaCheckIn = client.listarCheckIn();

                if (listaCheckIn != null && listaCheckIn.Length > 0)
                {
                    // Configurar las columnas del DataTable
                    dataTable.Columns.Add("IdCheckIn", typeof(int));
                    dataTable.Columns.Add("Hora", typeof(string));
                    dataTable.Columns.Add("Fecha", typeof(DateTime));
                    dataTable.Columns.Add("FirmaCliente", typeof(string));
                    dataTable.Columns.Add("PagoCliente", typeof(int));
                    dataTable.Columns.Add("IdReserva", typeof(int));
                    dataTable.Columns.Add("FuncionarioRut", typeof(int));

                    foreach (var checkIn in listaCheckIn)
                    {
                        // Crear una nueva fila en el DataTable
                        DataRow row = dataTable.NewRow();

                        // Asignar los valores del Check-In a las columnas correspondientes
                        row["IdCheckIn"] = checkIn.id_check_in;
                        row["Hora"] = checkIn.hora;
                        row["Fecha"] = checkIn.fecha;
                        row["FirmaCliente"] = checkIn.firma_cliente;
                        row["PagoCliente"] = checkIn.pago_cliente;
                        row["IdReserva"] = checkIn.id_reserva;
                        row["FuncionarioRut"] = checkIn.funcionario_rut;

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

        public bool AgregarCheckIn(string firma, int pago, int idRes, int rutFunc)
        {
            bool ward = false;
            WSPortafolioClient client = null; // Declaración del cliente proxy

            try
            {
                client = new WSPortafolioClient(); // Crear instancia del cliente proxy

                // Llamar al procedimiento agregarAdministrador del servicio web
                ward = client.agregarCheckIn(firma, pago, idRes, rutFunc);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                Console.WriteLine("Error al agregar Check-In: " + ex.Message);
            }
            finally
            {
                // Cerrar el cliente proxy
                if (client != null)
                {
                    client.Close();
                }
            }
            return ward;
        }

    }
}
