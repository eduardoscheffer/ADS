
using System.Globalization;

namespace AP1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double IMC 
        {
            get {return ImcCalculator.GetIMC(this);}
        }

        public string FaixaIMC
        {
            get {return ImcCalculator.CalculateIMC(this);}
        }

        public Pessoa() {}

        public Pessoa(string nome, int idade, double peso, double altura)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome}, {Idade} anos de idade. {Peso.ToString("F2", CultureInfo.InvariantCulture)}Kg. {Altura.ToString("F2", CultureInfo.InvariantCulture)}m²";
        }
    }
}