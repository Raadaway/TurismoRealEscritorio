using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;
using TurismoReal.Entidades.WSportafolio;

namespace TurismoReal.Datos
{
    public class DDReserva
    {
        public List<Reserva> ListarReservas()
        {
            WSportafolio.WSPortafolioClient client = null;
            List<Reserva> reservas = new List<Reserva>();

            try
            {
                client = new WSportafolio.WSPortafolioClient();
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
                            estado_reserva = reservaWebService.nom_estado
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

        public Reserva ListarReservaPorId(int idRes)
        {
            WSportafolio.WSPortafolioClient client = null;
            Reserva res = new Reserva();
            try
            {
                client = new WSportafolio.WSPortafolioClient();
                var reservaWebService = client.listarReservaPorId(idRes);

                if (reservaWebService != null)
                {
                    res.id_reserva = reservaWebService.id_reserva;
                    res.inicio_reserva = reservaWebService.inicio_reserva;
                    res.termino_reserva = reservaWebService.termino_reserva;
                    res.cant_personas = reservaWebService.cant_personas;
                    res.monto_total = reservaWebService.monto_total;
                    res.monto_abonado = reservaWebService.monto_abonado;
                    res.departamento_id_departamento = reservaWebService.id_departamento;
                    res.cliente_rut = reservaWebService.cliente_rut;
                    res.estado_reserva = reservaWebService.nom_estado;
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

            return res;
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
