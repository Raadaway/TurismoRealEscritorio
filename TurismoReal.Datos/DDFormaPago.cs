using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Entidades;
using TurismoReal.Datos.WSportafolio;

namespace TurismoReal.Datos
{
    public class DDFormaPago
    {
        public List<FormaPago> ListarFormaPago()
        {
            WSPortafolioClient cliente = new WSPortafolioClient();
            List<FormaPago> lista = new List<FormaPago>();

            try
            {
                formaPago[] listaWS = cliente.listarFormaPago();

                foreach (formaPago formaPagoWS in listaWS)
                {
                    FormaPago clase = new FormaPago
                    {
                        idFormaPago = formaPagoWS.id_forma_pago,
                        nombre = formaPagoWS.nombre,
                    };
                    lista.Add(clase);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            return lista;
        }

        public bool AgregarPago(int montoPago, int idReserva, int idFormaPago)
        {
            bool ward = false;
            WSPortafolioClient cliente = null;

            try
            {
                cliente = new WSPortafolioClient();

                ward = cliente.agregarPago(montoPago, idReserva, idFormaPago);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                Console.WriteLine("Error al agregar el pago: " + ex.Message);
            }
            finally
            {
                // Cerrar el cliente proxy
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            return ward;
        }
    }
}
