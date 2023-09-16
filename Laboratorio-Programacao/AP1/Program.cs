using System.Globalization;

using AP1;

namespace Ap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Pessoa pessoa = new Pessoa();
            
            do
            {
                PrintMenu.Print();
                option = PrintMenu.Option();

                switch (option)
                {
                    case 9:
                    PrintMenu.Exit();
                    break;
                }

                if (option == 1)
                {
                    try
                    {
                        Console.Write("NOME: ");
                        pessoa.Nome = Console.ReadLine();
    
                        Console.Write("IDADE: ");
                        pessoa.Idade = int.Parse(Console.ReadLine());
    
                        Console.Write("PESO (Kg): ");
                        pessoa.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
                        Console.Write("ALTURA (m): ");
                        pessoa.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite uma entrada de dados válida.");
                        Console.ResetColor();
                        continue;
                    }

                    Console.WriteLine("===========================");
                    Console.WriteLine("Nome: " + pessoa.Nome);
                    Console.WriteLine("Idade: " + pessoa.Idade + " anos.");
                    Console.WriteLine("IMC: " + pessoa.IMC.ToString("F2", CultureInfo.InvariantCulture) + "Kg/m²" + "\n" + pessoa.FaixaIMC);
                    Console.WriteLine("===========================");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Gostaria de realizar outro serviço (y/n)? ");
                    Console.ResetColor();
                    if (Console.ReadLine().ToUpper().StartsWith("Y"))
                    {
                        Console.Clear();
                        continue;
                    }
                    else 
                        PrintMenu.Exit();
                        break;
                    
                }

            } while (option != 9);
        }
    }
}