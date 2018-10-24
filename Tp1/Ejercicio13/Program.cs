using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] listaCadenaInversa = new String[5];
            // Recorremos las 5 cadejas.
            for (int i = 0; i <= 4; i++)
            {
                int tamCadena = args[i].Length;
                // Creamos un Array auxiliar para ir armando la cadena inversa.
                char[] cadenaAux = new char[tamCadena];
                // Recorremos el String hasta la mitad.
                for (int j = 0; j <= tamCadena /2 ; j++)
                {   
                    // Vamos rellenando el Array auxiliar con los elementos invertidos del String ingresado.
                    cadenaAux[tamCadena-1 -j] = args[i][j];
                    cadenaAux[j] = args[i][tamCadena - 1 - j];
                }
                // Guaramos el String invertido en el Array.
                listaCadenaInversa[i] = new String(cadenaAux);
            }
            for (int i = 4; i >= 0; i--)
            {
                // Mostramos los Strings inverdios.
                System.Console.WriteLine("Cadena Invertida nro "+(i+1)+": "+listaCadenaInversa[i]);
            }
            System.Console.ReadKey();
        }
    }
}