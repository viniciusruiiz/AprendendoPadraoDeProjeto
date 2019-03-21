using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace DAL.Utils
{
    public class DatabaseHelper
    {
        private static ISessionFactory session;

        private static ISessionFactory Session
        {
            get
            {
                if (session is null)
                    InitializeSessionFactory();

                return session;
            }
        }

        private static void InitializeSessionFactory()
        {
            session = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                    //ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString
                    "Server=localhost;Database=master;Trusted_Connection=True;"
                    )
                    .ShowSql()
                    .FormatSql())
                .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return Session.OpenSession();
        } 
    }
}
