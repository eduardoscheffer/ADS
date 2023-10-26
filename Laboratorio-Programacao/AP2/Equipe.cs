using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2
{
    public class Equipe
    {
        public string NomeEquipe { get; set; }
        public List<Jogador> Jogadores = new();

        public Equipe (string equipeName)
        {
            NomeEquipe = equipeName;
        }

        public int PontosTotal()
        {
            int totalPoints = 0;

            Jogadores.ForEach(jogador => totalPoints += jogador.Pontos);

            return totalPoints;
        }

        public void AdicionarJogador(Jogador player)
        {
            if (Jogadores.Count < 5)
                Jogadores.Add(player);
            else
                throw new Exception("Equipe deve conter no máximo 5 players");
        }

        
    }
}