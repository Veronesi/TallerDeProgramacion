using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// HacerRuido es un metodo de la clase Gato, la cual hereda de animal
    /// <para> este metodo devuelve un mensaje que es caracteristico del animal "gato"</para>
    /// </summary>
    /// <seealso cref="Gato"/>
    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("MIAUUUUuuuuuu!!!!");
        }
    }
}
