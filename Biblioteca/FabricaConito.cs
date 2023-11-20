using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// una fabrica de conitos. Provee un metodo
    /// fabricar uno
    /// </summary>
    public class FabricaConito : FabricaProducto
    {
        private Producto conito;
        private string mensajeError;

        /// <summary>
        /// Inicializa una nueva instancia de FabricaConito
        /// le da un valor a Receta con la mercaderia necesaria
        /// y a PasosProduccion
        /// </summary>
        public FabricaConito()
        {
            Receta = new()
            {
                new("Dulce de leche", 15),
                new("Galletita de vainilla",1),
                new("Chocolate",15),
                new("Envoltorio",1)
            };

            PasosProduccion = [
                "Ubicando galletas de vainilla...",
                    "Haciendo picos de dulce de leche sobre las galletas...",
                    "Bañando conitos en chocolate...",
                    "Envolviendo conitos...",
                    "Proceso terminado."
            ];
        }

        /// <summary>
        /// Crea una Cantidad especifica de productos,
        /// modificando las cantidades de las mercaderias 
        /// utilizadas en la base de datos
        /// </summary>
        /// <param name="inventario">inventario compartido con el stock de
        /// las mercaderias y de los productos</param>
        /// <param name="cantidadDeProductosAGenerar">cantidad de productos
        /// que se van a crear</param>
        /// <param name="id">posicion en la base de datos</param>
        /// <returns>un string vacio si se completo correctamente, o uno
        /// con las mercaderias faltantes</returns>
        public override string Fabricar(Inventario inventario, int cantidadAProducir, int id)
        {
            if (inventario.ModificarStock(cantidadAProducir, Receta, out mensajeError))
            {
                List<Producto> listaProductos = InventarioDAO.LeerProductos();

                bool contieneConito = listaProductos.Any(p => p.Nombre == "Conito");

                if (listaProductos.Count != 0 && contieneConito)
                {
                    foreach (var producto in listaProductos)
                    {
                        if (producto.Nombre == "Conito")
                        {
                            producto.Cantidad += cantidadAProducir;
                            InventarioDAO.ModificarProducto("Conito", producto.Cantidad);
                        }
                    }
                }
                else
                {
                    InventarioDAO.GuardarProducto("Conito", cantidadAProducir);
                }
                return mensajeError = "";
            }
            return mensajeError;
        }        
    }
}
