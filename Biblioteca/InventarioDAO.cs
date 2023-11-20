using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Provee distintos metodos para manejar
    /// la base de datos que contiene mercaderias
    /// y productos en stock
    /// </summary>
    public static class InventarioDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string MERCADERIA_TABLA = "MERCADERIA";
        const string CANTIDAD_MERCADERIA_TABLA = "CANTIDAD_MERCADERIA";
        const string PRODUCTO_TABLA = "PRODUCTO";
        const string CANTIDAD_PRODUCTO_TABLA = "CANTIDAD_PRODUCTO";
        static string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
        static int Id = 0;

        static InventarioDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=PARCIAL_LABO2;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Guarda en la base de datos una determinada
        /// cantidad de mercaderia junto con el nombre
        /// </summary>
        /// <param name="cantidadMercaderia">cantidad mercaderia en stock</param>
        /// <param name="mercaderia">nombre de la mercaderia</param>
        public static void GuardarMercaderia(int cantidadMercaderia, string mercaderia)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO INVENTARIO " +
                    $"(CANTIDAD_MERCADERIA,MERCADERIA) VALUES " +
                    $"(@CantidadMercaderia,@Mercaderia)";
                command.Parameters.AddWithValue("@CantidadMercaderia", cantidadMercaderia);
                command.Parameters.AddWithValue("@Mercaderia", mercaderia);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally { connection.Close(); }
        }

        /// <summary>
        /// Guarda en la base de datos una determinada
        /// cantidad de producto junto con el nombre
        /// </summary>
        /// <param name="cantidadProducto">cantidad producto en stock</param>
        /// <param name="producto">nombre de la producto</param>
        public static void GuardarProducto(string producto, int cantidadProducto)
        {
            try
            {
                Id += 1;
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE INVENTARIO SET CANTIDAD_PRODUCTO = @cantidadProducto," +
                    $"PRODUCTO = @Producto WHERE ID = @Id";

                command.Parameters.AddWithValue("@CantidadProducto", cantidadProducto);
                command.Parameters.AddWithValue("@Producto", producto);
                command.Parameters.AddWithValue("@Id", Id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Modifica la cantidad de mercaderia en 
        /// stock basandose en el nombre
        /// </summary>
        /// <param name="mercaderia">nombre mercaderia a modificar</param>
        /// <param name="cantidadMercaderia">nueva cantidad de mercaderia</param>
        public static void ModificarMercaderia(string mercaderia, int cantidadMercaderia)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE INVENTARIO SET CANTIDAD_MERCADERIA = @CantidadMercaderia " +
                    $"WHERE MERCADERIA = @Mercaderia";
                command.Parameters.AddWithValue("@Mercaderia", mercaderia);
                command.Parameters.AddWithValue("@CantidadMercaderia", cantidadMercaderia);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Modifica la cantidad de producto en 
        /// stock basandose en el nombre
        /// </summary>
        /// <param name="producto">nombre producto a modificar</param>
        /// <param name="cantidadProducto">nueva cantidad de producto</param>
        public static void ModificarProducto(string producto, int cantidadProducto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE INVENTARIO SET CANTIDAD_PRODUCTO = @CantidadProducto " +
                    $"WHERE PRODUCTO = @Producto";
                command.Parameters.AddWithValue("@Producto", producto);
                command.Parameters.AddWithValue("@CantidadProducto", cantidadProducto);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Recorre la base de datos para obtener 
        /// una lista con la mercaderia en stock
        /// </summary>
        /// <returns>mercaderia en stock</returns>
        public static List<Mercaderia> LeerMercaderias()
        {
            List<Mercaderia> mercaderias = new List<Mercaderia>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM INVENTARIO";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int cantidadMercaderia = Convert.ToInt32(reader[CANTIDAD_MERCADERIA_TABLA]);
                        Mercaderia mercaderia = new(reader[MERCADERIA_TABLA].ToString(), TipoMercaderia.granos);
                        mercaderia.Cantidad = cantidadMercaderia;
                        mercaderias.Add(mercaderia);
                    }
                }
                return mercaderias;
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Recorre la base de datos para obtener 
        /// una lista con la producto en stock
        /// </summary>
        /// <returns>productos en stock en caso 
        /// de encontrar alguno, sino null</returns>
        public static List<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM INVENTARIO";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int cantidadProducto = Convert.ToInt32(reader[CANTIDAD_PRODUCTO_TABLA]);
                        Producto producto = new(reader[PRODUCTO_TABLA].ToString(), cantidadProducto);
                        productos.Add(producto);
                    }
                }
                return productos;
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                return productos;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Busca las propiedades de una mercaderia especifica
        /// </summary>
        /// <param name="mercaderia">mercaderia a buscar</param>
        /// <returns>mercaderia con sus respectivas propiedades
        /// si se encontro o null en caso de no hallarse</returns>
        public static Mercaderia LeerMercaderia(string mercaderia)
        {
            Mercaderia mercaderiaR = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM INVENTARIO WHERE MERCADERIA = @Mercaderia";
                command.Parameters.AddWithValue("@Mercaderia", mercaderia);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? nombreMercaderia = reader[MERCADERIA_TABLA].ToString();
                        int cantidadMercaderia = Convert.ToInt32(reader[CANTIDAD_MERCADERIA_TABLA]);

                        mercaderiaR = new(nombreMercaderia, TipoMercaderia.granos);
                        mercaderiaR.Cantidad = cantidadMercaderia;
                    }
                }

                return mercaderiaR;
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Vacia los datos de la base de datos
        /// </summary>
        public static void Eliminar()
        {
            try
            {
                connection.Open();
                command.CommandText = "TRUNCATE TABLE INVENTARIO";
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
