using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos;

namespace TurismoReal.Negocio
{
    public class NActualizarEstados
    {

        public static bool ActualizarEstadoDepaAOcupado(int idDepa)
        {
            DDActualizarEstados datos = new DDActualizarEstados();
            bool resultado = datos.ActualizarEstadoDepaAOcupado(idDepa);
            return resultado;
        }

        public static bool ActualizarEstadoDepaADisponibleReserva(int idDepa)
        {
            DDActualizarEstados datos = new DDActualizarEstados();
            bool resultado = datos.ActualizarEstadoDepaADisponibleReserva(idDepa);
            return resultado;
        }
    }
}
