using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using WSPortafolioClient = TurismoReal.Datos.WSportafolio.WSPortafolioClient;

namespace TurismoReal.Datos
{
    public class DDComuna
    {
        public List<Comuna> ListarComunas()
        {
            WSPortafolioClient cliente = new WSPortafolioClient();
            List<Comuna> lista = new List<Comuna>();

            try
            {
                comuna[] comunaWebService = cliente.listarComuna();

                foreach (comuna comwebser in comunaWebService)
                {
                    Comuna comuna = new Comuna
                    {
                        idComuna = comwebser.id_comuna,
                        nombreComuna = comwebser.nombre_comuna,
                        idRegion = comwebser.id_region,
                    };
                    lista.Add(comuna);
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
    }
}
