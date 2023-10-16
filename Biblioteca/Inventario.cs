using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un inventario que contiene una variedad 
    /// de objetos Mercaderia.
    /// </summary>
    public class Inventario
    {
        public Mercaderia DulceDeLeche;
        public Mercaderia QuesoCrema;
        public Mercaderia GalletitasDeVanilla;
        public Mercaderia GalletitiasDeChocolate;
        public Mercaderia Chocolate;
        public Mercaderia Cafe;
        public Mercaderia Envoltorio;
        public Mercaderia Recipiente;
        public List<Mercaderia> listaMercaderias = new();

        /// <summary>
        /// Inicializa una nueva instancia de Inventario
        /// y de los objetos Mercaderia con sus respectivos 
        /// nombres y cantidades, agregandolos a una lista.
        /// </summary>
        public Inventario() 
        {
            DulceDeLeche = new("Dulce de leche", 20);
            QuesoCrema = new("Queso crema",20);
            GalletitasDeVanilla = new("Galletita de vainilla",1);
            GalletitiasDeChocolate = new("Galletita de chocolate",10);
            Chocolate = new("Chocolate",15);
            Cafe = new("Cafe",15);
            Envoltorio = new("Envoltorio",1);
            Recipiente = new("Recipiente",1);

            listaMercaderias.Add(DulceDeLeche);
            listaMercaderias.Add(QuesoCrema);
            listaMercaderias.Add(GalletitasDeVanilla);
            listaMercaderias.Add(GalletitiasDeChocolate);
            listaMercaderias.Add(Chocolate);
            listaMercaderias.Add(Cafe);
            listaMercaderias.Add(Envoltorio);
            listaMercaderias.Add(Recipiente);
        }
    }

}

