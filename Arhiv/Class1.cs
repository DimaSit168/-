using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Arhiv;
public static class Configuration
{
    private static FluentConfiguration fluentConfiguration;
   
    private static IsessionFactory GetIsessionFactory(
        Settings settings,
        Assembly assembly = null,//сборка
        bool showSql = false)
    {
        return GetConfiguration();   
    }

    private static FluentConfiguration GetConfiguration(
        Setting setting,
        Assembly assembly,
        bool showSql = false);
}