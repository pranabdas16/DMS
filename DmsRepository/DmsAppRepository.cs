using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsRepository
{
   public class DmsAppRepository<T> : IDmsAppRepository<T> where T : class
    {
        private DmsAppdbContext db = null;
        private IDbSet<T> dbEntity = null;

        public DmsAppRepository()
        {
            this.db = new DmsAppdbContext();
            dbEntity = db.Set<T>();
        }

        public DmsAppRepository(DmsAppdbContext _db)
        {
            this.db = _db;
            dbEntity = db.Set<T>();
        }

        public IEnumerable<T> GetAllData()
        {
            return dbEntity.ToList();
        }

        public T SelectDataById(object id)
        {
            return dbEntity.Find(id);
        }

        public void InsertRecord(T objRecord)
        {
            dbEntity.Add(objRecord);
        }

        public void Update(T objRecord)
        {
            dbEntity.Attach(objRecord);
            db.Entry(objRecord).State = System.Data.Entity.EntityState.Modified;
        }

        public void DeleteRecord(object id)
        {
            T currentRecord = dbEntity.Find(id);
            dbEntity.Remove(currentRecord);
        }

        public void SaveRecord()
        {
            db.SaveChanges();
        }
    }
}
