using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DmsRepository;
using DmsModelApp;
using System.Transactions;

namespace DmsConsoleApp
{
    class Program 
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!.....");

            //Employee add update through Repository...

            #region Employee adding and updating through Repository....


            EmployeeAddUpdate obj = new EmployeeAddUpdate();


            obj.SaveEmployee();

            Console.WriteLine("Data save through repository...");
            #endregion

            //Below is working code commenting to have some new code added...
            #region Employee Table addition...
            //try
            //{
            //    var Employeeinfo = new EmployeeDto()
            //    {
            //        EmpID = 1,
            //        FirstName = "Bill",
            //        LastName = "Smith",
            //        Dob = new DateTime(1980, 1, 1),
            //        Gender = 'M',
            //        AddedByUser = "Pranab Das",
            //        AddedOn = new DateTime(2018, 08, 03),
            //        UpdatedByUser = "",
            //        UpdatedOn = new DateTime(2018, 08, 03),
            //        DepId = 111,
            //        ProjectId = 111,
            //        ProjectRoleId = 111

            //    };

            //    //using (var context = new DmsAppdbContext())
            //    //{
            //    //    context.EmmloyeeDtos.Add(Employeeinfo);
            //    //    context.SaveChanges();
            //    //}

            //    var DepInfo = new DepartmentDto()
            //    {
            //      //  DepId = 112,
            //        DepName = "This is my Next1 Blah Blah"
            //    };
            //    var ProjInfo = new ProjectDto()
            //    {
            //        ProjectId = 112,
            //        ProjectName = "This is Project1 Blah"
            //    };
            //    var ProjRoleInfo = new ProjectRoleDto()
            //    {
            //        ProjectRoleId =  112,
            //        ProjectRoleName =  "This is Project Role1 Blah"
            //    };
            //    using (TransactionScope scope = new TransactionScope())
            //    {


            //        using (var context = new DmsAppdbContext())
            //        {
            //            context.Database.Log = Console.WriteLine;

            //            context.DepartmentDtos.Add(DepInfo);
            //            context.ProjectDtos.Add(ProjInfo);
            //            context.ProjectRoleDtos.Add(ProjRoleInfo);
            //            context.EmmloyeeDtos.Add(Employeeinfo);
            //            context.SaveChanges();

            //            Console.WriteLine("Data saved...");

            //        }

            //        scope.Complete();
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            #endregion

            Console.WriteLine("End of code....");
            Console.ReadKey();
        }
       ///
       // might need to remove...
       /// 
        
      //public  void AddEmployee(IEmployeeAddUpdate empAdd)
      //  {
      //      var employeeDetail = new EmployeeDto()
      //      {
      //          EmpID = 1,
      //          FirstName = "Mirza",
      //          LastName = "Galib",
      //          Dob = new DateTime(1756, 1, 1),
      //          Gender = 'M',
      //          AddedByUser = "Pranab Das",
      //          AddedOn = new DateTime(2018, 08, 03),
      //          UpdatedByUser = "",
      //          UpdatedOn = new DateTime(2018, 08, 03),
      //          DepId = 111,
      //          ProjectId = 111,
      //          ProjectRoleId = 111

      //      };
      //      empAdd.SaveEmployee(employeeDetail);
      //  }
    }
}
