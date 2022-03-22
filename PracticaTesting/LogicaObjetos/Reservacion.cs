using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTesting.LogicaObjetos
{
    public class Reservacion
    {
        public Usuario HechaPor { get; set; }

        public bool CanceladaPor(Usuario usuario)
        {
            return (usuario.EsAdmin || HechaPor == usuario);
        }
    }

    public class Usuario
    {
        public bool EsAdmin { get; set; }
    }
}
