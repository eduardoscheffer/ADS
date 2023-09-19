
namespace AP1
{
    public static class ImcCalculator
    {
        public static string GetIMC(Pessoa pessoa) // recebe uma Pessoa como argumento
        {
            // double imc = pessoa.Peso / Math.Pow(pessoa.Altura, 2);
            double imc = CalculateIMC(pessoa); // chama o metodo da propria classe e guarda numa variavl imc pra verificar a faixa do IMC

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

        public static double CalculateIMC(Pessoa pessoa) => pessoa.Peso / Math.Pow(pessoa.Altura, 2); // calculo do IMC da Pessoa passada no argumento
    }
}