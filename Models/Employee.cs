using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XyzOfficeEmployeeTracker.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }
        public string Name { get; set; }
        public int deptId { get; set; }
        public string deptName { get; set; }
        public int salary { get; set; }
    }
}
