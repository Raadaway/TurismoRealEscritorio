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
                dataTable.Columns.Add("Id Transporte", typeof(int));
                dataTable.Columns.Add("Nombre Empresa", typeof(string));
                dataTable.Columns.Add("Horario", typeof(string));
                dataTable.Columns.Add("Patente", typeof(string));
                dataTable.Columns.Add("Tarifa Adicional", typeof(int));
                dataTable.Columns.Add("Rut Chofer", typeof(int));

                foreach (var transporte in listaTransportes)
                {
                    // Crear una nueva fila en el DataTable
                    DataRow row = dataTable.NewRow();

                    // Asignar los valores del transporte a las columnas correspondientes
                    row["Id Transporte"] = transporte.id_transporte;
                    row["Nombre Empresa"] = transporte.nom_empresa;
                    row["Horario"] = transporte.horario;
                    row["Patente"] = transporte.patente;
                    row["Tarifa Adicional"] = transporte.tarifa_adicional;
                    row["Rut Chofer"] = transporte.rut_chofer;

                    // Agregar la fila al DataTable
                    dataTable.Rows.Add(row);
                }
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
            return dataTable;
        }
    }
}
