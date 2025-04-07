using bibliotecaNhibernate.Models;
using FluentNHibernate.Mapping;

namespace bibliotecaNhibernate.infra.mapeamentos
{
    public class EditoraMap : ClassMap<Editora>
    {
        public EditoraMap()
        {
            Schema("biblioteca");
            Table("EDITORA");
            Id(editora => editora.Id).Column("ID");
            Map(editora => editora.Nome).Column("NOME");
            Map(editora => editora.Cidade).Column("CIDADE");
            HasMany(editora => editora.Livros).KeyColumn("IDEDITORA");
        }
    }
}