using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaTesting.LogicaObjetos;

namespace PracticaTesting.UnitTests
{
    [TestClass]
    public class ReservacionTests
    {
        [TestMethod]
        public void CanceladaPor_UsuarioEsAdmin_ResultadoVerdadero()
        {
            var reservacion = new Reservacion();
            var resultado = reservacion.CanceladaPor(new Usuario { EsAdmin = true });
            Assert.IsTrue(resultado);
        }
    }
}