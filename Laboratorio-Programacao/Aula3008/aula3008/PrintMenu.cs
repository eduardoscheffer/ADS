using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdeLacosRepeticoes
{
    public class PrintMenu
    {
         public static void Print() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("                                     SELECIONE UMA OPÇÃO DE EXERCICIO                                         ");
            Console.WriteLine("==============================================================================================================");
            Console.ResetColor();

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|         1 - Soma de Números de 1 a 10       2 - Contagem Regressiva com while    3 - Pular Números Ímpares |");
            Console.WriteLine("|4 - Sair Quando o Quadrado For Maior que 50  5 - Tabuada de um Número Usando for  6 - Soma com Loop do-while|");
            Console.WriteLine("|    7 - Primeiro Múltiplo de 3 e 7           8 - Fatorial de um Número                             9 - SAIR |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

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
                    Console.WriteLine("Escolha uma opção entre 1 e 9");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um número válido para seguir adiante");
                option = 0; // Atribui um valor inválido para continuar no loop
            }
        } while (option < 1 || option > 9);

        return option;
        }
    }
}