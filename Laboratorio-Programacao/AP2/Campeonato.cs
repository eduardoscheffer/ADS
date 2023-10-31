using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2
{
    public class Campeonato
    {
        public string NomeCampeonato { get; set; }
        public List<Equipe> EquipesParticipantes = new(); // lista de equipes participantes já inicializada

        public Campeonato(string nome) // construtor pro nome
        {
            NomeCampeonato = nome;
        }

        public void AdicionarEquipes(params Equipe[] equipes) // metodo pra adicionar Equipe. Recebe uma quantidade variável de parâmetros
        {
            EquipesParticipantes.AddRange(equipes); // AddRange pra adicionar os elementos da Array 
        }

        public void IniciarPartida() // metodo que inicia a partida. Vai dentro da lista de Equipes, que em cada iteracao vai em cada jogador e chama o metodo Jogar
        {   
            // for dentro de um for:
            // foreach (var equipe in EquipesParticipantes)
            // {
            //     foreach (var jogador in equipe.Jogadores)
            //     {
            //         jogador.Jogar();
            //     }
            // }
            EquipesParticipantes.ForEach(equipe => {
                equipe.Jogadores.ForEach(jogador => jogador.Jogar());
            });
        }

        public void Classificacao() // metodo que imprime a classificacao do campeonato
        {
            List<Equipe> equipesOrganizadas = EquipesParticipantes.OrderByDescending(equipe => equipe.PontosTotal()).ToList(); // utilizei OrderByDescending, mas poderia ter usado um Comparator ou implementar a interface Comparable na classe Equipe pra ordenar a lista com base nos pontos totais
            
            for (int i = 1; i <= EquipesParticipantes.Count; i++)
            {
                Console.WriteLine($"{i}º - {equipesOrganizadas[i - 1].NomeEquipe} PTS: {equipesOrganizadas[i - 1].PontosTotal()}"); // printa a classificacao
            }
        }
    }
}