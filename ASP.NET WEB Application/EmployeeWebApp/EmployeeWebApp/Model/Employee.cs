using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Model
{
    [Serializable]
    public class Employee
    {
        public Employee()
        {
            Department = new Department();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }
    }
}