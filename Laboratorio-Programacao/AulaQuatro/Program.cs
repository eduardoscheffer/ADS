using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
                // 2. Dia da Semana
                // Peça ao usuário para inserir um número de 1 a 7. Seu programa deve exibir o dia da semana correspondente, onde 1 é domingo e 7 é sábado. Se o número estiver fora desse intervalo, exiba uma mensagem de erro.

                try
                {
                    Console.Write("Digite um numero entre 1 e 7 para saber o dia da semana correspondente: ");
                    var diaSemana = int.Parse(Console.ReadLine());
                    switch (diaSemana)
                    {
                        case 1:
                            Console.WriteLine("Segunda");
                            break;
                        case 2:
                            Console.WriteLine("Terça");
                            break;
                        case 3:
                            Console.WriteLine("Quarta");
                            break;
                        case 4:
                            Console.WriteLine("Quinta");
                            break;
                        case 5:
                            Console.WriteLine("Sexta");
                            break;
                        case 6:
                            Console.WriteLine("Sabado");
                            break;
                        case 7:
                            Console.WriteLine("Domingo");
                            break;

                        default:
                            Console.WriteLine("Valor inexistente");
                            break;
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: Digite um numero válido entro 1 e 7" + e.Message);
                }

                // 4. Ano Bissexto
                // Peça ao usuário para inserir um ano e determine se é um ano bissexto ou não.
                Console.Write("Insira um ano para determinar se ele é bissexto: ");
                int year = int.Parse(Console.ReadLine());
                if (DateTime.IsLeapYear(year))
                    Console.WriteLine("SIM, é bissexto");
                else
                    Console.WriteLine("NAO, não é bissexto");

                // 8. Maior Número
                // Solicite ao usuário que insira três números. Determine e exiba o maior deles.
                Console.Write("Digite 3 numeros inteiros para verificar qual o maior entre os 3: ");
                int[] numbers = Console.ReadLine().Split(" ").Select(number => int.Parse(number)).ToArray();
                var biggest = Math.Max(numbers[0], Math.Max(numbers[1], numbers[2]));
                Console.WriteLine($"Maior: {biggest}");
    }
}

/*
1. Positivo, Negativo ou Zero?
Escreva um programa que leia um número do usuário e determine se ele é positivo, negativo ou zero.

2. Dia da Semana
Peça ao usuário para inserir um número de 1 a 7. Seu programa deve exibir o dia da semana correspondente, onde 1 é domingo e 7 é sábado. Se o número estiver fora desse intervalo, exiba uma mensagem de erro.

3. Faixas Etárias
Crie um programa que leia a idade do usuário e categorize-a nas seguintes faixas etárias:
Criança (0-12 anos)
Adolescente (13-18 anos)
Adulto (19-59 anos)
Idoso (60 anos ou mais)

4. Ano Bissexto
Peça ao usuário para inserir um ano e determine se é um ano bissexto ou não.

5. Calculadora Básica
Escreva um programa que peça ao usuário dois números e uma operação (soma, subtração, multiplicação, divisão). Use uma estrutura switch para realizar a operação escolhida e exiba o resultado.

6. Avaliação de Notas
Solicite ao usuário que insira uma nota (0-100). Classifique a nota nas seguintes categorias:
A (90-100)
B (80-89)
C (70-79)
D (60-69)
F (0-59)

7. Meses do Ano
Peça ao usuário para inserir um número de 1 a 12. Exiba o mês correspondente ao número. Se o número estiver fora desse intervalo, mostre uma mensagem de erro.

8. Maior Número
Solicite ao usuário que insira três números. Determine e exiba o maior deles.

9. Tarifa de Ônibus
Crie um programa que determine a tarifa de ônibus a ser paga pelo usuário com base em sua idade. As tarifas são:
Crianças até 5 anos: grátis
Crianças de 6 a 12 anos: 50% de desconto
Adultos de 13 a 59 anos: tarifa completa
Idosos (60 anos ou mais): grátis

10. Temperatura
Peça ao usuário para inserir uma temperatura. Classifique e exiba a seguinte mensagem:
Abaixo de 0: “Congelando!”
0 a 15: “Frio!”
16 a 25: “Clima agradável!”
26 a 35: “Calor!”
Acima de 35: “Muito quente!”
*/