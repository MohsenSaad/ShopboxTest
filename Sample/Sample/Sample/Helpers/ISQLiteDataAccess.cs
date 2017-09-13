using Sample.SQLiteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Helpers
{
   public interface ISQLiteDataAccess
    {
        IEnumerable<Employe> GetAll();
        Employe GetByID(int Id);
        void Update(Employe emp);
        void Insert(Employe emp);
        void Delete(int Id);

    }
}
