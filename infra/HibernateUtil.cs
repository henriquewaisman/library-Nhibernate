using bibliotecaNhibernate.infra.mapeamentos;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace bibliotecaNhibernate.infra
{
    public class HibernateUtil
    {
        public static ISessionFactory sessionFactory;
        
        public static ISession getSession()
        {
            sessionFactory = Fluently.Configure().Database(
                MySQLConfiguration.Standard.ConnectionString("Server=localhost;Port=3306;Database=biblioteca;Uid=root;Pwd=")
                .ShowSql()
                .FormatSql())
                .Mappings(m => { 
                    m.FluentMappings.AddFromAssemblyOf<LivroMap>();
                })
                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}