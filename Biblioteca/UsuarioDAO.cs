using Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Provee distintos metodos para manejar
    /// la base de datos que contiene los
    /// usuarios registrados
    /// </summary>
    public static class UsuarioDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string NOMBRE_TABLA = "NOMBRE_USUARIO";
        const string LEGAJO_TABLA = "LEGAJO";
        const string ROL_TABLA = "ROL";
        const string ANTIGUEDAD_TABLA = "ANTIGUEDAD";
        static string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";

        static UsuarioDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=PARCIAL_LABO2;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Verifica si el usuario ya esta registrado,
        /// en caso de no estarlo lo agrega a la base de datos
        /// </summary>
        /// <param name="nombre">nombre del usuario</param>
        /// <param name="contraseña">contraseña del usuario</param>
        /// <param name="rol">rol del usuario</param>
        /// <param name="legajo">legajo generado automaticamente</param>
        public static async Task Guardar(
            string nombre, 
            string rol, 
            string contraseña, 
            int legajo
        )
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();

                command.CommandText = "SELECT COUNT(*) FROM USUARIOS WHERE NOMBRE_USUARIO = @Nombre";
                command.Parameters.AddWithValue("@Nombre", nombre);
                int usuariosExistentes = (int)command.ExecuteScalar();

                if (usuariosExistentes > 0)
                {
                    throw new Exception("Ya existe un usuario con ese nombre de usuario");
                }

                command.CommandText = "INSERT INTO USUARIOS (NOMBRE_USUARIO, ROL, CONTRASEÑA, LEGAJO, ANTIGUEDAD) VALUES " +
                    "(@Nombre, @Rol, @Contraseña, @Legajo, @Antiguedad)";
                command.Parameters.AddWithValue("@Rol", rol);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                command.Parameters.AddWithValue("@Legajo", legajo);
                command.Parameters.AddWithValue("@Antiguedad", DateTime.Now.Date);

                int rows = await command.ExecuteNonQueryAsync();
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
        /// Verifica el usuario y contraseña
        /// </summary>
        /// <param name="usuario">nombre del usuario</param>
        /// <param name="contraseña">contraseña del usuario</param>
        /// <returns>si veifica el usuario correspondiente
        /// al rol asignado, o null en caso contrario</returns>
        public static Usuario Autenticar(string usuario, string contraseña)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM USUARIOS WHERE NOMBRE_USUARIO = @Usuario AND CONTRASEÑA = @Contraseña";
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string? nombre = reader[NOMBRE_TABLA].ToString();
                        int legajoUsuario = Convert.ToInt32(reader[LEGAJO_TABLA]);
                        string? rol = reader[ROL_TABLA].ToString();

                        Usuario nuevoUsuario = null;

                        if (rol == "supervisor")
                        {
                            nuevoUsuario = new Supervisor(nombre, legajoUsuario);
                        }
                        else if (rol == "operario")
                        {
                            nuevoUsuario = new Operario(nombre, legajoUsuario);
                        }

                        return nuevoUsuario;
                    }
                    else
                    {
                        return null;
                    }
                }
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
        /// Recorre la base de datos filtrando por rol, 
        /// si son operarios se agregan a una lista
        /// </summary>
        /// <returns>operarios registrados</returns>
        public static async Task<List<Operario>> LeerOperarios()
        {
            List<Operario> operarios = new List<Operario>();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM USUARIOS WHERE ROL = 'operario'";

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        string? nombre = reader[NOMBRE_TABLA].ToString();
                        int legajoUsuario = Convert.ToInt32(reader[LEGAJO_TABLA]);

                        Operario nuevoOperario = new Operario(nombre, legajoUsuario);
                        operarios.Add(nuevoOperario);
                    }
                }
                return operarios;
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
        /// Busca en la base de datos la antiguedad
        /// del usuario, filtrando por nombre
        /// </summary>
        /// <param name="nombre">nombre del usuario</param>
        /// <returns>la fecha de registro</returns>
        public static DateTime LeerAntiguedad(string nombre)
        {
            DateTime? antiguedad = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM USUARIOS WHERE NOMBRE_USUARIO = @Nombre";
                command.Parameters.AddWithValue("@Nombre", nombre);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? nombreTabla = reader[NOMBRE_TABLA].ToString();
                        DateTime? antiguedadTabla = (DateTime?)reader[ANTIGUEDAD_TABLA];
                        if (nombre == nombreTabla)
                        {
                            antiguedad = antiguedadTabla;
                        }
                    }
                }

                return (DateTime)antiguedad;
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
        /// Recorre la base de datos buscando
        /// los usuarios registrados
        /// </summary>
        /// <returns>lista con todos los usuarios registrados</returns>
        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM USUARIOS";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string? nombre = reader[NOMBRE_TABLA].ToString();
                        string? rol = reader[ROL_TABLA].ToString();
                        int legajoUsuario = Convert.ToInt32(reader[LEGAJO_TABLA]);

                        if (rol == "supervisor")
                        {
                            Supervisor nuevoUsuario = new(nombre, legajoUsuario);
                            usuarios.Add(nuevoUsuario);
                        }
                        else
                        {
                            Operario nuevoUsuario = new(nombre, legajoUsuario);
                            usuarios.Add(nuevoUsuario);
                        }
                    }
                }

                return usuarios;
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
