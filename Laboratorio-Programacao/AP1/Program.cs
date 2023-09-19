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
                PrintMenu.Print(); // oprinta o menu pro usuaio
                option = PrintMenu.Option(); // pega a opcao do usuario

                switch (option) // switch com option - poderia ser com if else
                {
                    case 9:
                    PrintMenu.Exit(); // quebra o loop e chama o metodo exit
                    break;
                }

                if (option == 1)
                {
                    try
                    {
                        // pega as informacoes do usuario:
                        Console.Write("NOME: ");
                        pessoa.Nome = Console.ReadLine();
    
                        Console.Write("IDADE: ");
                        pessoa.Idade = int.Parse(Console.ReadLine());
    
                        Console.Write("PESO (Kg): ");
                        pessoa.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
                        Console.Write("ALTURA (m): ");
                        pessoa.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    catch (FormatException) // trata qualquer FormatException que der 
                    {   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite uma entrada de dados válida.");
                        Console.ResetColor();
                        continue;
                    }

                    // printa o relatorio
                    Console.WriteLine("===========================");
                    Console.WriteLine("Nome: " + pessoa.Nome);
                    Console.WriteLine("Idade: " + pessoa.Idade + " anos.");
                    Console.WriteLine("IMC: " + pessoa.IMC.ToString("F2", CultureInfo.InvariantCulture) + "Kg/m²" + "\n" + pessoa.FaixaIMC);
                    Console.WriteLine("===========================");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkCyan; // troca a cor do console pra chamar a atencao
                    Console.Write("Gostaria de realizar outro serviço (y/n)? ");
                    Console.ResetColor();
                    if (Console.ReadLine().ToUpper().StartsWith("Y")) // caso o usuario digitar algo que começe com "Y": "yes, y, Y, YES, Yes etc"
                    {
                        Console.Clear(); // limpa o console e recomeça o loop (continue)
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