using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFExample
{
    public class MainDept
    {
        [ForeignKey("Department")]
        [Key]
        public int DeptId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be empty")]
        public String DeptName { get; set; }

        public String DeptLocation { get; set; }

        public string DeptHead { get; set; }
    }
}
