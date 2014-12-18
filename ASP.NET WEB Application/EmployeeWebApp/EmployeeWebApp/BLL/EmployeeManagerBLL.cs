using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeWebApp.DLL.GateWay;
using EmployeeWebApp.Model;

namespace EmployeeWebApp.BLL
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
            return aEmployeeGateWay.SaveEmployee(aEmployee);
        }
    }
}