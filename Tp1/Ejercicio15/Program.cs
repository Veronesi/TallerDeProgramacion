using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNum = new int[50];
            const int MIN = 1;
            const int MAX = 100;
            Random rnd = new Random();
            for (int i = 0; i <= 49; i++)
                // Generamos un numero aleatorio.
                listaNum[i] = rnd.Next(MIN,MAX);
            // Realizamos el metodo burbuja para ordenarlos de forma ascendente.
            for(int i = 2; i<= 49; i++)
            {
                for(int j = 0; j < 49; j++)
                {
                    if(listaNum[j] > listaNum[j + 1])
                    {
                        int aux = listaNum[j];
                        listaNum[j] = listaNum[j + 1];
                        listaNum[j + 1] = aux;
                    }
                }
            }
            for (int i = 0; i <= 49; i++)
                // Mostramos el resultado.
                System.Console.WriteLine(listaNum[i]);
            System.Console.ReadKey();
        }
    }
}
