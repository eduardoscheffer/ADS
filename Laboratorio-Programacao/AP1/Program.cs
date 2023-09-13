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
                    Console.Write("Saindo");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);

                    Console.Clear();
                    break;
                }

                if (option == 1)
                {
                    Console.Write("NOME: ");
                    pessoa.Nome = Console.ReadLine();

                    Console.Write("IDADE: ");
                    pessoa.Idade = int.Parse(Console.ReadLine());

                    Console.Write("PESO (Kg): ");
                    pessoa.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("ALTURA (m): ");
                    pessoa.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("===========================");
                    Console.WriteLine("Nome: " + pessoa.Nome);
                    Console.WriteLine("Idade: " + pessoa.Idade + " anos.");
                    Console.WriteLine("IMC: " + pessoa.IMC.ToString("F2", CultureInfo.InvariantCulture) + "Kg/m²" + "\n" + pessoa.FaixaIMC);
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                    
                }

            } while (option != 9);
        }
    }
}