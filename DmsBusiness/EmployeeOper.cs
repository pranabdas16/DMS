using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DmsRepository;
using DmsModelApp;
using System.Transactions;
using System.Data.Entity;

namespace DmsBusiness
{
    public class EmployeeOper : IEmployeeOpr
    {
        public void SaveEmployee()
        {
            #region Employee Table addition...

            try
            {
                var employeeinfo = new EmployeeDto()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Dob = new DateTime(1975, 1, 1),
                    Gender = 'M',
                    AddedByUser = "Pranab",
                    AddedOn = new DateTime(2018, 08, 13),
                    UpdatedByUser = "",
                    UpdatedOn = new DateTime(2018, 08, 13),
                    DepId = 111,
                    ProjectId = 111,
                    ProjectRoleId = 111

                };

                EmployeeAddUpdate employeeAdd = new EmployeeAddUpdate();

                employeeAdd.SaveEmployee(employeeinfo);
            }
            catch (Exception ex)
            {

                throw;
            }

            #endregion
        }

        public List<EmployeeDto> GetEmployee()
        {
            EmployeeGetRepo employeeGetRepo = new EmployeeGetRepo();
            var employeeList = employeeGetRepo.GetEmployeeDetails().ToList();

            return employeeList;
        }
    }
}
