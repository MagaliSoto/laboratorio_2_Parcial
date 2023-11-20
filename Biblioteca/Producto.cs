namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento
    /// de un producto, el cual es creado a partir de
    /// objetos Mercaderia.
    /// </summary>
    public class Producto
    {
        public string Nombre { get;set;}
        public int Cantidad { get;set;}
        public List<Mercaderia>? ListaMercaderias { get; set;}

        public Producto(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        /// <summary>
        /// Inicializa una instancia de Producto
        /// </summary>
        /// <param name="nombre">Nombre que se le asigna al objeto</param>
        /// <param name="listaMercaderias">lista del objeto Mercaderia usadas
        /// para crear el producto</param>
        public Producto(string nombre, List<Mercaderia> listaMercaderias)
        {
                Nombre = nombre.ToLower();
                ListaMercaderias = listaMercaderias;
        }

        /// <summary>
        /// Obtiene el codigo hash del objeto a partir de su nombre
        /// </summary>
        /// <returns>el codigo hash del nombre del objeto.</returns>
        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }

        /// <summary>
        /// Comprueba si el objeto Producto es igual a otro Producto
        /// </summary>
        /// <param name="obj">producto a comparar.</param>
        /// <returns>True si los nombres coinciden,
        /// False si no coinciden</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Producto otroProducto = (Producto)obj;
            return Nombre == otroProducto.Nombre;
        }
    }
}
