using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDepartmentApp.DLL.DAO;
using StudentDepartmentApp.DLL.GateWay;

namespace StudentDepartmentApp.BLL
{
    public class DepartmentManagerBLL
    {
        private DepartmentGateWay aDepartmentGateWay;

        public DepartmentManagerBLL()
        {
            aDepartmentGateWay = new DepartmentGateWay();
        }

        public List<Department> GetAllDepartment()
        {

            return aDepartmentGateWay.GetAllDepartment();
        }

        public Department GetDepartmentById(int deptId)
        {
            return aDepartmentGateWay.GetDepartmentById(deptId);
        }

        public bool UpdateDepartment(Department aDepartment)
        {
            return aDepartmentGateWay.UpdateDepartment(aDepartment);
        }
    }
}