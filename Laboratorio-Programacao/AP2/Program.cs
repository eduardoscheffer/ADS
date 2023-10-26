
namespace AP2; 
internal class Program
{
    static void Main(string[] args)
    {
        Jogador jogador1 = new Jogador("Jogador1", "Nick1");
        Jogador jogador2 = new Jogador("Jogador2", "Nick2");
        Jogador jogador3 = new Jogador("Jogador3", "Nick3");
        Jogador jogador4 = new Jogador("Jogador4", "Nick4");
        Jogador jogador5 = new Jogador("Jogador5", "Nick5");

        Equipe equipe1 = new Equipe("Vikings");
        equipe1.AdicionarJogador(jogador1);
        equipe1.AdicionarJogador(jogador2);
        equipe1.AdicionarJogador(jogador3);
        equipe1.AdicionarJogador(jogador4);
        equipe1.AdicionarJogador(jogador5);

        Jogador jogador6 = new Jogador("Jogador1", "Nick1");
        Jogador jogador7 = new Jogador("Jogador2", "Nick2");
        Jogador jogador8 = new Jogador("Jogador3", "Nick3");
        Jogador jogador9 = new Jogador("Jogador4", "Nick4");
        Jogador jogador10 = new Jogador("Jogador5", "Nick5");

        Equipe equipe2 = new Equipe("Rawks");
        equipe2.AdicionarJogador(jogador6);
        equipe2.AdicionarJogador(jogador7);
        equipe2.AdicionarJogador(jogador8);
        equipe2.AdicionarJogador(jogador9);
        equipe2.AdicionarJogador(jogador10);

        List<Equipe> equipes = new List<Equipe> {equipe1, equipe2};

        Campeonato campeonato = new("Campeonato de CS");
        campeonato.AdicionarEquipes(equipes.ToArray());

        campeonato.IniciarPartida();

        campeonato.Classificacao();
        
    }
}
