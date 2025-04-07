using bibliotecaNhibernate.Models;
using FluentNHibernate.Mapping;

namespace bibliotecaNhibernate.infra.mapeamentos
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Schema("biblioteca");
            Table("LIVRO");
            Id(livro => livro.Id).Column("ID");
            Map(livro => livro.Titulo).Column("TITULO");
            Map(livro => livro.AnoPublicacao).Column("ANOPUBLICACAO");
            References(livro => livro.Autor).Column("IDAUTOR");
            References(livro => livro.Editora).Column("IDEDITORA");

        }
    }
}