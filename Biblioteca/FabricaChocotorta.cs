using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// una fabrica de chocotorta. Provee un metodo
    /// fabricar una
    /// </summary>
    public class FabricaChocotorta: FabricaProducto
    {
        private Producto chocotorta;
        private string mensajeError;

        /// <summary>
        /// Inicializa una nueva instancia de FabricaChocotorta
        /// le da un valor a Receta con la mercaderia necesaria
        /// y a PasosProduccion
        /// </summary>
        public FabricaChocotorta()
        {
            Receta = new List<Mercaderia>
            {
                new("Dulce de leche", 20),
                new("Queso crema",20),
                new("Galletita de chocolate",10),
                new("Cafe",15),
                new("Recipiente",1)
            };

            PasosProduccion = [
                "Remojando galletas de chocolate en cafe...",
                "Mezclando dulce de leche con queso crema...",
                "Ubicando galletas en el recipiente...",
                "Agregando la mezcla de dulce de leche con queso crema...",
                "Ubicando galletas en el recipiente...",
                "Agregando la mezcla de dulce de leche con queso crema...",
                "Decorando con galletas trituradas...",
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
        /// <param name="cantidadAProducir">cantidad de productos
        /// que se van a crear</param>
        /// <param name="id">posicion en la base de datos</param>
        /// <returns>un string vacio si se completo correctamente, o uno
        /// con las mercaderias faltantes</returns>
        public override string Fabricar(Inventario inventario, int cantidadAProducir, int id)
        {
            if (inventario.ModificarStock(cantidadAProducir,Receta,out mensajeError))
            {
                List<Producto> listaProductos = InventarioDAO.LeerProductos();

                bool contieneChocotorta = listaProductos.Any(p => p.Nombre == "Chocotorta");

                if (listaProductos.Count != 0 && contieneChocotorta)
                {
                    foreach (var producto in listaProductos)
                    {
                        if (producto.Nombre == "Chocotorta")
                        {
                            producto.Cantidad += cantidadAProducir;
                            InventarioDAO.ModificarProducto("Chocotorta", producto.Cantidad);
                        }
                    }
                }
                else
                {
                    InventarioDAO.GuardarProducto("Chocotorta", cantidadAProducir);
                }
                return mensajeError = "";
            }            
            return mensajeError;
        }
    }
}