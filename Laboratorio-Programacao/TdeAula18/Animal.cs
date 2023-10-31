using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdeAula18
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de animal");
        }
    }
}