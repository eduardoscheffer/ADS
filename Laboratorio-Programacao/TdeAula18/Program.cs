using System;
using System.Collections;

namespace TdeAula18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new("Animal", 20, 4);
            Cachorro cachorro = new("Cachorro", 20, 4);
            Gato gato = new("Gato", 20, 2);

            // EmitirSons(animal, cachorro, gato);

            List<Animal> animais = new List<Animal>{
                new Cachorro("Spike", 1, 4),
                new Gato("Black", 4, 2),
                animal
            };

            animais.ForEach(animal => animal.EmitirSom());

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