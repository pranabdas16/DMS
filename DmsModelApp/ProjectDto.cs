using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DmsModelApp
{
    
   public class ProjectDto
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
       
    }
}
