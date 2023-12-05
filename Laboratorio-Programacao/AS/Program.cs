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
                        biblioteca.AdicionarItem(livro); // AdiocionarItem espera um ItemBiblioteca como parâmetro, mas aceita Livro devido ao fato de Livro ser um ItemBiblioteca (Herança)
                    }
                }

                else if (opcao == 2)
                {
                    Console.Write("Digite o Titulo do Livro a ser encontrado? ");
                    string tituloLivro = Console.ReadLine();
                    Livro livroEncontrado = (Livro) biblioteca.BuscarItemPorTitulo(tituloLivro); // casting explicito pois eu sei que sempre vai retornar um Livro do método BuscarItemPorTitulo
                    livroEncontrado.ExibirDescricaoInterna();
                }

                else if (opcao == 3)
                {
                    Console.Write("Digite o ID do Livro que deseja remover: ");
                    int idLivro = int.Parse(Console.ReadLine());
                    biblioteca.RemoverItem(idLivro);
                    Console.WriteLine("Livro " + idLivro + " removido com sucesso");
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