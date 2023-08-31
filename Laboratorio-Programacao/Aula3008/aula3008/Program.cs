class Program 
{
    static void Main(string[] args)
    {
        // for (int i = 0; i <= 10; i++)
        // {   
        //     Console.WriteLine($"5 X {i} = {5 * i}");
        // }

        int total = 0;
        for (int i = 1; i <= 10; i++)
        {
            total += i;
        }
        Console.WriteLine(total);

    }
}