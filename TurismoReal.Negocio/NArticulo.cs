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
    public class NArticulo
    {
        public static List<Articulo> ListarArticulos()
        {
            try
            {
                DDArticulo datosArticulo = new DDArticulo();
                DataTable dataTable = datosArticulo.ListarArticulo();

                List<Articulo> listaArticulos = new List<Articulo>();

                foreach (DataRow row in dataTable.Rows)
                {
                    Articulo articulo = new Articulo
                    {
                        id_articulo = Convert.ToInt32(row["Id Articulo"]),
                        descripcion = row["Descripcion"].ToString(),
                        stock = Convert.ToInt32(row["Stock"]),
                        precio_articulo = Convert.ToInt32(row["Precio"])
                    };

                    listaArticulos.Add(articulo);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa de negocios al listar artículos: " + ex.Message);
                return null;
            }
        }




        public static bool Insertar(string descripcion,int stock,int precio)
        {
            // Llamar al método de la capa de datos para agregar el administrador
            DDArticulo Datos = new DDArticulo();
            bool exito = Datos.AgregarArticulo(descripcion,stock,precio);

            // Devolver un mensaje de éxito o error
            return exito;
        }

        public static bool ModificarArticulo(int id_art, string descripcion, int stock, int precio)
        {
            DDArticulo Datos = new DDArticulo();

            // Llama al método de la capa de datos para actualizar el artículo
            bool exito = Datos.modificarArticulo(id_art, descripcion, stock, precio);

            // Devuelve un mensaje de éxito o error
            return exito;
        }

        public static bool EliminarArticulo(int rut)
        {
            // Llamar al método de la capa de datos para eliminar el administrador
            DDArticulo Datos = new DDArticulo();
            bool exito = Datos.EliminarArticulo(rut);

            // Devolver un mensaje de éxito o error
            return exito;
        }

    }
}
