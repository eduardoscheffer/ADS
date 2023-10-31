using System;

namespace TdeAula18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new("Animal", 20);
            Cachorro cachorro = new("Cachorro", 20);
            Gato gato = new("Gato", 20);

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