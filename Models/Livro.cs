namespace bibliotecaNhibernate.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        
        public Livro()
        {

        }

        public Livro(string titulo, int anoPublicacao, Autor autor, Editora editora)
        {
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Autor = autor;
            Editora = editora;
        }
    }
}