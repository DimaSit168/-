using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Arhiv;
public static class Configuration
{
    private static readonly FluentConfiguration? fluentConfiguration;

    private static ISessionFactory GetSessionFactory(
        Settings settings,
        Assembly? assembly = null, //сборка
        bool showSql = false)
    {
        return GetConfiguration();
    }

    private static ISessionFactory GetConfiguration()
    {
        throw new NotImplementedException();
    }

    private static FluentConfiguration GetConfiguration(
        Settings settings,
        Assembly assembly,
FluentConfiguration fluentConfiguration, bool showSql = false)
    {
        if (fluentConfiguration is null)
        {
            var databaseConfiguration =
                MsSqlConfiguration.MsSql2012.ConnectionString(
                    x => x
                    .Server(settings.GetDatabaseServer())
                    .Database(settings.GetDatabaseName())
                    .TrustedConnection());

            if (showSql)
            {
                databaseConfiguration = databaseConfiguration
                    .ShowSql()
                    .FormatSql();
            }

            fluentConfiguration = Fluently.Configure()
                .Database(databaseConfiguration)
                .Mappings(m => m.FluentMappings.AddFromAssembly(assembly))
                .ExposeConfiguration(BuildSchema);
        }
        return fluentConfiguration;
    }

    private static void BuildSchema(NHibernate.Cfg.Configuration configuration)
    {
        new SchemaExport(configuration).Execute(true, true, false);
    }
}