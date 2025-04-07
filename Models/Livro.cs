namespace bibliotecaNhibernate.Models
{
    public class Livro
    {
        public virtual int Id { get; set; }
        public virtual string Titulo { get; set; }
        public virtual int AnoPublicacao { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual Editora Editora { get; set; }
        
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