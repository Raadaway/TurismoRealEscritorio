using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Entidades;
using TurismoReal.Datos.WSportafolio;
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
                    dataTable.Columns.Add("Id Check-In", typeof(int));
                    dataTable.Columns.Add("Hora", typeof(string));
                    dataTable.Columns.Add("Fecha", typeof(DateTime));
                    dataTable.Columns.Add("Firma Cliente", typeof(string));
                    dataTable.Columns.Add("Pago Cliente", typeof(int));
                    dataTable.Columns.Add("Id Reserva", typeof(int));
                    dataTable.Columns.Add("Rut Funcionario", typeof(int));

                    foreach (var checkIn in listaCheckIn)
                    {
                        // Crear una nueva fila en el DataTable
                        DataRow row = dataTable.NewRow();

                        // Asignar los valores del Check-In a las columnas correspondientes
                        row["Id Check-In"] = checkIn.id_check_in;
                        row["Hora"] = checkIn.hora;
                        row["Fecha"] = checkIn.fecha;
                        row["Firma Cliente"] = checkIn.firma_cliente;
                        row["Pago Cliente"] = checkIn.pago_cliente;
                        row["Id Reserva"] = checkIn.id_reserva;
                        row["Rut Funcionario"] = checkIn.funcionario_rut;

                        // Agregar la fila al DataTable
                        dataTable.Rows.Add(row);
                    }
                }
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
            return dataTable;
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

        public bool ModificarCheckIn(int idCheckIn, string firma, int pago)
        {
            bool ward = false;
            WSPortafolioClient client = null;

            try
            {
                client = new WSPortafolioClient();

                // Llama al procedimiento modificarAdministrador del servicio web con dos valores de rut
                ward = client.modificarCheckIn(idCheckIn, firma, pago);


                if (ward)
                {
                    Console.WriteLine("Check-In actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("Error al actualizar Check-In.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar Check-In: " + ex.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }

            return ward;
        }

        public bool EliminarCheckIn(int idCheckIn)
        {
            bool ward = false;
            WSPortafolioClient client = null;

            try
            {
                client = new WSPortafolioClient();
                ward = client.eliminarCheckIn(idCheckIn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar Check-In: " + ex.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
            return ward;
        }

    }
}
