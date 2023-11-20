using Clases;

namespace Pruebas
{
    [TestClass]
    public class ArchivoTests
    {
        [TestMethod]
        public void LogError_RetornaLoEsperado()
        {
            Exception e = new Exception("Excepcion de prueba");
            string nombreMetodo = "Metodo de prueba";
            string ruta = "C:\\Test\\TestFile.cs";

            string excepcionMensaje = Archivos<string>.LogError(e, nombreMetodo, ruta);

            Assert.IsTrue(excepcionMensaje.Contains(e.Message));
            Assert.IsTrue(excepcionMensaje.Contains(nombreMetodo));
            Assert.IsTrue(excepcionMensaje.Contains("Metodo de prueba"));
            Assert.IsTrue(excepcionMensaje.Contains("C:\\Test\\TestFile.cs"));
        }
    }
}