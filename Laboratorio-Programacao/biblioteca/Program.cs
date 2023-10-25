using biblioteca;

Livro livro1 = new Livro();
livro1.titulo = "Codigo da Vinci";
livro1.autor = "Dan Brown";
livro1.status = true;

Livro livro2 = new Livro();
livro2.titulo = "Inferno";
livro2.autor = "Dan Brown";
livro2.status = true;

Livro livro3 = new Livro();
livro3.titulo = "1984";
livro3.autor = "George Orwell";
livro3.status = false;

Biblioteca biblioteca = new Biblioteca();
biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);
biblioteca.AdicionarLivro(livro3);

int livrosDisponiveis = biblioteca.QtdLivrosDisponiveis();

Console.WriteLine("Livros disponiveis: " + livrosDisponiveis);

Livro livroEncontrado = new Livro();
livroEncontrado = biblioteca.BuscarPeloTitulo("1984");

if (livroEncontrado != null)
{
    Console.WriteLine("Titulo do livro encontrado: " + livroEncontrado.autor);
}

Console.WriteLine(livro3 == livroEncontrado);