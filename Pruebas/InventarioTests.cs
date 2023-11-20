using Clases;

namespace Pruebas
{
    [TestClass]
    public class InventarioTests
    {
        [TestMethod]
        public void ModificarStock_RetornaTrue_SuficienteStock()
        {
            var inventario = new Inventario();
            var listaMercaderias = new List<Mercaderia> { new Mercaderia ("Mercaderia1",20) };
            string mensajeError;

            bool resultado = inventario.ModificarStock(2, listaMercaderias, out mensajeError);

            Assert.IsTrue(resultado);
            Assert.AreEqual("No es posible hacer el producto, por falta de:\n", mensajeError);
        }

        [TestMethod]
        public void ModificarStock_RetornaFalse_InsuficienteStock()
        {
            var inventario = new Inventario();
            var listaMercaderias = new List<Mercaderia> { new Mercaderia("Mercaderia1", 20) };
            string mensajeError;

            bool resultado = inventario.ModificarStock(6, listaMercaderias, out mensajeError);

            Assert.IsFalse(resultado);
            Assert.AreEqual("No es posible hacer el producto, por falta de:\nMercaderia1\n", mensajeError);
        }
    }
}