using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos;
using TurismoReal.Entidades;

namespace TurismoReal.Negocio
{
    public class NFormaPago
    {
        public static List<FormaPago> ListarFormaPago()
        {
            DDFormaPago datos = new DDFormaPago();
            List<FormaPago> lista = datos.ListarFormaPago();

            return lista;
        }

        public static bool AgregarPago(int montoPago, int idReserva, int idFormaPago)
        {
            DDFormaPago datos = new DDFormaPago();
            bool ward = datos.AgregarPago(montoPago, idReserva, idFormaPago);

            return ward;
        }
    }
}
