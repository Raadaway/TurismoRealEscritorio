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
        public static DataTable ListarCheckOut()
        {
            DDCheckOut datos = new DDCheckOut();

            try
            {
                return datos.ListarCheckOutDesdeWebService();
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                return null; // Puedes devolver un DataTable vacío o null en caso de error
            }
        }

        public static bool AgregarCheckOut(int multa, int pago, string firma, int idRes, int rutFunc)
        {
            DDCheckOut Datos = new DDCheckOut();
            bool exito = false;

            try
            {
                exito = Datos.AgregarCheckOut(multa, pago, firma, idRes, rutFunc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                exito = true;
            }
            return exito;
        }

        public static bool ModificarCheckOut(int idCheckOut, int multa, int pago, string firma)
        {
            bool exito = false;
            DDCheckOut datos = new DDCheckOut();
            try
            {
                exito = datos.ModificarCheckOut(idCheckOut, multa, pago, firma);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return exito;
        }

        public static bool EliminarCheckOut(int idCheckOut)
        {
            bool exito = false;
            DDCheckOut datos = new DDCheckOut();
            try
            {
                exito = datos.EliminarCheckOut(idCheckOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return exito;
        }
    }
}
