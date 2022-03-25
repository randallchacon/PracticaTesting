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

        [TestMethod]
        public void CanceladaPor_UsuarioEsElMismo_ResultadoVerdadero()
        {
            var usuario = new Usuario();

            var reservacion = new Reservacion { HechaPor = usuario };

            var resultado = reservacion.CanceladaPor(usuario);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void CanceladaPor_UsuarioEsDiferente_ResultadoFalso()
        {
            var reservacion = new Reservacion { HechaPor = new Usuario() };

            var resultado = reservacion.CanceladaPor(new Usuario());

            Assert.IsFalse(resultado);
        }
    }
}