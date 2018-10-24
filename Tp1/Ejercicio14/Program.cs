using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

            Double[] listaNum = new Double[30];
            /*
             * Inicializamos max y min con -1 y 2 ya que generamos numeros entre [0;1] 
             * y estos siempre van a ser mayor que -1 y menor que 2.
            */        
            Double max = -1;
            Double min = 2;
            Double suma = 0;
            Double promedio;
            Random rnd = new Random();
            for (int i = 0; i <= 29; i++)
            {
                // Generamos un numero random.
                listaNum[i] = rnd.NextDouble();
                suma += listaNum[i];
                // Verificamos si es un maximo o un minimo.
                if (listaNum[i] > max)
                    max = listaNum[i];
                if (listaNum[i] < min)
                    min = listaNum[i];
            }
            // Calculamos el promedio.
            promedio = suma / 30;
            System.Console.WriteLine("Maximo: " + max + "\nMin: " + min + "\nSuma: " + suma + "\nPromedio: " + promedio);
            System.Console.ReadKey();
        }
    }
}
