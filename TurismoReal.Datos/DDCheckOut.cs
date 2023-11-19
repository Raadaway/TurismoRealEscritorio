using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Entidades;
using System.Linq;
using TurismoReal.Entidades.WSportafolio;

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
                    dataTable.Columns.Add("Id Check-Out", typeof(int));
                    dataTable.Columns.Add("Hora", typeof(string));
                    dataTable.Columns.Add("Fecha", typeof(DateTime));
                    dataTable.Columns.Add("Multas", typeof(int));
                    dataTable.Columns.Add("Pago Cliente", typeof(int));
                    dataTable.Columns.Add("Firma Cliente", typeof(string));
                    dataTable.Columns.Add("Id Reserva", typeof(int));
                    dataTable.Columns.Add("Rut Funcionario", typeof(int));

                    foreach (var checkOut in listaCheckOut)
                    {
                        // Crear una nueva fila en el DataTable
                        DataRow row = dataTable.NewRow();

                        // Asignar los valores del Check-Out a las columnas correspondientes
                        row["Id Check-Out"] = checkOut.id_check_out;
                        row["Hora"] = checkOut.hora;
                        row["Fecha"] = checkOut.fecha;
                        row["Multas"] = checkOut.multas;
                        row["Pago Cliente"] = checkOut.pago_cliente;
                        row["Firma Cliente"] = checkOut.firma_cliente;
                        row["Id Reserva"] = checkOut.id_reserva;
                        row["Rut Funcionario"] = checkOut.funcionario_rut;

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

        public bool AgregarCheckOut(int multa, int pago, string firma, int idRes, int rutFunc)
        {
            bool ward = false;
            WSPortafolioClient client = null; // Declaración del cliente proxy

            try
            {
                client = new WSPortafolioClient(); // Crear instancia del cliente proxy

                // Llamar al procedimiento agregarAdministrador del servicio web
                ward = client.agregarCheckOut(multa, pago, firma, idRes, rutFunc);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                Console.WriteLine("Error al agregar Check-Out: " + ex.Message);
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

        public bool ModificarCheckOut(int idCheckOut, int multa, int pago, string firma)
        {
            bool ward = false;
            WSPortafolioClient client = null;

            try
            {
                client = new WSPortafolioClient();

                // Llama al procedimiento modificarAdministrador del servicio web con dos valores de rut
                ward = client.modificarCheckOut(idCheckOut, multa, pago, firma);


                if (ward)
                {
                    Console.WriteLine("Check-Out actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("Error al actualizar Check-Out.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar Check-Out: " + ex.Message);
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

        public bool EliminarCheckOut(int idCheckOut)
        {
            bool ward = false;
            WSPortafolioClient client = null;

            try
            {
                client = new WSPortafolioClient();
                ward = client.eliminarCheckOut(idCheckOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar Check-Out: " + ex.Message);
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
