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
    public class NReserva
    {

        private DDReserva datosReserva; // Crear una instancia de la capa de datos

        public NReserva()
        {
            datosReserva = new DDReserva(); // Inicializar la capa de datos
        }

        public static List<Reserva> ListarReservas()
        {
            DDReserva Datos = new DDReserva(); // Suponiendo que tienes una clase de acceso a datos DDDatos

            try
            {
                return Datos.ListarReservas();
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                return null; // Puedes devolver una lista vacía o null en caso de error
            }
        }

        public static Reserva ListarReservaPorId(int idRes)
        {
            DDReserva Datos = new DDReserva(); // Suponiendo que tienes una clase de acceso a datos DDDatos

            try
            {
                return Datos.ListarReservaPorId(idRes);
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                return null; // Puedes devolver una lista vacía o null en caso de error
            }
        }

        public bool AgregarReserva(Reserva reserva)
        {

            try
            {
                // Puedes realizar validaciones adicionales aquí antes de llamar a la capa de datos
                return datosReserva.AgregarReserva(reserva);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa de negocio al agregar reserva: " + ex.Message);
                return false;
            }
        }

        public static bool ModificarReserva(int idReserva, DateTime inicioReserva, DateTime terminoReserva, int cantPersonas, int montoTotal, int montoAbonado, int idDepartamento)
        {
            DDReserva datos = new DDReserva();
            return datos.ModificarReserva(idReserva, inicioReserva, terminoReserva, cantPersonas, montoTotal, montoAbonado, idDepartamento);
        }


        public static bool EliminarReserva(int idReserva)
        {
            DDReserva datos = new DDReserva();
            return datos.EliminarReserva(idReserva);
        }


    }


}
