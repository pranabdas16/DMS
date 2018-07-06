using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmsModelApp
{
   public class EmployeeDto
    {
        public int EmpID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string PrimaryEmail { get; set; }

        public string SecondaryEmail { get; set; }

        public char Gender { get; set; }

        public string AddedByUser { get; set; }

        public DateTime AddedOn { get; set; }

        public string UpdatedByUser { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
