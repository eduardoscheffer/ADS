using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2
{
    public class Campeonato
    {
        public string NomeCampeonato { get; set; }
        public List<Equipe> EquipesParticipantes = new();

        public Campeonato(string nome)
        {
            NomeCampeonato = nome;
        }

        public void AdicionarEquipes(params Equipe[] equipes)
        {
            EquipesParticipantes.AddRange(equipes);
        }

        public void IniciarPartida()
        {
            Console.WriteLine(EquipesParticipantes.Count);
            EquipesParticipantes.ForEach(equipe => {
                equipe.Jogadores.ForEach(jogador => jogador.Jogar());
            });
        }

        public void Classificacao()
        {
            List<Equipe> equipesOrganizadas = EquipesParticipantes.OrderByDescending(equipe => equipe.PontosTotal()).ToList();
            
            for (int i = 1; i <= EquipesParticipantes.Count; i++)
            {
                Console.WriteLine($"{i}º - {equipesOrganizadas[i - 1].NomeEquipe} PTS: {equipesOrganizadas[i - 1].PontosTotal()}");
            }
        }
    }
}