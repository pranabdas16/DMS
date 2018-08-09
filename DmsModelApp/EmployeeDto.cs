using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DmsModelApp
{
   public class EmployeeDto
    {
        [Key]
        public int EmpID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? Dob { get; set; }

        public string PrimaryEmail { get; set; }

        public string SecondaryEmail { get; set; }

        public char Gender { get; set; }

        public string AddedByUser { get; set; }

        public DateTime? AddedOn { get; set; }

        public string UpdatedByUser { get; set; }

        public DateTime? UpdatedOn { get; set; }

       //public DepartmentDto Department { get; set; }

        public int DepId { get; set; }

       // public List<ProjectDto> ProjectInfo { get; set; }

        public int ProjectId { get; set; }

       // public List<ProjectRoleDto> ProjectRoleDtos { get; set; }

        public int ProjectRoleId { get; set; }
    }
    
}
