using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2
{
    public class Jogador
    {   
        // atributos:
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public int Pontos { get; set; }
        
        // construtor:
        public Jogador(string nome, string nickname) 
        {
            Nome = nome;
            Nickname = nickname;
            Pontos = 0;
        }

        // metodo Jogar:
        public void Jogar()
        {
            Random random = new Random(); // instancia a classe Random
            Pontos += random.Next(1, 100 + 1); // gera um valor aleatorio e atribui ao atributo Pontos do jogador
        }
    }
}