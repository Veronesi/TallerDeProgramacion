using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// La clase veterinaria es una clase la cual simplemente adopta animales
    /// <para> el metodo AceptarAnimales es un metodo de la clase animal que devuelve el mensaje HacerRuido con</para>
    /// <paramref name="pAnimal"> que es un parametro que toma un animal</paramref>
    /// <param name="pAnimal">indica que animal estoy aceptado para la adopcion </param>
    /// </summary>
    class Veterinaria
    {
        public void AceptarAnimales(Animal pAnimal)
        {
            pAnimal.HacerRuido();
        }
    }
}
