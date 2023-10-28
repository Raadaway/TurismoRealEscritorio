using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;

namespace TurismoReal.Datos
{
    public class DDReserva
    {
        public List<Reserva> ListarReservas()
        {
            WSPortafolioClient client = null;
            List<Reserva> reservas = new List<Reserva>();

            try
            {
                client = new WSPortafolioClient();
                var reservasWebService = client.listarReserva();

                if (reservasWebService != null)
                {
                    foreach (var reservaWebService in reservasWebService)
                    {
                        Reserva reserva = new Reserva
                        {
                            id_reserva = reservaWebService.id_reserva,
                            inicio_reserva = reservaWebService.inicio_reserva,
                            termino_reserva = reservaWebService.termino_reserva,
                            cant_personas = reservaWebService.cant_personas,
                            monto_total = reservaWebService.monto_total,
                            monto_abonado = reservaWebService.monto_abonado,
                            departamento_id_departamento = reservaWebService.id_departamento,
                            cliente_rut = reservaWebService.cliente_rut,
                            estado_res_id_estado = reservaWebService.id_estado
                        };

                        reservas.Add(reserva);
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

            return reservas;
        }

        /*public bool AgregarReserva(Reserva reserva)
        {
            WSPortafolioClient client = null;

            try
            {
                client = new WSPortafolioClient();

                // Mapea los datos de la entidad "Reserva" al objeto del servicio web
                var reservaWebService = new WSportafolio.reserva
                {
                    inicio_reserva = reserva.inicio_reserva,
                    termino_reserva = reserva.termino_reserva,
                    cant_personas = reserva.cant_personas,
                    monto_total = reserva.monto_total,
                    monto_abonado = reserva.monto_abonado,
                    id_departamento = reserva.departamento_id_departamento,
                    cliente_rut = reserva.cliente_rut,
                    id_estado = reserva.estado_res_id_estado
                };

                // Llama al método del servicio web para agregar la reserva
                return client.agregarReserva(reservaWebService);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa de datos al agregar reserva: " + ex.Message);
                return false; // Indica que la operación no se realizó con éxito
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }*/






    }
}
