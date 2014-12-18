using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EmployeeWebApp.Model;

namespace EmployeeWebApp.DLL.GateWay
{
    public class DepartmentGateway
    {
        private SqlConnection aConnection;
        public DepartmentGateway()
        {
            string conn = @"server=WIN-APF1B7L3NAT; database=AspWebDB;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }

        public List<Department> GetAllDepartment()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_department");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Department> departments = new List<Department>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.DepartmentId = (int)aReader[0];
                    aDepartment.DepartmentName = aReader[1].ToString();
                    aDepartment.DepatmentDetails = aReader[2].ToString();
                    departments.Add(aDepartment);
                }
            }
            aConnection.Close();
            return departments;
        }

        public Department GetDepartmentById(int departmentId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_department WHERE id={0}",departmentId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Department> departments = new List<Department>();
            Department aDepartment = null;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aDepartment = new Department();
                    aDepartment.DepartmentId = (int)aReader[0];
                    aDepartment.DepartmentName = aReader[1].ToString();
                    aDepartment.DepatmentDetails = aReader[2].ToString();
                 
                }
            }
            aReader.Close();
            aConnection.Close();
            return aDepartment;
        }

        public bool UpdateDepartment(Department aDepartment)
        {
            aConnection.Open();
            string quary = string.Format("UPDATE t_department SET department_name='{0}',department_details='{1}' WHERE id={2}",aDepartment.DepartmentName,aDepartment.DepatmentDetails,aDepartment.DepartmentId);
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