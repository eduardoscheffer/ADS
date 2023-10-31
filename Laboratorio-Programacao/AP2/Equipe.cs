using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2
{
    public class Equipe
    {
        public string NomeEquipe { get; set; }
        public List<Jogador> Jogadores = new(); // Lista de Jogadores já inicializada

        public Equipe (string equipeName) // construtor só pro nome
        {
            NomeEquipe = equipeName;
        }

        public int PontosTotal() // metodo que vai em cada jogador e retorna o total dos pontos dele. Por fim, o metodo retorna a soma dos pontos de cada jogador (pontuacao da Equipe)
        {
            int totalPoints = 0;

            Jogadores.ForEach(jogador => totalPoints += jogador.Pontos);

            return totalPoints;
        }

        public void AdicionarJogador(Jogador player) // metodo pra adicionar jogador a Equipe(lista)
        {
            if (Jogadores.Count < 5)
                Jogadores.Add(player);
            else
                throw new Exception("Equipe deve conter no máximo 5 players");
        }

        
    }
}