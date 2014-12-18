using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Model
{
    [Serializable]
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepatmentDetails { get; set; }

    }
}