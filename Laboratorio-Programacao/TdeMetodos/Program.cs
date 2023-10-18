using System;

namespace TdeMetodos 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(09, 09, 1997);
            data.ImprimirDataFormatada(); // terça-feira, 9 de setembro de 1997

            var tabuada = new Tabuada(3);
            tabuada.ImprimirTabuada();
        }
    }
}