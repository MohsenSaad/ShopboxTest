using Sample.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Windows.Storage;

namespace Sample.UWP.Services
{
    public class SQLiteConnectionProvider : ISQLiteConnectionProvider
    {
        private SQLiteConnection Connection { get; set; }
        public SQLiteConnection GetConnection()
        {
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, "database.db3");
            return this.Connection = new SQLiteConnection(path);
        }
    }
}
