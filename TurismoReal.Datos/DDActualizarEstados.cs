using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos.WSportafolio;

namespace TurismoReal.Datos
{
    public class DDActualizarEstados
    {
        public bool ActualizarEstadoDepaAOcupado(int idDepa)
        {
            WSPortafolioClient cliente = null;
            bool ward = false;
            try
            {
                cliente = new WSPortafolioClient();
                ward = cliente.estadoDepaOcupado(idDepa);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                throw ex;
            }
            finally
            {
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            return ward;
        }

        public bool ActualizarEstadoDepaADisponibleReserva(int idDepa)
        {
            WSPortafolioClient cliente = null;
            bool ward = false;
            try
            {
                cliente = new WSPortafolioClient();
                ward = cliente.estadoDepaDisponibleTerminoReserva(idDepa);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                throw ex;
            }
            finally
            {
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            return ward;
        }

        public bool ActualizarEstadoDepaAMantenimiento(int idDepa)
        {
            WSPortafolioClient cliente = null;
            bool ward = false;
            try
            {
                cliente = new WSPortafolioClient();
                ward = cliente.estadoDepaMantenimiento(idDepa);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                throw ex;
            }
            finally
            {
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            return ward;
        }
    }
}
