using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DmsModelApp
{
    [Table("DepartmentDto")]
    public class DepartmentDto
    {
        [Key]
        public int DepId { get; set; }

        public string DepName { get; set; }
    }
}
