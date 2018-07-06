using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DmsModelApp;

namespace DmsRepository
{
   public class DmsAppdbContext : DbContext
    {
        public DmsAppdbContext() : base("DmsApp.DbConnection")
        {
            //Database.SetInitializer<DmsAppdbContext>(new DmsAppInitializer());
            //Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<EmployeeDto> EmmloyeeDto { get; set; }

    }
}
