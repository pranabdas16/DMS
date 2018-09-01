using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsModelApp;

namespace DmsRepository
{
   public interface IEmployeeGetRepo
   {
       IEnumerable<EmployeeDto> GetEmployeeDetails();
       IEnumerable<EmployeeDto> GetEmployeeDetails(EmployeeDto employee);
   }
}
