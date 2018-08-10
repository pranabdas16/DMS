using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DmsModelApp
{
    [Table("ProjectRoleDto")]
    public class ProjectRoleDto
    {
        [Key]
        public int ProjectRoleId { get; set; }
        public string ProjectRoleName { get; set; }
    }
}
