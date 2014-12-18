using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeWebApp.DLL.GateWay;
using EmployeeWebApp.Model;

namespace EmployeeWebApp.BLL
{
    public class DepartmentManagerBLL
    {
        
        
        private DepartmentGateway aDepartmentGateway;

        public DepartmentManagerBLL()
        {
            aDepartmentGateway = new DepartmentGateway();
        }

        public  List<Department> GetAllDepartment()
        {

          return aDepartmentGateway.GetAllDepartment();
        }

        public Department GetDepartmentById(int deptId)
        {
            return aDepartmentGateway.GetDepartmentById(deptId);
        }

        public bool UpdateDepartment(Department aDepartment)
        {
            return aDepartmentGateway.UpdateDepartment(aDepartment);
        }
    }
}