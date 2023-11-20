using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// un Supervisor, siendo este un Tipo de Operario
    /// con mas metodos
    /// </summary>
    public class Supervisor : Usuario
    {
        public Supervisor() { }
        /// <summary>
        /// Inicializa el una nueva instancia de Supervisor
        /// </summary>
        /// <param name="nombre">Nombre que se le asigna al objeto</param>
        public Supervisor(string nombre, int legajo) : base(nombre, "Supervisor", legajo) { }

        /// <summary>
        /// Obtiene informacion de los operarios registrados
        /// de la base de datos
        /// </summary>
        /// <returns>un mensaje con los operarios registrados si se
        /// encontraron, o uno diciendo que no hay</returns>
        public static async Task<string> VerInformacionOperarios()
        {
            try
            {
                Task<List<Operario>> listaTask = UsuarioDAO.LeerOperarios();
                List<Operario> lista = await listaTask;

                string mensaje = "";
                foreach (var operario in lista)
                {
                    mensaje += $"NOMBRE: {operario.Nombre}\tLEGAJO: {operario.Legajo}\n";
                }
                if (lista.Count == 0)
                {
                    mensaje = "No hay operarios registrados";
                }
                return mensaje;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
