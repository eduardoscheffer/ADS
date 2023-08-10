using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int idade = 35;
        Console.WriteLine($"Idade: {idade}");

        string nome = "Eduardo";
        Console.WriteLine($"Nome: {nome}");

        double altura = 3.45;
        Console.WriteLine($"Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");

        DateTime data = new DateTime(1999, 09, 04);
        Console.WriteLine($"Data: {data.ToString("dd/MM/yyyy")}");

        int ano = 12;
        Console.WriteLine($"Ano: {ano}");

        double? nota = 7.80;
        Console.WriteLine($"Nota: {nota}");

        double peso = 68.5;
        Console.WriteLine($"Peso: {peso.ToString("F2", CultureInfo.InvariantCulture)}");

        DateTime nascimento = new DateTime(1985, 12, 10);
        Console.WriteLine($"Nascimento: {nascimento.ToString("dd/MM/yyyy")}");

        double? temperatura = 22.5;
        Console.WriteLine($"Temperatura: {temperatura}");
    }
}

/*
1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor
5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o
valor 7.80 e exiba o seu valor.
Claro! Seguem mais cinco exercícios seguindo a mesma lógica:
7- Crie uma variável chamada peso e atribua a ela o valor 68.5 e exiba o seu valor.
8- Crie uma variável chamada cidade e atribua o valor "São Paulo" e exiba o seu valor.
9- Crie uma variável chamada largura e atribua a ela o valor 2.20 e exiba o seu valor.
10- Crie uma variável chamada nascimento e atribua a ela a data 10/12/1985 e exiba o seu valor.
11- Declare uma variável `temperatura` do tipo double como sendo do tipo Nullable type e atribua o valor 22.5 e exiba o seu valor.
*/