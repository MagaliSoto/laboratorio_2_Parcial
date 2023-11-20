using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// un Operario, siendo este un Tipo de Usuario
    /// </summary>
    public class Operario : Usuario
    {
        public Operario() { }
        /// <summary>
        /// Inicializa el una nueva instancia de Operario
        /// </summary>
        /// <param name="nombre">Nombre que se le asigna al objeto</param>
        public Operario(string nombre, int legajo) : base(nombre, "Operario",legajo) { }
    }
}
