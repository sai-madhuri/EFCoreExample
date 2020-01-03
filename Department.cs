using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be empty")]
        public string DeptName { get; set; }

        public string DeptLocation { get; set; }

        public string DeptManager { get; set; }
    }
}
