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
        protected int NumeroDePatas { get; set; }

        public Animal(string nome, int idade, int numPatas) 
        {
            Nome = nome;
            Idade = idade;
            NumeroDePatas = numPatas;
        }

        protected void ExibirNumeroDePatas()
        {
            Console.WriteLine($"Numero de Patas: {NumeroDePatas}.");
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de animal");
        }
    }
}