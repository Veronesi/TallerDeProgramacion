using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada iFachada = new Fachada();
            void MenuPrincipal()
            {
                Console.Clear();
                Console.Write("\n\n\n    1- FIFO");
                Console.Write("\n    2- Triaje");
                Console.Write("\n\n    Tipo de cola [1/2]: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        iFachada.CambiarEstrategia("FIFO");
                        MenuGuardia();
                        break;
                    case "2":
                        iFachada.CambiarEstrategia("Triaje");
                        MenuGuardia();
                        break;
                    default:
                        MenuPrincipal();
                        break;
                }
            }
            void MenuGuardia()
            {
                Console.Clear();
                Console.Write("\n\n\n    1- Agregar Paciente");
                Console.Write("\n    2- Consultar proximo Paciente");
                Console.Write("\n    3- Cambiar modo de ser atendidos");
                Console.Write("\n\n    Tipo de cola [1/2/3]: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        MenuAgregarPaciente();
                        break;
                    case "2":
                        MenuProximoPaciente();
                        break;
                    case "3":
                        MenuPrincipal();
                        break;
                    default:
                        MenuGuardia();
                        break;
                }
            }
            void MenuAgregarPaciente()
            {
                Console.Clear();
                Console.Write("\n\n\n    Numero de Paciente: ");
                Int16 numeroPaciente = Convert.ToInt16(Console.ReadLine());
                Console.Write("    Nivel de Urgencia[1/2/3/4/5]: ");
                Int16 nivelUrgencia = Convert.ToInt16(Console.ReadLine());
                iFachada.PushPaciente(numeroPaciente, nivelUrgencia);
                MenuGuardia();
            }
            void MenuProximoPaciente()
            {
                String[] paciente = iFachada.PopPaciente();
                Console.Clear();
                if(paciente[1] != "Blanco")
                    Console.Write("\n\n\n    El paciente Numero "+ paciente[0]+" es el siguiente con un nivel de urgencia de "+paciente[1]);
                else
                    Console.Write("\n\n\n    No hay paciente en lista de espera");
                Console.ReadKey();
                MenuGuardia();
            }
            MenuPrincipal();
            Console.ReadKey();
        }
    }
}
