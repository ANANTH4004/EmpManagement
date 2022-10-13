using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpManagement.Models
{
    public class Dept
    {
        [Required]
        public int DeptCode { get; set; }
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string DeptName { get; set; }
        public virtual ICollection<Employee> EmpProfiles { get; set; }
    }
}