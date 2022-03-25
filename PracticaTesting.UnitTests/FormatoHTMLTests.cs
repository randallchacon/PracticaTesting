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
    public class FormatoHTMLTests
    {
        [Test]
        public void FormatoNegrita_AlInvocar_ResultadoUsoDeTagStrong()
        {
            var formatoHTML = new FormatoHTML();

            var resultado = formatoHTML.FormatoNegrita("Randall");

            Assert.That(resultado, Does.Contain("<strong>"));

            //Assert.That(resultado, Does.StartWith("<strong>"));
            //Assert.That(resultado, Does.EndWith("</strong>"));
        }

        [Test]
        public void FormatoTituloSecundario_AlInvocar_ResultadoUsoDeTagH2InicioYCierre()
        {
            var formatoHTML = new FormatoHTML();

            var resultado = formatoHTML.FormatoTituloSecundario("Titulo 2");

            Assert.That(resultado, Is.EqualTo("<h2>Titulo 2</h2>"));
        }
    }
}
