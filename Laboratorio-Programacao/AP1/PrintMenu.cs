using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class PrintMenu
    {
         public static void Print() 
         {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================================");
            Console.WriteLine("                         CALCULADOR DE IMC                           ");
            Console.WriteLine("=====================================================================");

            Console.WriteLine("-------------------------SELECIONE UMA OPÇÃO--------------------------");
            Console.WriteLine("| 1 - Calcular IMC                                          9 - Sair |");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.ResetColor();

        }

        public static int Option() 
        {
        int option;
        do
        {
            try
            {
                Console.Write("Opção desejada: ");
                option = int.Parse(Console.ReadLine());

                if (option != 1 && option != 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha uma dentre as opções disponíveis.");
                    Console.ResetColor();
                }
            }
            catch (FormatException)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite um número válido para seguir adiante.");
                option = 0; // Atribui um valor inválido para continuar no loop
                Console.ResetColor();
            }
        } while (option < 1 || option > 9);

        return option;
        }

        public static void Exit() // logica que faz o Exit do programa
        {
            Console.Write("Saindo");
            Thread.Sleep(1000); // tempo na thread de 1s
            Console.Write(".");
            Thread.Sleep(500); // tempo na thread de meio segundo
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}