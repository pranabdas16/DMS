using System;
using DmsRepository;
using DmsModelApp;
using System.Transactions;
using System.Data.Entity;

namespace DmsBusineesOperations
{
    public class EmployeeOper
    {
        public void SaveEmployee()
        {
            #region Employee Table addition...

            try
            {
                var employeeinfo = new EmployeeDto()
            {
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

                using (var context = new DmsAppdbContext())
                {
                    context.EmmloyeeDtos.Add(employeeinfo);
                    context.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw;
            }

            #endregion
        }
    }
}
