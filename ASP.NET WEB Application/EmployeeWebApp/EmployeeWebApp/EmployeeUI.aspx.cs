using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeWebApp.BLL;
using EmployeeWebApp.Model;

namespace EmployeeWebApp
{
    public partial class EmployeeUI : System.Web.UI.Page
    {
        private Employee aEmployee;
        DepartmentManagerBLL aDepartmentManagerBLL = new DepartmentManagerBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = aDepartmentManagerBLL.GetAllDepartment();
                departments.Insert(0,new Department(){DepartmentId = -99,DepartmentName = "Selected Department...."});
                departmentDropDownList.DataSource = departments;
                departmentDropDownList.DataTextField = "DepartmentName";
                departmentDropDownList.DataValueField = "DepartmentId";
                departmentDropDownList.DataBind();
            }
            
        }
        
        protected void saveButton_Click(object sender, EventArgs e)
        {
            EmployeeManagerBLL aEmployeeManagerBll = new EmployeeManagerBLL();
            aEmployee = new Employee();
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.Address = addressTextBox.Text;
            aEmployee.Department.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            aEmployee.Department.DepartmentName = departmentDropDownList.SelectedItem.Text;
            aEmployee.Department.DepatmentDetails = detailsTextBox.Text;
            ViewState["Employee"] = aEmployee;

            bool InsertSuccess = aEmployeeManagerBll.Save(aEmployee);

            if (InsertSuccess)
            {
                employeeMessage.Text = "Insert Successfully";
            }
            else
            {
                employeeMessage.Text = "Not Insert";
            }
            
            ClearText();
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            aEmployee = (Employee)ViewState["Employee"];
            nameTextBox.Text = aEmployee.Name;
            emailTextBox.Text = aEmployee.Email;
            addressTextBox.Text = aEmployee.Address;
            departmentDropDownList.SelectedValue = aEmployee.Department.DepartmentId.ToString();
            detailsTextBox.Text = aEmployee.Department.DepatmentDetails;



        }

        public void ClearText()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            //departmentDropDownList.SelectedItem.Text = "";
            departmentDropDownList.SelectedValue = (-99).ToString();
            detailsTextBox.Text = "";
        }

        protected void departmentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int selectedDepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            Department aDepartment = aDepartmentManagerBLL.GetDepartmentById(selectedDepartmentId);
            if (aDepartment != null)
            {
                detailsTextBox.Text = aDepartment.DepatmentDetails;
            }
            else
            {
                detailsTextBox.Text = "Select Department...";
            }

        }

        protected void editButton_Click(object sender, EventArgs e)
        {
            int deptid = Convert.ToInt32(departmentDropDownList.SelectedValue);
            if (deptid > 0)
            {
                //string url = "~/DepartmentEdit.aspx?deptid="+deptid;
                //Response.Redirect(url);
                Session["deptid"] = deptid;
                string url = "~/DepartmentEdit.aspx";
                Response.Redirect(url);
            }
            else
            {
                employeeMessage.Text = "Can not eidt deparment";
            }
            

        }

        protected void saveStateButton_OnClick(object sender, EventArgs e)
        {
            int deptid = Convert.ToInt32(departmentDropDownList.SelectedValue);
            if (deptid > 0)
            {
                Session["deptid"] = deptid;
                Application["deptid"] = deptid;
            }
            else
            {
                employeeMessage.Text = " Not found";
            }
        }
    }
    
}