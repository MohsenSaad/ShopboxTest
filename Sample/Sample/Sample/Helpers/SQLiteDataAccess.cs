using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.SQLiteModel;
using SQLite;

namespace Sample.Helpers
{
    public class SQLiteDataAccess : ISQLiteDataAccess
    {
        ISQLiteConnectionProvider ConnectionProvider { get; }
        SQLiteConnection Connection { get; }

        public SQLiteDataAccess(ISQLiteConnectionProvider ConnectionProvider)
        {
            this.ConnectionProvider = ConnectionProvider;
            this.Connection = this.ConnectionProvider.GetConnection();
            this.Connection.CreateTable<Employe>();
        }

        public void Delete(int Id)
        {
            this.Connection.Delete<Employe>(Id);
        }

        public IEnumerable<Employe> GetAll()
        {
            return this.Connection.Table<Employe>().ToList();
        }

        public Employe GetByID(int Id)
        {
            return this.Connection.Table<Employe>().FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(Employe emp)
        {
            this.Connection.Insert(emp);
        }

        public void Update(Employe emp)
        {
            this.Connection.Update(emp);
        }
    }
}
