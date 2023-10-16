using Biblioteca;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Windows;

namespace Biblioteca
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// mercaderia. Provee de metodos para ver y modificar
    /// sus atributos.
    /// </summary>
    public class Mercaderia
    {
        private int cantidad;
        private string nombre;
        private int cantidadAGastar;

        /// <summary>
        /// Inicializa una nueva instancia de Mercaderia.
        /// </summary>
        /// <param name="nombre">nombre que se le asigna al objeto</param>
        /// <param name="cantidadAGastar">cantidad de mercaderia que se 
        /// va a utilizar por unidad</param>
        public Mercaderia(string nombre, int cantidadAGastar)
        {
            this.nombre = nombre.ToLower();
            this.cantidadAGastar = cantidadAGastar;
            this.cantidad = 100;
        }

        /// <summary>
        /// Gets o Sets de la cantidad del objeto
        /// </summary>
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad += value;
            }
        }

        /// <summary>
        /// Obtiene el nombre de la mercaderia
        /// </summary>
        /// <returns>el nombre de la mercaderia</returns>
        public string GetNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Obtiene la cantidad que se utilizara del 
        /// objeto por unidad
        /// </summary>
        /// <returns>la cantidad a usar por unidad</returns>
        public int GetCantidadAGastar() 
        {  
            return cantidadAGastar; 
        }

        /// <summary>
        /// Establece el atributo cantidad en 0
        /// </summary>
        private void PonerCantidadCero()
        {
            this.cantidad = 0;
        }

        /// <summary>
        /// Actualiza el atributo cantidad al crearse un producto
        /// </summary>
        /// <param name="cantidadDeProductosAGenerar">cantidad de productos
        /// que se van a crear</param>
        public void ActualizarCantidadDeMercaderia(int cantidadDeProductosAGenerar)
        {
            this.Cantidad = -cantidadAGastar * cantidadDeProductosAGenerar;

            if (cantidad <= 0)
            {
                PonerCantidadCero();
            }
        }

        /// <summary>
        /// Comprueba que un objeto Mercaderia es igual a un string dado.
        /// </summary>
        /// <param name="m1">mercaderia a comparar</param>
        /// <param name="m2">string a comparar</param>
        /// <returns>True si los nombres coinciden,
        /// False si no coinciden</returns>
        public static bool operator ==(Mercaderia m1, string m2)
        {

            return m1.nombre == m2;
        }

        /// <summary>
        /// Comprueba que un objeto Mercaderia es diferente a un string dado.
        /// </summary>
        /// <param name="m1">mercaderia a comparar</param>
        /// <param name="m2">string a comparar</param>
        /// <returns>True si los nombres no coinciden,
        /// False si coinciden</returns>
        public static bool operator !=(Mercaderia m1, string m2)
        {

            return !(m1 == m2);
        }
    }

    /// <summary>
    /// Representa un objeto que imita el comportamiento
    /// de un producto, el cual es creado a partir de
    /// objetos Mercaderia.
    /// </summary>
    public class Producto
    {
        private string nombre;
        private List<string> mensajes;
        private List<Mercaderia> listaMercaderias = new();

        /// <summary>
        /// Inicializa una instancia de Producto
        /// </summary>
        /// <param name="nombre">nombre que se le asigna al objeto</param>
        /// <param name="mercaderias">lista del objeto Mercaderia usadas
        /// para crear el producto</param>
        public Producto(string nombre, params Mercaderia[] mercaderias)
        {
            this.nombre = nombre.ToLower();
            listaMercaderias.AddRange(mercaderias);
        }

        public List<string> Mensajes
        {
            get
            {
                return mensajes;
            }
        }

        /// <summary>
        /// Crea una cantidad especifica de productos,
        /// modificando las cantidades de las mercaderias utilizadas.
        /// </summary>
        /// <param name="cantidadDeProductosAGenerar">cantidad de productos
        /// que se van a crear</param>
        /// <param name="mensajeError">un mensaje de error en caso
        /// de no poder crear el producto</param>
        /// <returns>True si se creo el producto, de lo contrario False</returns>
        public bool CrearProducto(int cantidadDeProductosAGenerar, out string mensajeError)
        {
            mensajeError = "";

            if (!VerificarDisponibilidadDeMercaderia(cantidadDeProductosAGenerar, out mensajeError))
            {
                return false;
            }
            else
            {
                foreach (var mercaderia in listaMercaderias)
                {
                    mercaderia.ActualizarCantidadDeMercaderia(cantidadDeProductosAGenerar);
                }
            }
            if (nombre == "conito")
            {
                mensajes = ["Ubicando galletas de vainilla...",
                    "Haciendo picos de dulce de leche sobre las galletas...",
                    "Bañando conitos en chocolate...",
                    "Envolviendo conitos...",
                    "Proceso terminado."];
            }
            else if (nombre == "chocotorta")
            {
                mensajes = ["Remojando galletas de chocolate en cafe...",
                    "Mezclando dulce de leche con queso crema...",
                    "Ubicando galletas en el recipiente...",
                    "Agregando la mezcla de dulce de leche con queso crema...",
                    "Ubicando galletas en el recipiente...",
                    "Agregando la mezcla de dulce de leche con queso crema...",
                    "Decorando con galletas trituradas...",
                    "Proceso terminado."];
            }
            return true;
        }

        /// <summary>
        /// Verifica si la cantidad de mercaderia necesaria para crear
        /// el producto es la suficiente
        /// </summary>
        /// <param name="cantidadDeProductosAGenerar">cantidad de productos
        /// que se van a crear</param>
        /// <param name="mensajeError">un mensaje de error que especifica la
        /// mercaderia faltante para crear el producto</param>
        /// <returns>True si hay suficiente mercaderia, de lo contrario False</returns>
        private bool VerificarDisponibilidadDeMercaderia(int cantidadDeProductosAGenerar, out string mensajeError)
        {
            mensajeError = "No es posible hacer el producto, por falta de:\n";

            foreach (Mercaderia mercaderia in listaMercaderias)
            {
                int cantidadAGastar = mercaderia.GetCantidadAGastar();
                if (mercaderia.Cantidad < (cantidadAGastar * cantidadDeProductosAGenerar))
                {
                    mensajeError += mercaderia.GetNombre() + "\n";
                }
            }
            return mensajeError == "No es posible hacer el producto, por falta de:\n";
        }
    }
}
