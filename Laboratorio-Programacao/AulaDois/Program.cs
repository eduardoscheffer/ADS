using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        Console.ForegroundColor = ConsoleColor.Blue; // cor dos outputs
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture; // CultureInfo como default

        // 1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato:
        // Aluno tem anos e nota usando a concatenação e a interpolação de strings.
        string nome = "Paulo";
        int idade = 17;
        double nota = 7.5;
        Console.WriteLine($"{nome} tem {idade} anos e sua nota eh {nota.ToString("F2", CultureInfo.InvariantCulture)}");

        // 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
        Console.WriteLine($"{nome}\n{idade}\n{nota}");

        // 3- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
        // a concatenação e também a interpolação de string
        List<string> letraS = Console.ReadLine().Split(" ").ToList();
        letraS.Reverse();
        letraS.ForEach(letra => Console.Write(letra));
        
        // 4- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
        // realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
        // exibindo o resultado
        List<double> letras = Console.ReadLine()
                .Split(" ")
                .Select(val => double.Parse(val))
                .ToList();

        Console.Write($"Soma = {letras[0] + letras[1]}\nSubtracao = {-1 * (letras[0] - letras[1])}.\nMultiplicacao = {letras[0] * letras[1]}\nExponenciacao {letras[0]}^{letras[1]} = {Math.Pow(letras[0], letras[1])}\nDivisao = {letras[0] / letras[1]}\nModulo {letras[0]} = {Math.Abs(letras[0])}, Modulo {letras[1]} = {Math.Abs(letras[1])}");

        // 5- Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
        // a b e c .
        // Valores : a = 1 , b = 12 e c = -13
        Console.Write("Digite os valores de a b e c separadas por um espaço: ");
        int[] inputs = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
        int A = inputs[0];
        int B = inputs[1];
        int C = inputs[2];
        double delta = Math.Pow(B, 2) - 4 * A * C; // calculo do Delta

        double x1 = (-B + Math.Sqrt(delta)) / (2 * A); // calculo do x1
        double x2 = (-B - Math.Sqrt(delta)) / (2 * A); // calculo do x2

        if (delta <= 0 || A == 0) 
            Console.WriteLine("Impossivel calcular");
        else
        {
            Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");
        }

        // 6 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
        // Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
        // então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
        // inválido’: (use o operador condicional ternário)
        Console.Write("Usuario: ");
        string usuario = Console.ReadLine();
        Console.Write("Senha: ");
        int senha = int.Parse(Console.ReadLine());

        bool loginSuccess = (usuario == "admin" || usuario == "maria" && (senha == 123)) ? true: false;
        if (loginSuccess)
            successLogin("Login feito com sucesso");
        else
            errorLogin("Login invalido");

        // 7 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
        // console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
        Console.Write("Digite o valor de x e y (x y): ");
        int[] inputS = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
        string classificaX = (inputS[0] % 2 == 0) ? "x é Par": "x é Impar";
        string classificaY = (inputS[1] % 2 == 0) ? "y é Par": "y é Impar";
        Console.WriteLine($"{classificaX} e {classificaY}");

        Console.ResetColor();
    }

    static void errorLogin(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
    static void successLogin(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
}