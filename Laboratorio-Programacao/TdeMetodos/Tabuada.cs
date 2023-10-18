using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 8: Classe Tabuada
// Classe: Tabuada
// Atributos: numeroBase
// Método: ImprimirTabuada()
// Descrição: Crie um método que imprima a tabuada do numeroBase.

namespace TdeMetodos
{
    public class Tabuada
    {
        public Tabuada(int numeroBase) 
        {
            this.NumeroBase = numeroBase;
   
        }

        public int NumeroBase { get; set; }

        public void ImprimirTabuada()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{NumeroBase} x {i} = {NumeroBase * i}");
            }
        }
        
    }
}