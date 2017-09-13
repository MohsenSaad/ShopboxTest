
using Sample.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;

namespace Sample.iOS.Services
{
    public class SQLiteConnectionProvider : ISQLiteConnectionProvider
    {
        private SQLiteConnection Connection { get; set; }

        public SQLiteConnection GetConnection()
        {
            if (this.Connection != null ) { return this.Connection; }

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "..", "Library", "database.db3");
            return this.Connection = new SQLiteConnection(path);
        }
    }
}
