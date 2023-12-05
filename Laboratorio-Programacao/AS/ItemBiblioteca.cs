namespace AS
{
    abstract class ItemBiblioteca
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        protected string DescricaoInterna { get; set; }

        public ItemBiblioteca()
        {}

        public ItemBiblioteca(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            DescricaoInterna = $"Livro: {id}\nTitulo: {Titulo}\n";
        }
    }
}