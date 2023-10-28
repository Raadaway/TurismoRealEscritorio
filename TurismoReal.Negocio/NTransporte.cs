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
    public class NTransporte
    {
        public static List<Transporte> ListarTransporte()
        {
            DDTransporte datosTransporte = new DDTransporte();

            try
            {
                DataTable dataTable = datosTransporte.ListarTransporteDesdeWebService();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    List<Transporte> transportes = new List<Transporte>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Transporte transporte = new Transporte
                        {
                            IdTransporte = Convert.ToInt32(row["IdTransporte"]),
                            NombreEmpresa = row["NombreEmpresa"].ToString(),
                            Horario = row["Horario"].ToString(),
                            Patente = row["Patente"].ToString(),
                            TarifaAdicional = Convert.ToInt32(row["TarifaAdicional"]),
                            RutChofer = Convert.ToInt32(row["RutChofer"])
                        };

                        transportes.Add(transporte);
                    }

                    return transportes;
                }
                else
                {
                    return new List<Transporte>();
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
