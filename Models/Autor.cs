namespace bibliotecaNhibernate.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento{ get; set; }

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