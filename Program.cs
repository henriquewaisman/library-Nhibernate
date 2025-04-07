using bibliotecaNhibernate.infra;
using bibliotecaNhibernate.Models;
using NHibernate;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializa interfaces do Nhibernate
            ISession session = HibernateUtil.getSession();
            ITransaction transaction = session.BeginTransaction();
            IQueryable<Livro> query = session.Query<Livro>();

            // Instancia autores
            Autor autor = new Autor("Machado de Assis", new DateTime(1839, 06, 21));
            Autor autor1 = new Autor("Clarice Lispector");

            // Instancia editoras 
            Editora editora = new Editora("Companhia das Letras", "São Paulo");
            Editora editora1 = new Editora("Editora Rocco", "Rio de Janeiro");

            // Insere autores e editoras no banco
            session.Save(autor);
            session.Save(autor1);
            session.Save(editora);
            session.Save(editora1);

            // Recupera autores por id
            Autor getAutor = session.Get<Autor>(1);
            Autor getAutor1 = session.Get<Autor>(2);
            
            // Recupera editoras por id
            Editora getEditora = session.Get<Editora>(1);
            Editora getEditora1 = session.Get<Editora>(2);

            // Instancia livros do autor 1 e editora 1
            Livro livro = new Livro("Memórias Póstumas de Brás Cubas", 1881, getAutor, getEditora);
            Livro livro1 = new Livro("Dom Casmurro", 1889, getAutor, getEditora);
            Livro livro2 = new Livro("A Cartomante", 1884, getAutor, getEditora);

            // Instancia livros do autor 2 e editora 2
            Livro livro3 = new Livro("Água Viva", 1973, getAutor1, getEditora1);
            Livro livro4 = new Livro("Um Sopro de Vida", 1978, getAutor1, getEditora1);
            Livro livro5 = new Livro("A Hora da Estrela", 1977, getAutor1, getEditora1);

            // Insere livros no banco
            session.Save(livro);
            session.Save(livro1);
            session.Save(livro2);
            session.Save(livro3);
            session.Save(livro4);
            session.Save(livro5);

            // Pesquisa livros do autor "Machado de Assis"
            query = query.Where(l => l.Autor.Nome ==  "Machado de Assis");
            IList<Livro> livros = query.ToList();

            foreach(var l in livros)
            {
                Console.WriteLine($"{l.Titulo} - {l.Autor.Nome}");
            }


            // Pesquisa livros da Editora Rocco
            query = query.Where(l => l.Editora.Nome == "Editora Rocco");
            IList<Livro> editoras = query.ToList();

            Console.WriteLine($"Livros da Editora Rocco");
            foreach(var l in editoras)
            {
                Console.WriteLine($"{l.Titulo} - {l.Autor.Nome}");
            }

            // Pesquisa nome dos autoras nascidos antes de 1900
            DateTime cutoff = new DateTime(1900, 1, 1);
            var autores = query
                .Where(l => l.Autor.DataNascimento < cutoff)
                .Select(l => l.Autor)
                .Distinct()
                .ToList();

            foreach(var l in autores)
            {
                Console.WriteLine($"{l.Nome}");
            };

            // Commita transações
            transaction.Commit();
        }
    }
}