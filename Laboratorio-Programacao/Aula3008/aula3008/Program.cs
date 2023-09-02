using System;

namespace TdeLacosRepeticoes // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {   
            int option;
            while(true)
            {
                PrintMenu.Print();
                option = PrintMenu.Option();

                if (option == 9)
                {   
                    Console.Write("Saindo");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);

                    Console.Clear();
                    break;
                }
                
                if (option == 1)
                    Exercicio1();

                if (option == 2)
                    Exercicio2();

                if (option == 3)
                    Exercicio3();

                if (option == 4)
                    Exercicio4();

                if (option == 5)
                    Exercicio5();

                if (option == 6)
                    Exercicio6();

                if (option == 7)
                    Exercicio7();

                if (option == 8)
                    Exercicio8();
            }

            Console.WriteLine();
        }

        private static void Exercicio1()
        {
            int total = 0;
            for (int i = 1; i <= 10; i++)
            {
                total += i;
            }

            Console.WriteLine($"Total: {total}");
            Console.WriteLine("\n");
        }

        private static void Exercicio2()
        {
            int n = 10;
            while(n > 0 )
            {
                Console.WriteLine($"-> {n}");
                n--;
            }
        }

        private static void Exercicio3()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine($"-> {i}");
            }
        }

        private static void Exercicio4()
        {
            double quadrado = 0.0;
            double i = 1.0;
            while(true)
            {   
                quadrado = Math.Pow(i, 2);    
                if (quadrado > 50) break; // se a variavel quadrado for maior que 50 quebra o loop, se não printa na tela e atualiza 'i';

                Console.WriteLine($"{i}^2 = {i * i}");
                i++;
            }
        }

        private static void Exercicio5()
        {
            Console.Write("Qual tabuada deseja verificae? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num}x{i} = {i * num}");
            }
        }

        private static void Exercicio6()
        {
            // Exercício 6: Soma com Loop do-while
            // Desenvolva um programa que utilize um loop do-while para solicitar números inteiros ao usuário. Continue somando esses números até que o usuário insira o número 0. Mostre a soma total ao final.
            int total = 0;
            int num;
            do
            {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                total += num;
            } while (num != 0);

            Console.WriteLine($"TOTAL DOS NUMEROS DIGITADOS: {total}");
        }

        private static void Exercicio7()
        {
            // Exercício 7: Encontrar o Primeiro Múltiplo de 3 e 7
            // Utilize um loop for e a palavra-chave break para procurar o primeiro número que seja múltiplo tanto de 3 quanto de 7, dentro do intervalo de 1 a 100. Exiba esse número no console.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine($"-> PRIMEIRO MULTIPLO TANTO DE 3 QUANTO DE 7: {i}");
                    break;
                }
                    
            }
            
        }

        private static void Exercicio8()
        {
            // Peça ao usuário para inserir um número inteiro positivo. Utilize um loop for para calcular o fatorial desse número. Exiba o resultado no console.
            /*
            Pensamento lógico:
            // iniciar o total com o valor do número. A cada iteração multiplicar o total pelo valor do numero-1 e salvar o novo total para proxima iteração;
            5 x 4 x 3 x 2 x 1 = 120;

            i = 1
            factorial = 5 * (5 - 1) = 20;

            i = 2
            factorial = 20 * (5 - 2) = 60;

            i = 3
            factorial = 60 * (5 - 3) = 120;

            i = 4
            factorial = 120 * (5 - 4) = 120;
            */
            
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            int factorial = numero;
            for (int i = 1; i < numero; i++)
            {   
                // i = 4
                // factorial = 120 * (5 - 4) = 120;
                factorial *= numero - i;
            }

            Console.WriteLine($"{numero}! = {factorial}");
        }

    }
}

// Exercício 1: Soma de Números de 1 a 10
// Escreva um programa que utilize um loop for para calcular e exibir na tela a soma dos números inteiros de 1 a 10. Mostre o resultado final após o loop.

 
// Exercício 2: Contagem Regressiva com while
// Crie um programa que use um loop while para realizar uma contagem regressiva a partir de 10 até 0. A cada iteração, o programa deve exibir o número atual no console.
 
// Exercício 3: Pular Números Ímpares
// Desenvolva um programa que utilize um loop for e a palavra-chave continue para imprimir todos os números pares entre 1 e 20. Evite imprimir os números ímpares.
 
// Exercício 4: Sair Quando o Quadrado For Maior que 50
// Escreva um programa que utilize um loop while e a palavra-chave break. O programa deve calcular os quadrados dos números inteiros começando com 1 e parar assim que um quadrado maior que 50 for encontrado. Exiba esse valor no console.
 
// Exercício 5: Tabuada de um Número Usando for
// Crie um programa que solicite ao usuário um número inteiro. Utilize um loop for para imprimir a tabuada desse número, de 1 a 10. Mostre cada linha da tabuada no console.
 
// Exercício 6: Soma com Loop do-while
// Desenvolva um programa que utilize um loop do-while para solicitar números inteiros ao usuário. Continue somando esses números até que o usuário insira o número 0. Mostre a soma total ao final.
 
// Exercício 7: Encontrar o Primeiro Múltiplo de 3 e 7
// Utilize um loop for e a palavra-chave break para procurar o primeiro número que seja múltiplo tanto de 3 quanto de 7, dentro do intervalo de 1 a 100. Exiba esse número no console.
 
// Exercício 8: Fatorial de um Número
// Peça ao usuário para inserir um número inteiro positivo. Utilize um loop for para calcular o fatorial desse número. Exiba o resultado no console.