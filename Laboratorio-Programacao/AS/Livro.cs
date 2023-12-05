using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS
{
    class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }

        public Livro(int id, string titulo, string autor) : base(id, titulo)
        {
            Autor = autor;
            DescricaoInterna += "Autor: " + Autor;
        }

        public void ExibirDescricaoInterna()
        {
            Console.WriteLine("Descrição interna: \n" + DescricaoInterna);
        }
    }
}