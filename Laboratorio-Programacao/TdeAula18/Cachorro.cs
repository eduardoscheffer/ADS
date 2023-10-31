using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdeAula18
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au au");
        }
    }
}