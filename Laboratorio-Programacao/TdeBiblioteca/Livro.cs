using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TdeBiblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; set; }

        public Livro (string titulo, string autor, int anoPublicacao) 
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPublicacao = anoPublicacao;
            this.Disponivel = true;
        }

        public Livro() {}

        public override string ToString()
        {
            string disponibilidade = Disponivel ? "Disponível" : "Indisponível";
            return $"Título: {Titulo}\nAutor: {Autor}\nAno de Publicação: {AnoPublicacao}\nDisponibilidade: {disponibilidade}";
        }
    }
}