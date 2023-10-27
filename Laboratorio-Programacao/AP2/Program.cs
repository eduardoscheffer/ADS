﻿
namespace AP2; 
internal class Program
{
    static void Main(string[] args)
    {   

        while (true)
        {
            Console.WriteLine("1. Criar Campeonato");
            Console.WriteLine("2. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                try
                {
                    Console.Write("Nome do Campeonato: ");
                    string nomeCampeonato = Console.ReadLine();

                    Console.Write("Quantas equipes disputarão o campeonato? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        throw new Exception("Número inválido de equipes.");
                    }

                    Campeonato campeonato = new Campeonato(nomeCampeonato);

                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"Equipe #{i}");
                        Console.Write("Nome da Equipe: ");
                        string nomeEquipe = Console.ReadLine();
                        Equipe equipe = new Equipe(nomeEquipe);

                        for (int j = 1; j <= 5; j++)
                        {
                            Console.Write($"Jogador{j}: ");
                            string playerName = Console.ReadLine();
                            Console.Write($"Nickname do {playerName}: ");
                            string nickname = Console.ReadLine();
                            Jogador player = new Jogador(playerName, nickname);

                            equipe.AdicionarJogador(player);
                        }

                        campeonato.AdicionarEquipes(equipe);
                    }

                    campeonato.IniciarPartida();
                    campeonato.Classificacao();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            else if (escolha == "2")
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            }
        }

    }
}
