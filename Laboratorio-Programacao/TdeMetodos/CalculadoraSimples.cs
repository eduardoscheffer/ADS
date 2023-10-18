using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 3: Classe CalculadoraSimples
// Classe: CalculadoraSimples
// Métodos: Sobrecargas do método Somar(int a, int b) e Somar(int a, int b, int c)
// Descrição: Crie métodos que retornem a soma dos parâmetros passados. Não utilize atributos.

namespace TdeMetodos
{
    public class CalculadoraSimples
    {
        public static int Somar(int a, int b) => a + b;
        public static int Somar(int a, int b, int c) => a + b + c;
        
    }
}