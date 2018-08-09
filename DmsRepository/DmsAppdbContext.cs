using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DmsModelApp;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace DmsRepository
{
   public class DmsAppdbContext : DbContext
    {
        public DmsAppdbContext() : base("DmsApp.DbConnection")
        {
            Database.SetInitializer<DmsAppdbContext>(
                null
                );

            // This below line for initialize the database.....
            //Database.SetInitializer(new NullDatabaseInitializer<DmsAppdbContext>());
            //Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<EmployeeDto> EmmloyeeDtos { get; set; }
        public DbSet<DepartmentDto> DepartmentDtos { get; set; }
        public DbSet<ProjectDto> ProjectDtos { get; set; }
        public DbSet<ProjectRoleDto> RoleDtos { get; set; }
    }

    
}
