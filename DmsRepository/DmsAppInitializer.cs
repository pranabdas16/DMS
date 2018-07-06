using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsModelApp;

namespace DmsRepository
{
    /// <summary>
    /// Need to delete this class since we do not need this. Cause this is required when we need to add data into the db.
    /// </summary>
   public class DmsAppInitializer //: CreateDatabaseIfNotExists<socialclubdbcontext>
    {
        protected void Seed(DmsAppdbContext context)
        {
            var clubMembers = new List<EmployeeDto>{
            new EmployeeDto {
                EmpID = 12,
                FirstName = "Pranab",
                LastName = "Das"
                
            },
            new EmployeeDto {
               EmpID = 12,
                FirstName = "Pranab",
                LastName = "Das"
            }
        };

            clubMembers.ForEach(category => context.EmmloyeeDto.Add(category));
        }
    }
}
