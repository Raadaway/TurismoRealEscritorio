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
    public class NMantenimiento
    {
        public static DataTable ListarMantenimiento()
        {
            DDMantenimiento Datos = new DDMantenimiento();

            try
            {
                return Datos.ListarMantenimiento();
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                return null; // Puedes devolver un DataTable vacío o null en caso de error
            }
        }

        public bool AgregarMantenimiento(Entidades.Mantenimiento mant)
        {
            Datos.DDMantenimiento Datos = new Datos.DDMantenimiento();

            try
            {
                // Puedes realizar validaciones adicionales aquí antes de llamar a la capa de datos
                return Datos.AgregarMantenimiento(mant);
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                throw ex;
            }
        }

        public bool ModificarMantenimiento(int idMantenimiento, Entidades.Mantenimiento mant)
        {
            Datos.DDMantenimiento Datos = new Datos.DDMantenimiento();

            try
            {
                // Puedes realizar validaciones adicionales aquí antes de llamar a la capa de datos
                return Datos.ModificarMantenimiento(idMantenimiento, mant);
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                throw ex;
            }
        }

        public bool EliminarMantenimiento(int idMantenimiento)
        {
            Datos.DDMantenimiento Datos = new Datos.DDMantenimiento();

            try
            {
                // Puedes realizar validaciones adicionales aquí antes de llamar a la capa de datos
                return Datos.EliminarMantenimiento(idMantenimiento);
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                throw ex;
            }
        }

    }
}

