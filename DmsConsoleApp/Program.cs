using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsRepository;
using DmsModelApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace DmsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!.....");
            //DmsAppRepository<EmployeeDto> obj = new DmsAppRepository<EmployeeDto>();
            //var list = obj.GetAllData();
            #region Employee Table addition...
            try
            {
                //var Employeeinfo = new EmployeeDto()
                //{
                //    EmpID = 1,
                //    FirstName = "Bill",
                //    LastName = "Smith",
                //    Dob = new DateTime(1980, 1, 1),
                //    Gender = 'M',
                //    AddedByUser = "Pranab Das",
                //    AddedOn = new DateTime(2018, 08, 03),
                //    UpdatedByUser = "",
                //    UpdatedOn = new DateTime(2018, 08, 03),
                //    DepId = 111,
                //    ProjectId = 111,
                //    ProjectRoleId = 111

                //};

                //using (var context = new DmsAppdbContext())
                //{
                //    context.EmmloyeeDtos.Add(Employeeinfo);
                //    context.SaveChanges();
                //}

                var DepInfo = new DepartmentDto()
                {
                  //  DepId = 112,
                    DepName = "Next 1 Blah Blah"
                };
                using (TransactionScope scope = new TransactionScope())
                {


                    using (var context = new DmsAppdbContext())
                    {
                        context.Database.Log = Console.WriteLine;

                        context.DepartmentDtos.Add(DepInfo);
                        context.SaveChanges();

                        Console.WriteLine("Data saved...");
                     
                    }
                    scope.Complete();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
      
            #endregion

            Console.WriteLine("End of code....");
            Console.ReadKey();
        }


    }
}
