using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int desde = 1900;
            int hasta = 2015;
            for(int i = desde; i <= hasta; i++)
            {
                /*
                 * Nos fijamos si la division del año entre 4 nos da como resto cero
                 * para ver si es un año biciesto. 
                 */
                if (i % 4 == 0)
                    System.Console.WriteLine(i);
            }
            System.Console.ReadKey();
        }
    }
}
