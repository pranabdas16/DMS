using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DmsModelApp;
using System.Data.Entity;


namespace DmsRepository
{
   public class EmployeeGetRepo
    {
        public IEnumerable<EmployeeDto> GetEmployeeDetails()
        {
            
            using (var context = new DmsAppdbContext())
            {
               var employees = context.EmmloyeeDtos.ToList();
               return employees;
            }
        }

        public IEnumerable<EmployeeDto> GetEmployeeDetails(EmployeeDto employee)
        {
            using (var context = new DmsAppdbContext())
            {
                var employees = (from a in context.EmmloyeeDtos where a.EmpID == employee.EmpID select a).ToList();
                return employees;
            }
        }
    }
}
