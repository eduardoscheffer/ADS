
namespace AP2; 
internal class Program
{
    static void Main(string[] args)
    {   
        Campeonato campeonato = new Campeonato("CS-GO CHAMPIONSHIP");
        
        Console.Write("Quantas equipes disputarão o campeonato? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Equipe #{i}");
            Console.Write("Nome da Equipe: ");
            string nomeEquipe = Console.ReadLine();
            Equipe equipe = new(nomeEquipe);

            for (int j = 1; j <= 5; j++)
            {   
                Console.Write($"Jogador{j}: ");
                string playerName = Console.ReadLine();
                Console.Write($"Nickname do {playerName}: ");
                string nickname = Console.ReadLine();
                Jogador player = new(playerName, nickname);

                equipe.AdicionarJogador(player);
            }

            campeonato.AdicionarEquipes(equipe);

        }

        campeonato.IniciarPartida();

        campeonato.Classificacao();

    }
}
