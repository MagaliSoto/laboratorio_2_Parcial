using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// un conjunto de fabricas. Posee un atributo listadoFabricas
    /// donde se guardan las distintas fabricas
    /// </summary>
    public class FabricasProducto
    {
        public Dictionary<string, FabricaProducto> listadoFabricas;
        /// <summary>
        /// Inicializa una nueva instancia de FabricasProducto,
        /// crea un diccionario con las fabricas actuales
        /// </summary>
        public FabricasProducto()
        {
            FabricaChocotorta fabricaChocotorta = new();
            FabricaConito fabricaConitos = new();

            listadoFabricas = new Dictionary<string, FabricaProducto>
            {
                {"Chocotorta", fabricaChocotorta},
                {"Conito", fabricaConitos}
            };
        }
    }
}
