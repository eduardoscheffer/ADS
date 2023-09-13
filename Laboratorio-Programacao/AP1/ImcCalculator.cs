using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class ImcCalculator
    {
        public static string CalculateIMC(Pessoa pessoa)
        {
            double imc = pessoa.Peso / Math.Pow(pessoa.Altura, 2);

            if(imc <= 18.5)
                return "Abaixo do Peso";
            else if (imc > 18.5 && imc <= 24.9)
                return "Peso Normal";
            else if (imc > 24.9 && imc <= 29.9)
                return "Sobrepeso";
            else if (imc > 29.9 && imc <= 34.9)
                return "Obesidade (grau I)";
            else if (imc > 34.9 && imc <= 39.9)
                return "Obesidade severa (grau II)";
            else
                return "Obesidade mórbida (grau III)";
            
        }

        public static double GetIMC(Pessoa pessoa)
        {
            return pessoa.Peso / Math.Pow(pessoa.Altura, 2);
        }
    }
}