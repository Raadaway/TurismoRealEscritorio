using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Entidades;
using System.Linq;
using TurismoReal.Datos.WSportafolio;

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
            WSPortafolioClient client = null;
            Reserva res = new Reserva();
            try
            {
                client = new WSPortafolioClient();
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

        public bool AgregarReserva(Reserva reserva)
        {
            WSPortafolioClient client = null;
            bool result = false;

            try
            {
                client = new WSPortafolioClient();

                var inicioReservaStr = reserva.inicio_reserva.ToString("yyyy-MM-dd");
                var terminoReservaStr = reserva.termino_reserva.ToString("yyyy-MM-dd");

                result = client.agregarReserva(
                    inicioReservaStr,
                    terminoReservaStr,
                    reserva.cant_personas,
                    reserva.monto_total,
                    reserva.monto_abonado,
                    reserva.departamento_id_departamento,
                    reserva.cliente_rut,
                    reserva.id_reserva
                );
            }
            catch (Exception ex)
            {
                // Registra el mensaje de error en un registro o archivo de registro
                RegistrarError("Error en capa de datos al agregar reserva: " + ex.Message);
                // Lanza la excepción nuevamente para que la capa de negocios pueda manejarla
                throw;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }

            return result;
        }

        private void RegistrarError(string mensaje)
        {

            Console.WriteLine(mensaje);
        }

        public bool ModificarReserva(int idReserva, DateTime inicioReserva, DateTime terminoReserva, int cantPersonas, int montoTotal, int montoAbonado, int idDepartamento)
        {
            try
            {
                WSPortafolioClient client = new WSPortafolioClient();
                bool resultado = client.modificarReserva(idReserva, inicioReserva.ToString("yyyy-MM-dd"), terminoReserva.ToString("yyyy-MM-dd"), cantPersonas, montoTotal, montoAbonado, idDepartamento);
                client.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar reserva a través del servicio web: " + ex.Message);
                return false;
            }
        }


        public bool EliminarReserva(int idReserva)
        {
            try
            {
                WSPortafolioClient client = new WSPortafolioClient();
                bool resultado = client.eliminarReserva(idReserva);
                client.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar reserva a través del servicio web: " + ex.Message);
                return false;
            }
        }






    }
}
