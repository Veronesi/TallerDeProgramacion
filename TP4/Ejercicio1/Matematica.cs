using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    static class Matematica
    {
        public static Double Dividir(int pDividendo, int pDivisor)
        {
            try
            {
                if (pDivisor == 0)
                    throw new DivisionPorCeroException(pDivisor.ToString());

                int resultado;
                resultado = pDividendo / pDivisor;
                return resultado;
            }
            finally{}
        }
    }
}
