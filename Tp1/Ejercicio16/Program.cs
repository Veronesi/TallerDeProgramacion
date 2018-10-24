using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizamos un Array de char para poder editar la cadena.
            char[] cadena1;
            char[] cadena2;
            System.Console.Write("Ingrese una cadena: ");
            cadena1 = System.Console.ReadLine().ToCharArray();
            System.Console.Write("Ingrese otra cadena: ");
            cadena2 = System.Console.ReadLine().ToCharArray();
            // Para que sean anagramas deben tener la misma longitud
            if(cadena1.Length == cadena2.Length)
            {
                // Variable que representa el i-esimo caracter de la primera cadena.
                int i = 0;
                // Variable para saber si todavia pueden ser anagramas.
                bool seguir = true;
                while(i < cadena1.Length && seguir)
                {
                    // Variable que representa el j-esimo caracter de la segunda cadena.
                    int j = 0;
                    // Variable para saber si ya encontramos el i-esimo caracter en la cadena2.
                    bool buscarPar = true;
                    while(j < cadena1.Length && buscarPar)
                    {
                        // Analizamos si el i-esomo caracter de la cadena1 es igual al j-esimo caracter de la cadena2
                        if (cadena1[i] == cadena2[j])
                        {
                            // "Eliminamos" el j-esimo elemento.
                            cadena2[j] = ' ';
                            // Cambiamos a false ya que encontramos el caracter.
                            buscarPar = false;
                        }
                        j++;
                    }
                    // Si buscarPar es verdadero es que el caracter i-esimo de la cadena1 no existe en la cadena2.
                    if (buscarPar)
                        seguir = false;
                    i++;
                }
                // Mostramos el resultado.
                if (seguir)
                    System.Console.WriteLine("Son anagramas");
                else
                    System.Console.WriteLine("No son anagramas");
            }
            System.Console.ReadKey();
        }
    }
}
