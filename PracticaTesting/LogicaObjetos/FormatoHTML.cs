using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTesting.LogicaObjetos
{
    public class FormatoHTML
    {
        public string FormatoNegrita(string texto)
        {
            return $"<strong>{texto}</strong>";
        }

        public string FormatoTituloSecundario(string texto)
        {
            return $"<h2>{texto}</h2>";
        }
    }
}
