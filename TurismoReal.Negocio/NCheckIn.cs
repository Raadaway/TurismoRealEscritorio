using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TurismoReal.Datos;
using TurismoReal.Entidades;
using System.Collections;

namespace TurismoReal.Negocio
{
    public class NCheckIn
    {
        public static DataTable ListarCheckIn()
        {
            DDCheckIn datos = new DDCheckIn();

            try
            {
                return datos.ListarCheckInDesdeWebService();
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                return null; // Puedes devolver un DataTable vacío o null en caso de error
            }
        }

        public static bool AgregarCheckIn(string firma, int pago, int idRes, int rutFunc)
        {
            DDCheckIn Datos = new DDCheckIn();
            bool exito = Datos.AgregarCheckIn(firma, pago, idRes, rutFunc);
            return exito;
        }

        public static bool ModificarCheckIn(int idCheckIn, string firma, int pago)
        {
            bool exito = false;
            DDCheckIn datos = new DDCheckIn();
            try
            {
                exito = datos.ModificarCheckIn(idCheckIn, firma, pago);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return exito;
        }

        public static bool EliminarCheckIn(int idCheckIn)
        {
            bool exito = false;
            DDCheckIn datos = new DDCheckIn();
            try
            {
                exito = datos.EliminarCheckIn(idCheckIn);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return exito;
        }
    }
}
