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
    public class NTransporte
    {
        public static DataTable ListarTransporte()
        {
            DDTransporte datosTransporte = new DDTransporte();

            try
            {
                return datosTransporte.ListarTransporteDesdeWebService();
            }
            catch (Exception ex)
            {
                // Puedes manejar la excepción, registrar el error o mostrar un mensaje de error si es necesario
                return null; // Puedes devolver un DataTable vacío o null en caso de error
            }
        }
    }
}
