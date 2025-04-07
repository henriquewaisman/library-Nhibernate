namespace bibliotecaNhibernate.Models
{
    public class Autor
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual DateTime? DataNascimento{ get; set; }
        public virtual IList<Livro> Livros { get; set; }
        public Autor()
        {

        }
        public Autor(string nome, DateTime? dataNascimento = null)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
}