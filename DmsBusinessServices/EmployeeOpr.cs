using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsRepository;
using DmsModelApp;
using System.Transactions;

namespace DmsBusinessServices
{
   public class EmployeeOpr
    {

        EmployeeDto Employeeinfo = new EmployeeDto()
        {
            EmpID = 1,
            FirstName = "Bill",
            LastName = "Smith",
            Dob = new DateTime(1980, 1, 1),
            Gender = 'M',
            AddedByUser = "Pranab Das",
            AddedOn = new DateTime(2018, 08, 03),
            UpdatedByUser = "",
            UpdatedOn = new DateTime(2018, 08, 03),
            DepId = 111,
            ProjectId = 111,
            ProjectRoleId = 111

        };

        context.

         DmsAppdbContext context = new DmsAppdbContext()
       

        }
 }

