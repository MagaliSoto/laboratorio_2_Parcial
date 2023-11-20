using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Representa un objeto que imita el comportamiento de
    /// mercaderia. Provee de metodos para ver y modificar
    /// sus atributos.
    /// </summary>
    public class Mercaderia
    {
        public TipoMercaderia Tipo {get;set;}
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public int CantidadAGastar {get;set;}

        public Mercaderia() { }
        /// <summary>
        /// Inicializa una nueva instancia de Mercaderia.
        /// </summary>
        /// <param name="nombre">Nombre que se le asigna al objeto</param>
        /// <param name="cantidadAGastar">Cantidad de mercaderia que se 
        /// va a utilizar por unidad</param>
        public Mercaderia(string nombre, int cantidadAGastar)
        {
            Nombre = nombre.ToLower();
            CantidadAGastar = cantidadAGastar;
        }

        /// <summary>
        /// Inicializa una nueva instancia de Mercaderia.
        /// </summary>
        /// <param name="nombre">Nombre que se le asigna al objeto</param>
        /// <param name="tipo">Tipo de mercaderia</param>
        public Mercaderia(string nombre, TipoMercaderia tipo)
        {
            Tipo = tipo;
            Nombre = nombre.ToLower();
            Cantidad = 100;
        }

        /// <summary>
        /// Establece el atributo Cantidad en 0
        /// </summary>
        internal void PonerCantidadCero()
        {
            this.Cantidad = 0;
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
            return m1.Nombre == m2;
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
}
