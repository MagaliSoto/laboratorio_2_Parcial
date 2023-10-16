using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento
    /// de un usuario generico con nombre y rol.
    /// </summary>
    public abstract class Usuario
    {
        public string nombre;
        public string rol;

        /// <summary>
        /// Inicializa una nueva instancia de Usuario
        /// </summary>
        /// <param name="nombre">nombre que se le asigna al objeto</param>
        /// <param name="rol">rol que se le asigna al objeto</param>
        public Usuario(string nombre, string rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        }

        /// <summary>
        /// Compara si un objeto Usuario es igual a un string dado.
        /// </summary>
        /// <param name="u1">Usuario a comprar</param>
        /// <param name="u2">string a comparar</param>
        /// <returns>True si los nombres coinciden,
        /// False si no coinciden</returns>
        public static bool operator ==(Usuario u1, string u2)
        {

            return u1.nombre == u2;
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

        /// <summary>
        /// Valida el ususario mediante usuario y contraseña
        /// </summary>
        /// <param name="usuario">usuario usado para validar</param>
        /// <param name="contraseña">contraseña usada para validar</param>
        /// <returns>True si el usuario Y la contraseña coinciden,
        /// en caso contrario False.</returns>
        public virtual bool EsUsuarioValido(string usuario, string contraseña)
        {
            if ((usuario == "usuario1" || usuario == "usuario2")
                && contraseña == "12345")
            {
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// un Operario, siendo este un tipo de Usuario
    /// </summary>
    public class Operario : Usuario
    {
        /// <summary>
        /// Inicializa el una nueva instancia de Operario
        /// </summary>
        /// <param name="nombre">nombre que se le asigna al objeto</param>
        public Operario(string nombre) : base(nombre, "Operario")
        {
            
        }
        
        public override bool EsUsuarioValido(string usuario, string contraseña)
        {
            if ((usuario == "operario1" || usuario == "operario2") && contraseña == "12345")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica si un usuario es valido y lo agrega a una lista
        /// </summary>
        /// <param name="usuario">usuario usado para validar</param>
        /// <param name="contraseña">contraseña usada para validar</param>
        /// <param name="lista">lista de objetos Usuario donde se van a
        /// agregar los ususario validados</param>
        /// <param name="usuarioActual">objeto Operario creado al validar</param>
        /// <returns>True si el usuario Y la contraseña coinciden,
        /// en caso contrario False.</returns>
        public static bool EsUsuarioValido(string usuario, string contraseña,
            List<Usuario> lista, out Usuario? usuarioActual)
        {
            if ((usuario == "operario1" || usuario == "operario2") && contraseña == "12345")
            {
                usuarioActual = new Operario(usuario);

                if (!lista.Any(operario => operario == usuario))
                {
                    lista.Add(usuarioActual);
                }
                return true;
            }
            usuarioActual = null;
            return false;
        }
    }

    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// un Supervisor, siendo este un tipo de Operario
    /// con mas metodos
    /// </summary>
    public class Supervisor : Operario
    {
        /// <summary>
        /// Inicializa el una nueva instancia de Supervisor
        /// </summary>
        /// <param name="nombre">nombre que se le asigna al objeto</param>
        public Supervisor(string nombre) : base(nombre)
        {
            rol = "Supervisor";
        }

        /// <summary>
        /// Verifica si un usuario es valido y crea una nueva 
        /// instancia del objeto Supervisor
        /// </summary>
        /// <param name="usuario">usuario usado para validar</param>
        /// <param name="contraseña">contraseña usada para validar</param>
        /// <param name="usuarioActual">objeto Supervisor creado al validar</param>
        /// <returns>True si el usuario Y la contraseña coinciden,
        /// en caso contrario False.</returns>
        public static bool EsSupervisorValido(string usuario, string contraseña,
            out Usuario? usuarioActual)
        {
            if (usuario == "supervisor1" && contraseña == "12345")
            {
                usuarioActual = new Supervisor(usuario);
                return true;
            }
            usuarioActual = null;
            return false;
        }

        /// <summary>
        /// Obtiene informacion de los operarios registrados
        /// </summary>
        /// <param name="operarios">lista de operarios registrados</param>
        /// <returns>un mensaje con los operarios registrados si se
        /// encontraron, o uno diciendo que no hay</returns>
        public static string VerInformacionOperarios(List<Usuario> operarios)
        {
            string mensaje = "";
            foreach (var operario in operarios)
            {
                mensaje += $"NOMBRE: {operario.nombre}\tROL: {operario.rol}\n";
            }
            if (operarios.Count == 0)
            {
                mensaje = "No hay operarios registrados";
            }
            return mensaje;
        }
    }
}
