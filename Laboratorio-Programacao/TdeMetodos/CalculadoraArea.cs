using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 7: Classe CalculadoraArea
// Classe: CalculadoraArea
// Métodos: Sobrecargas do método CalcularArea()
// Descrição: Crie sobrecargas do método CalcularArea() conforme especificado anteriormente. Não utilize atributos.

namespace TdeMetodos
{
    public class CalculadoraArea
    {
        public static double CalcularArea(double ladoA, double ladoB) => ladoA * ladoB;
        public static double CalcularArea(double ladoA, double ladoB, double ladoC) => ladoA * ladoB * ladoC;
    }
}