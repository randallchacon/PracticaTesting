using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTesting.LogicaObjetos
{
    public class CalculosNumericos
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public IEnumerable<int> ObtenerImpares(int limite)
        {
            for (var i = 0; i <= limite; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}
