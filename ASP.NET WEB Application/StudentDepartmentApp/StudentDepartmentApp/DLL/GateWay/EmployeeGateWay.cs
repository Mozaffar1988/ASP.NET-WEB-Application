using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentDepartmentApp.DLL.DAO;

namespace StudentDepartmentApp.DLL.GateWay
{
    public class EmployeeGateWay
    {
        private SqlConnection aConnection;
        public EmployeeGateWay()
        {
            string conn = @"server=WIN-APF1B7L3NAT; database=StuDepWebDB;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }

        public bool SaveEmployee(Employee aEmployee)
        {
            aConnection.Open();
            string quary = string.Format("INSERT INTO t_employee VALUES ('{0}','{1}','{2}',{3})", aEmployee.Name, aEmployee.Email, aEmployee.Address, aEmployee.Department.DepartmentId);
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}