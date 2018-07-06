using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsRepository
{
   public interface IDmsAppRepository<T> where T : class
    {
        IEnumerable<T> GetAllData();
        T SelectDataById(object id);
        void InsertRecord(T objRecord);
        void Update(T objRecord);
        void DeleteRecord(object id);
        void SaveRecord();
    }
}
