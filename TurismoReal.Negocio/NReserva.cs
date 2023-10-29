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

    }

    
}
