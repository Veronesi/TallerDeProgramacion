using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato Garfield = new Gato();
            Perro Chicha = new Perro();
            Veterinaria Algarrobo = new Veterinaria();
            Algarrobo.AceptarAnimales(Garfield);
            Algarrobo.AceptarAnimales(Chicha);
            Console.ReadKey();
        }
    }
}