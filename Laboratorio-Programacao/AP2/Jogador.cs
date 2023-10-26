using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public int Pontos { get; set; }
        
        public Jogador(string nome, string nickname) 
        {
            Nome = nome;
            Nickname = nickname;
            Pontos = 0;
        }

        public void Jogar()
        {
            Random random = new Random();
            Pontos += random.Next(1, 100 + 1);
        }
    }
}