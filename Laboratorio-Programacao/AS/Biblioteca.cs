using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AS
{
    class Biblioteca
    {
        public List<ItemBiblioteca> Livros = new List<ItemBiblioteca>(); // propriedade que gerencia os Livros


        public void AdicionarItem(ItemBiblioteca item)
        {
            if (item != null) Livros.Add(item);
        }

        public void RemoverItem(int id)
        {
            ItemBiblioteca itemARemover = BuscarItemPorId(id);
            if (itemARemover != null) Livros.Remove(itemARemover);
            else Console.WriteLine("Livro com id" + id + " não encontrado.");
        }

        public void RemoverItem(string titulo)
        {
            ItemBiblioteca itemARemover = BuscarItemPorTitulo(titulo);
            if (itemARemover != null) Livros.Remove(itemARemover);
            else Console.WriteLine("Livro com titulo" + titulo + " não encontrado.");
        }

        public ItemBiblioteca BuscarItemPorId(int id)
        {
            foreach (var livro in Livros)
            {
                if (livro.Id.Equals(id)) return livro;
            }

            return null;
        }

        public ItemBiblioteca BuscarItemPorTitulo(string titulo)
        {
            foreach (var livro in Livros)
            {
                if (livro.Titulo.ToLower().Equals(titulo.ToLower())) return livro;
            }

            return null;
        }


    }
}