using NUnit.Framework;
using PracticaTesting.LogicaObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTesting.UnitTests
{
    [TestFixture]
    public class CalculosNumericosTests
    { 
        private CalculosNumericos _calculosNumericos;

        [SetUp]
        public void SetUp() { 
            _calculosNumericos = new CalculosNumericos(); 
        }

        [Test]
        [Ignore("Porque no es necesario")]
        public void Sumar_AlInvocar_ResultadoSumaDeArgumentos()
        {
            var resultado = _calculosNumericos.Sumar(1, 2);
            Assert.That(resultado, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_AlInvocar_RetornarArgumentoMayor(int x, int y, int resultadoEsperado)
        {
            var resultado = _calculosNumericos.Max(x, y);
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void ObtenerImpares_LimiteMayorACero_ResultadoTodosLosNumerosImpares()
        {
            var resultado = _calculosNumericos.ObtenerImpares(8);

            Assert.That(resultado, Is.EquivalentTo(new[] { 1, 3, 5, 7}));

            //
            //Assert.That(resultado, Does.Contain(3));
        }
    }
}
