using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeList
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }

        public decimal Salary { get; set; }

    }
}
