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
    public class NCheckIn
    {
        public static List<CheckIn> ListarCheckIn()
        {
            DDCheckIn datosCheckIn = new DDCheckIn();

            try
            {
                DataTable dataTable = datosCheckIn.ListarCheckInDesdeWebService();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    List<CheckIn> checkIns = new List<CheckIn>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        CheckIn checkIn = new CheckIn
                        {
                            IdCheckIn = Convert.ToInt32(row["IdCheckIn"]),
                            Hora = row["Hora"].ToString(),
                            Fecha = Convert.ToDateTime(row["Fecha"]),
                            FirmaCliente = row["FirmaCliente"].ToString(),
                            PagoCliente = Convert.ToInt32(row["PagoCliente"]),
                            IdReserva = Convert.ToInt32(row["IdReserva"]),
                            FuncionarioRut = Convert.ToInt32(row["FuncionarioRut"])
                        };

                        checkIns.Add(checkIn);
                    }

                    return checkIns;
                }
                else
                {
                    return new List<CheckIn>();
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
