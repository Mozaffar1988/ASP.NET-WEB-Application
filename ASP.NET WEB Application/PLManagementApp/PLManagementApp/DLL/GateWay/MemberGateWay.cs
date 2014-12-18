using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PLManagementApp.DLL.GateWay
{
    public class MemberGateWay
    {
        private SqlConnection aConnection;
        public MemberGateWay()
        {
            string conn = @"server=WIN-APF1B7L3NAT; database=PLManagementDB;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }

        public bool FindMemberById(int memberNumber)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_member WHERE number={0}", memberNumber);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool hashRow = aReader.HasRows;
            aConnection.Close();
            return hashRow;
        }

        public bool GetMemberNumber(int memberNumber)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_member WHERE number={0}", memberNumber);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool hashRow = aReader.HasRows;
            aConnection.Close();
            return hashRow;
        }
    }
}