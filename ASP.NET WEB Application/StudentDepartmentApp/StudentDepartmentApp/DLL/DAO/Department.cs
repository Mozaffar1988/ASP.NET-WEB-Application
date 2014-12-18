using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDepartmentApp.DLL.DAO
{
    [Serializable]
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepatmentDetails { get; set; }
    }
}