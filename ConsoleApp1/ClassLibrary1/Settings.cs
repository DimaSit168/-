using System;

///<summary>
///описние класса
/// </summary>

namespace ClassLibrary
{
    public sealed class Settings
    {
        private string databaseServerName;

        private string databaseName;

        public void AddDabaseServer(string serverName)
        {
            this.databaseServerName = serverName;
        }

        public string GetDatabaseServer()
        {
            return this.databaseServerName;
        }

        public void AddDatabase(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public string GetDatabaseName()
        {
            return this.databaseName;
        }

        public void AddDatabaseServer(string v)
        {
            throw new NotImplementedException();
        }
    }
}