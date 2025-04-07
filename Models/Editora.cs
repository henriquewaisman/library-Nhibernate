namespace bibliotecaNhibernate.Models
{
    public class Editora
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string? Cidade { get; set; }
        public virtual IList<Livro> Livros { get; set; }
        public Editora()
        {

        }

        public Editora(string nome, string? cidade = null)
        {
            Nome = nome;
            Cidade = cidade;
        }
    }
}