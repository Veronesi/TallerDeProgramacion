using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Fachada
    {
        public Fachada() { }
        public Double Dividir(int pDividendo, int pDivisor)
        {
            return Matematica.Dividir(pDividendo, pDivisor);
        }
    }
}
