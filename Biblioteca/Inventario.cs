using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clases
{
    /// <summary>
    /// Representa un inventario que se encarga de
    /// modificar la mercaderia de la base de datos
    /// </summary>
    public class Inventario
    {
        public List<Mercaderia> StockMercaderia { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de Inventario
        /// y de los objetos Mercaderia con sus respectivos 
        /// nombres y cantidades, agregandolos a la
        /// base de datos
        /// </summary>
        public Inventario()
        {
            StockMercaderia = new List<Mercaderia> {
                new("Dulce de leche", TipoMercaderia.lacteo),
                new("Queso crema",TipoMercaderia.lacteo),
                new("Galletita de vainilla", TipoMercaderia.harina),
                new("Galletita de chocolate", TipoMercaderia.harina),
                new("Chocolate", TipoMercaderia.granos),
                new("Cafe", TipoMercaderia.granos),
                new("Envoltorio", TipoMercaderia.papel),
                new("Recipiente", TipoMercaderia.papel)
            };
            InventarioDAO.Eliminar();
            foreach (var mercaderia in StockMercaderia)
            {
                InventarioDAO.GuardarMercaderia(mercaderia.Cantidad, mercaderia.Nombre);
            }
        }

        /// <summary>
        /// llama al metodo LeerMercaderias de
        /// InventarioDAO
        /// </summary>
        /// <returns>mercaderia en stock</returns>
        public List<Mercaderia> Leer()
        {
            return InventarioDAO.LeerMercaderias();
        }

        /// <summary>
        /// Verifica si la Cantidad de mercaderia necesaria para crear
        /// el producto es la suficiente, y de serlo lo modifica
        /// </summary>
        /// <param name="cantidadDeProductosAGenerar">Cantidad de productos
        /// que se van a crear</param>
        /// <param name="listaMercaderias">las mercaderias que utiliza
        /// el producto a generar</param>
        /// <param name="mensajeError">un mensaje de error que especifica la
        /// mercaderia faltante para crear el producto</param>
        /// <returns>True si hay suficiente mercaderia, de lo contrario False</returns>
        public bool ModificarStock(
            int cantidadDeProductosAGenerar,
            List<Mercaderia> listaMercaderias,
            out string mensajeError
)
        {
            mensajeError = "No es posible hacer el producto, por falta de:\n";

            foreach (Mercaderia mercaderia in listaMercaderias)
            {
                try
                {
                    Mercaderia mercaderiaStock = InventarioDAO.LeerMercaderia(mercaderia.Nombre);

                    int cantidadAGastar = mercaderia.CantidadAGastar;

                    if (mercaderiaStock.Cantidad < (cantidadAGastar * cantidadDeProductosAGenerar))
                    {
                        mensajeError += mercaderiaStock.Nombre + "\n";
                    }
                    else
                    {
                        int cantidad = mercaderiaStock.Cantidad - (cantidadAGastar * cantidadDeProductosAGenerar);
                        InventarioDAO.ModificarMercaderia(mercaderia.Nombre, cantidad);
                    }
                }
                catch (Exception)
                {
                    mensajeError += mercaderia.Nombre + "\n";
                }
            }
            return mensajeError == "No es posible hacer el producto, por falta de:\n";
        }
    }
}
       
