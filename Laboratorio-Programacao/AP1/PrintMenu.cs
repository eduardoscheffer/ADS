using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class PrintMenu
    {
         public static void Print() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================================");
            Console.WriteLine("                         CALCULADOR DE IMC                           ");
            Console.WriteLine("=====================================================================");

            Console.WriteLine("-------------------------SELECIONE UMA OPÇÃO--------------------------");
            Console.WriteLine("| 1 - Calcular IMC                                          9 - Sair |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.ResetColor();

        }

        public static int Option() {
        int option;
        do
        {
            try
            {
                Console.Write("Opção desejada: ");
                option = int.Parse(Console.ReadLine());

                if (option < 1 || option > 9)
                    Console.WriteLine("Escolha uma dentre as opções disponíveis.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número válido para seguir adiante.");
                option = 0; // Atribui um valor inválido para continuar no loop
            }
        } while (option < 1 || option > 9);

        return option;
        }
    }
}