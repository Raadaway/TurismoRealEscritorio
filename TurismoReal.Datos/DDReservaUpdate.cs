using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Entidades;
using TurismoReal.Datos.WSportafolio;

namespace TurismoReal.Datos
{
    public class DDReservaUpdate
    {
        public List<ReservaUpdate> ListarReservaUpdate(int idReserva)
        {
            WSPortafolioClient client = null;
            List<ReservaUpdate> lista = new List<ReservaUpdate>();

            try
            {
                client = new WSPortafolioClient();
                var resultadoWS = client.listarReservaUpdate(idReserva);

                if (resultadoWS != null)
                {
                    foreach (var listaWS in resultadoWS)
                    {
                        ReservaUpdate reserva = new ReservaUpdate
                        {
                            idUpdate = listaWS.id_update,
                            montoTotal = listaWS.monto_total,
                            montoAbonado = listaWS.monto_abonado,
                            fecha = listaWS.fecha,
                            hora = listaWS.hora,
                            idReserva = listaWS.id_reserva,
                            descripcion = listaWS.descripcion
                        };

                        lista.Add(reserva);
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

            return lista;
        }
    }
}
