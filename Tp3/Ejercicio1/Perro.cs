using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// HacerRuido es un metodo de la clase Perro, la cual hereda de animal
    /// <para> este metodo devuelve un mensaje que es caracteristico del animal "perro"</para>
    /// </summary>
    /// <seealso cref="Perro"/>
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Grrrrr....Gau..Gau!!");
        }
    }
}
