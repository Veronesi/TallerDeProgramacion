using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /// <summary>
    /// La clase animal es una clase abstracta la cual consta de dos propiedades
    /// <para>el metodo Correr() es un metodo el cual devuelve el mensaje "esta corriendo"</para>
    /// <para>el metodo Saltar() devuelve el mensaje "esta saltando"</para>
    /// <para>El metodo abstracto HacerRuido() es un metodo que segun cual subclase lo herede va a tener un comportamiento determinado</para>
    /// </summary>
    public abstract class Animal
    {
        public void Correr()
        {
            Console.WriteLine("Esta Corriendo");
        }
        public void Saltar()
        {
            Console.WriteLine("Esta Saltando");
        }
        public abstract void HacerRuido();
    }
}
