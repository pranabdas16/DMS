using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsModelApp;

namespace DmsRepository
{
   public class EmployeeAddUpdate : IEmployeeAddUpdate
    {
        public void SaveEmployee()//EmployeeDto objEmployeeDto)
        {
            employeeDto = new EmployeeDto(){
                //EmpID = 1,
                FirstName = "Mirza",
                LastName = "Galib",
                Dob = new DateTime(1756, 1, 1),
                Gender = 'M',
                AddedByUser = "Pranab Das",
                AddedOn = new DateTime(2018, 08, 03),
                UpdatedByUser = "",
                UpdatedOn = new DateTime(2018, 08, 03),
                DepId = 111,
                ProjectId = 111,
                ProjectRoleId = 111
            };
            
           // objEmployeeDto = employeeDto;
            using (var context = new DmsAppdbContext())
            {
                //context.EmmloyeeDtos.Add(objEmployeeDto);
                context.EmmloyeeDtos.Add(employeeDto);
                context.SaveChanges();
            }
        }

        private EmployeeDto employeeDto;
    }
}
