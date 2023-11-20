using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// una fabrica. Provee un metodo que sus herencias deben
    /// usar para poder crear un producto
    /// </summary>
    public abstract class FabricaProducto
    {
        public List<Mercaderia>? Receta { get; set; }
        public List<string>? PasosProduccion { get; set; }
        /// <summary>
        /// Metodo usado como base para que sus herencias
        /// lo tengan obligatoriamente, se debe encargar de
        /// crear productos
        /// </summary>
        /// <param name="inventario">inventario compartido con el stock de
        /// las mercaderias y de los productos</param>
        /// <param name="cantidadAProducir">cantidad de productos
        /// que se van a crear</param>
        /// <param name="id">posicion en la base de datos</param>
        /// <returns>un string vacio si se completo correctamente, o uno
        /// con las mercaderias faltantes</returns>
        public abstract string Fabricar(Inventario inventario, int cantidadAProducir, int id);
    }
}
