using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento
    /// de un usuario generico con Nombre y rol.
    /// </summary>
    public abstract class Usuario
    {
        public string Nombre {get; set;}
        public string Rol { get; set; }
        public int Legajo { get; set; }
        public DateTime Antiguedad { get; set; }

        public Usuario() { }
        /// <summary>
        /// Inicializa una nueva instancia de Usuario
        /// </summary>
        /// <param name="nombre">Nombre que se le asigna al objeto</param>
        /// <param name="rol">rol que se le asigna al objeto</param>
        public Usuario(string nombre, string rol, int legajo)
        {
            Nombre = nombre;
            Rol = rol;
            Legajo = legajo;
        }

        /// <summary>
        /// Guarda los datos de usuario en la base de datos
        /// y en un archivo.xml ordenados por antiguedad
        /// </summary>
        /// <param name="usuario">nombre del usuario</param>
        /// <param name="contraseña">contraseña del usuario</param>
        /// <param name="rolSeleccionado">rol del usuario</param>
        /// <param name="ruta">la ruta donde se guardara el archivo</param>
        /// <returns>un mensaje en caso de que se haya podido
        /// registrar, o en caso contrario con el error</returns>
        public static async Task<string> RegistrarUsuario(
            string usuario,
            string contraseña,
            object rolSeleccionado,
            string ruta
        )
        {
            string mensaje;
            Random random = new();

            int legajo = random.Next(100000, 1000000);

            if (usuario != "" && contraseña != "" && rolSeleccionado != null)
            {
                string? rol = rolSeleccionado.ToString();

                try
                {
                    await UsuarioDAO.Guardar(usuario, rol, contraseña, legajo);
                    mensaje = "Usuario registrado";
                }
                catch (Exception e)
                {
                    Archivos<string>.Escribir_TXT(ruta + "archivo.txt", Archivos<string>.LogError(e), true);
                    mensaje = e.Message;
                }
            }
            else
            {
                mensaje = "Debe completar todos los campos para registrarse";
            }

            List<Usuario> usuarios = UsuarioDAO.Leer();
            usuarios.Sort((u1, u2) => u1.Antiguedad.CompareTo(u2.Antiguedad));

            Archivos<List<Usuario>>.Escribir_XML(ruta + "archivo.xml", usuarios);
            return mensaje;
        }

        /// <summary>
        /// Compara si un objeto Usuario es igual a un string dado.
        /// </summary>
        /// <param name="u1">Usuario a comprar</param>
        /// <param name="u2">string a comparar</param>
        /// <returns>True si los nombres coinciden o son nulos ,
        /// False si no coinciden</returns>
        public static bool operator ==(Usuario u1, string u2)
        {
            return ReferenceEquals(u1, null) && u2 == null || u1?.Nombre == u2;
        }

        /// <summary>
        /// Comprueba que un objeto Usuario es diferente a un string dado.
        /// </summary>
        /// <param name="u1">Usuario a comparar</param>
        /// <param name="u2">string a comparar</param>
        /// <returns>False si no coinciden,
        /// True si los nombres coinciden</returns>
        public static bool operator !=(Usuario u1, string u2)
        {
            return !(u1 == u2);
        }
    }
}
