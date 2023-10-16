using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TdeBiblioteca
{
    public class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Emprestimo(Usuario usuario, Livro livro)
        {   
            if (livro.Disponivel) 
            {
                Usuario = usuario;
                Livro = livro;
                Livro.Disponivel = false;
                DataEmprestimo = DateTime.Now;
                DataDevolucao = DataEmprestimo.AddDays(7);
            }
            else Console.WriteLine("Livro indisponível");
            
        }

        public void DevolverLivro()
        {
            if (DateTime.Now > DataDevolucao) Console.WriteLine("Empréstimo em atraso.");
            else Livro.Disponivel = true;
        }

        public override string ToString()
        {
            return $"Empréstimo à: {Usuario.Nome}. Livro: {Livro.Titulo}. Devolucao em: {DataDevolucao.ToString("dd MMMM yyyy", new CultureInfo("pt-BR"))}";
        }
    }
}