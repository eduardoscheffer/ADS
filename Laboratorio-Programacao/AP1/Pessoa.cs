using System.Globalization;

namespace AP1
{
    public class Pessoa
    {
        public string Nome { get; set; } // prop nome
        public int Idade { get; set; } // prop idade
        public double Peso { get; set; } // prop Peso
        public double Altura { get; set; } // prop altura

        public double IMC  // IMC em valor numerico
        {
            get { return ImcCalculator.CalculateIMC(this); } // resultado do metodo CalculateIMC passando como argumento uma instancia dessa classe (this) - no caso um objeto que represente essa classe
            set { IMC = value; } // set pra caso precisar mexer no imc manualmente
        }

        public string FaixaIMC // propriedade que retorna uma string. Mesma logica do CalculateIMC mas nesse caso retorna a faixa do IMC
        {
            get { return ImcCalculator.GetIMC(this); }
        }

        public Pessoa() {} // construtor vazio

        public Pessoa(string nome, int idade, double peso, double altura) // construtor
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
        }

        public override string ToString() // to string personalizado pra printar uma Pessoa
        {
            return $"{Nome}, {Idade} anos de idade. {Peso.ToString("F2", CultureInfo.InvariantCulture)}Kg. {Altura.ToString("F2", CultureInfo.InvariantCulture)}m²";
        }
    }
}