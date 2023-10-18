using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 2: Classe Quadrado
// Classe: Quadrado
// Atributos: numero
// Método: CalcularEImprimirQuadrado()
// Descrição: Crie um método que imprima o quadrado do número armazenado no atributo numero.

namespace TdeMetodos
{
    public class Quadrado
    {
        public Quadrado(double numero) 
        {
            Numero = numero;
   
        }
        
        public double Numero { get; set; }

        public void CalcularEImprimirQuadrado()
        {
            Console.WriteLine(Math.Pow(Numero, 2));
        }

        
    }
}