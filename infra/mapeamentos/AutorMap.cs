using bibliotecaNhibernate.Models;
using FluentNHibernate.Mapping;

namespace bibliotecaNhibernate.infra.mapeamentos
{
    public class AutorMap : ClassMap<Autor>
    {
        public AutorMap()
        {
            Schema("biblioteca");
            Table("AUTOR");
            Id(autor => autor.Id).Column("ID");
            Map(autor => autor.Nome).Column("NOME");
            Map(autor => autor.DataNascimento).Column("DATANASCIMENTO");
        }
    }
}