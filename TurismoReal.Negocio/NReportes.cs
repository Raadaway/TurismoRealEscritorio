using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos;

namespace TurismoReal.Negocio
{
    public class NReportes
    {

        public static DataTable ReporteInventario()
        {
            DDReportes datos = new DDReportes();

            try
            {
                return datos.ReporteInventario();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable ReporteArticulos()
        {
            DDReportes datos = new DDReportes();

            try
            {
                return datos.ReporteArticulo();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable ReporteGanancias(DateTime fechaInicio, DateTime fechaTermino)
        {
            DDReportes datos = new DDReportes();

            try
            {
                return datos.ReporteGanancias(fechaInicio, fechaTermino);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable ReporteReservas(DateTime fechaInicio, DateTime fechaTermino)
        {
            DDReportes datos = new DDReportes();

            try
            {
                return datos.ReporteReservas(fechaInicio, fechaTermino);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable ReporteReservasCanceladas(DateTime fechaInicio, DateTime fechaTermino)
        {
            DDReportes datos = new DDReportes();

            try
            {
                return datos.ReporteReservasCanceladas(fechaInicio, fechaTermino);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
