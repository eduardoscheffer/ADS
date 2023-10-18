using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Exercício 6: Classe Data
// Classe: Data
// Atributos: dia, mes, ano
// Método: ImprimirDataFormatada()
// Descrição: Crie um método que imprima a data formatada armazenada nos atributos.

namespace TdeMetodos
{
    public class Data
    {
        public Data(int dia, int mes, int ano) 
        {
            this.Dia = dia;
            this.Mes = mes;
            this.Ano = ano;
        }

        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public void ImprimirDataFormatada()
        {
            var data = new DateTime(Ano, Mes, Dia);
            Console.WriteLine(data.ToString("D"));
        }
        
    }
}