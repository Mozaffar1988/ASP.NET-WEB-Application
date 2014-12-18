using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentDepartmentApp.BLL;
using StudentDepartmentApp.DLL.DAO;

namespace StudentDepartmentApp.UI
{
    public partial class DepartmentEdit : System.Web.UI.Page
    {
        DepartmentManagerBLL aDepartmentManagerBll = new DepartmentManagerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
              updateMessage.Text = "";
              if (!IsPostBack)
              {
                  if (Request.QueryString["deptid"] != null)
                  {
                      int departmentId = Convert.ToInt32(Request.QueryString["deptid"]);
                      LoadDepartment(departmentId);
                  }
                  else if (Session["deptid"] != null)
                  {
                      int departmentId = Convert.ToInt32(Session["deptid"]);
                      LoadDepartment(departmentId);
                  }
                  else if (Application["deptid"] != null)
                  {
                      int departmentId = Convert.ToInt32(Application["deptid"]);
                      LoadDepartment(departmentId);
                  }
              }
        }
        private void LoadDepartment(int departmentId)
        {
            Department aDepartment = aDepartmentManagerBll.GetDepartmentById(departmentId);
            editNameTextBox.Text = aDepartment.DepartmentName;
            editDtailsTextBox.Text = aDepartment.DepatmentDetails;
            deptIdLabel.Text = aDepartment.DepartmentId.ToString();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.DepartmentId = Convert.ToInt32(deptIdLabel.Text);
            aDepartment.DepartmentName = editNameTextBox.Text;
            aDepartment.DepatmentDetails = editDtailsTextBox.Text;
            bool UpdateSuccess = aDepartmentManagerBll.UpdateDepartment(aDepartment);
            if (UpdateSuccess)
            {
                updateMessage.Text = "Update Success";
            }
            else
            {
                updateMessage.Text = "Update Failed";
            }
        }
    }
}