using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;

namespace TurismoReal.Datos
{
    public class DDTransporte
    {
        public DataTable ListarTransporteDesdeWebService()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para obtener una lista de transportes
                transporte[] listaTransportes = client.listarTransporte();

                // Configurar las columnas del DataTable
                dataTable.Columns.Add("IdTransporte", typeof(int));
                dataTable.Columns.Add("NombreEmpresa", typeof(string));
                dataTable.Columns.Add("Horario", typeof(string));
                dataTable.Columns.Add("Patente", typeof(string));
                dataTable.Columns.Add("TarifaAdicional", typeof(int));
                dataTable.Columns.Add("RutChofer", typeof(int));

                foreach (var transporte in listaTransportes)
                {
                    // Crear una nueva fila en el DataTable
                    DataRow row = dataTable.NewRow();

                    // Asignar los valores del transporte a las columnas correspondientes
                    row["IdTransporte"] = transporte.id_transporte;
                    row["NombreEmpresa"] = transporte.nom_empresa;
                    row["Horario"] = transporte.horario;
                    row["Patente"] = transporte.patente;
                    row["TarifaAdicional"] = transporte.tarifa_adicional;
                    row["RutChofer"] = transporte.rut_chofer;

                    // Agregar la fila al DataTable
                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }
    }
}
