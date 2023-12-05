namespace AS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new();

            while(true)
            {
                Console.WriteLine(Utils.GetMenu()); // utilizei StringBuilder do Java pra criar um Menu

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Quantos livros deseja adicionar? ");
                    int numLivros = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= numLivros; i++)
                    {   
                        Console.WriteLine("Livro #" + i);
                        Console.Write("Id Livro: ");
                        int idLivro = int.Parse(Console.ReadLine());

                        Console.Write("Titulo: ");
                        string tituloLivro = Console.ReadLine();

                        Console.Write("Autor: ");
                        string autorLivro = Console.ReadLine();

                        Livro livro = new(idLivro, tituloLivro, autorLivro);
                    }
                }

                else if (opcao == 2)
                {
                    // TODO
                }

                else if (opcao == 3)
                {
                    // TODO
                }

                else if (opcao == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }

                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                }
            }
        }
    }
}