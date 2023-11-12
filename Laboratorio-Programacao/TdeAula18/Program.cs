using System;

namespace TdeAula18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new("Animal", 20, 4);
            Cachorro cachorro = new("Cachorro", 20, 4);
            Gato gato = new("Gato", 20, 2);

            EmitirSons(animal, cachorro, gato);
        }

        static void EmitirSons(params Animal[] animals)
        {
            foreach (var animal in animals)
            {
                animal.EmitirSom();
            }
        }
    }
}