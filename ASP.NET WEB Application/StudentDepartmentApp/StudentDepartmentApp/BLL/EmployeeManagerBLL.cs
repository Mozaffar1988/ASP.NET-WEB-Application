using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentDepartmentApp.DLL.DAO;
using StudentDepartmentApp.DLL.GateWay;

namespace StudentDepartmentApp.BLL
{
    public class EmployeeManagerBLL
    {
        private EmployeeGateWay aEmployeeGateWay;

        public EmployeeManagerBLL()
        {
            aEmployeeGateWay = new EmployeeGateWay();
        }

        public bool Save(Employee aEmployee)
        {
            //if (aEmployee.Name == "" || aEmployee.Email == "" || aEmployee.Address == "" ||
            //    aEmployee.Department.DepartmentName == "" || aEmployee.Department.DepatmentDetails == "")
            //{
            //    string info = "";
            //    if (aEmployee.Name == "")
            //    {
            //        info += "Employee Name Missing\n";
            //    }
                
            //    if (aEmployee.Email == "")
            //    {
            //        info += "Employee Email Missing\n";
            //    }
            //    if (aEmployee.Address == "")
            //    {
            //        info += "Employee Address Missing\n";
            //    }
            //    if (aEmployee.Department.DepartmentName == "")
            //    {
            //        info += "Employee Department Name Missing\n";
            //    }
            //    return info;
            //}
            return aEmployeeGateWay.SaveEmployee(aEmployee);
        }
    }
}