using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TurismoReal.Datos;
using TurismoReal.Entidades;

namespace TurismoReal.Negocio
{
    public class NCheckOut
    {
        public static List<CheckOut> ListarCheckOut()
        {
            DDCheckOut datosCheckOut = new DDCheckOut();

            try
            {
                DataTable dataTable = datosCheckOut.ListarCheckOutDesdeWebService();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    List<CheckOut> checkOuts = new List<CheckOut>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        CheckOut checkOut = new CheckOut
                        {
                            IdCheckOut = Convert.ToInt32(row["IdCheckOut"]),
                            Hora = row["Hora"].ToString(),
                            Fecha = Convert.ToDateTime(row["Fecha"]),
                            Multas = Convert.ToInt32(row["Multas"]),
                            PagoCliente = Convert.ToInt32(row["PagoCliente"]),
                            FirmaCliente = row["FirmaCliente"].ToString(),
                            IdReserva = Convert.ToInt32(row["IdReserva"]),
                            FuncionarioRut = Convert.ToInt32(row["FuncionarioRut"])
                        };

                        checkOuts.Add(checkOut);
                    }

                    return checkOuts;
                }
                else
                {
                    return new List<CheckOut>();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, registrar el error o mostrar un mensaje de error si es necesario.
                return null; // Puedes devolver una lista vacía o null en caso de error.
            }
        }
    }
}
