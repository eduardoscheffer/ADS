using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            while(true)
            {   
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("==============================================");
                Console.WriteLine("|-------------Cálculo de Desempenho-----------|");
                Console.ResetColor();

                Console.Write("Digite o nome do aluno: ");
                string studentName = Console.ReadLine();

                Console.Write("Digite as três notas separadas por um espaço em branco cada: ");
                List<double> notas = Console.ReadLine().Split(" ").Select(nota => double.Parse(nota)).ToList();

                Console.WriteLine("===================RELATÓRIO===================");
                Console.WriteLine("NOME: " + studentName);

                Console.WriteLine("NOTA UM: " + notas[0].ToString("F2", CultureInfo.InvariantCulture));


                Console.WriteLine("NOTA DOIS: " + notas[1].ToString("F2", CultureInfo.InvariantCulture));


                Console.WriteLine("NOTA TRÊS: " + notas[2].ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("MÉDIA: " + ( (notas[0] + notas[1] + notas[2]) / 3 ).ToString("F2", CultureInfo.InvariantCulture));

                bool aprovado = false;
                if ((notas[0] + notas[1] + notas[2]) / 3 >= 7)
                    aprovado = true;

                Console.WriteLine();

                if (aprovado == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("REPROVADO");
                }
                
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("==============================================");
                Console.ResetColor();
                Console.Write("Deseja calcular as notas de outro aluno? ");
                string quit = Console.ReadLine();

                if (quit.ToLower().StartsWith("n"))
                    break;
                Console.WriteLine();
            }
            
        }
    }
}