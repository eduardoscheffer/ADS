/*
Exercício: Sistema de Biblioteca
Contexto
Uma biblioteca deseja criar um sistema simples para gerenciar livros e empréstimos. O objetivo é criar classes e objetos que permitam representar os livros e os empréstimos feitos.
Requisitos
Classe Livro
Atributos: titulo (string), autor (string), anoPublicacao (int), disponivel (bool).
Classe Usuario
Atributos: nome (string), endereco (string), telefone (string).
Classe Emprestimo
Atributos: usuario (Usuario), livro (Livro), dataEmprestimo (DateTime), dataDevolucao (DateTime).
Orientações
Crie instâncias dos objetos de Livro, Usuario e Emprestimo, e atribua valores aos seus atributos.
Verifique a consistência dos dados criando cenários, por exemplo: se um livro está emprestado, seu atributo disponivel deve ser false; se o livro está disponível, true.
Considere a lógica para verificar se um empréstimo não ultrapassa a data de devolução.
Desafio
Como extensão do exercício, explore maneiras de gerenciar múltiplos empréstimos e a disponibilidade dos livros sem o uso de métodos (lembrando que, sem métodos, você não poderá alterar diretamente o estado dos objetos em tempo de execução). Pense em como você pode organizar seus objetos e estados iniciais para simular um pequeno sistema de biblioteca.
*/

namespace TdeBiblioteca;

internal class Program
{
    static void Main(string[] args)
    {

        try
        {
            Usuario usuario1 = new Usuario("João", "Rua das Flores 123", "123-456-7890");
            Usuario usuario2 = new Usuario("Maria", "Avenida Principal 456", "987-654-3210");
    
            Livro livro1 = new Livro("Aventuras de Sherlock Holmes", "Arthur Conan Doyle", 1892);
            Livro livro2 = new Livro("O Hobbit", "J.R.R. Tolkien", 1937);
    
            Emprestimo emprestimo1 = new(usuario1, livro1);
            Console.WriteLine(emprestimo1); // Empréstimo: Usuario: João. Livro: Aventuras de Sherlock Holmes. Devolucao em: 23 outubro 2023

            Emprestimo emprestimo2 = new(usuario1, livro1); // Livro indisponível

            emprestimo1.DevolverLivro();

            Emprestimo emprestimo3 = new(usuario2, livro1);
            Console.WriteLine(emprestimo3); // Empréstimo à: Maria. Livro: Aventuras de Sherlock Holmes. Devolucao em: 23 outubro 2023
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }

    }
}