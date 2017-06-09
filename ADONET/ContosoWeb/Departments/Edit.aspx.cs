using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;

namespace ContosoWeb.Departments
{
    public partial class Edit : System.Web.UI.Page
    {
        private Departmentervice _departmentervice = new Departmentervice();
        private InstructorService _instructorService = new InstructorService();
        private int _id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _id =Convert.ToInt32(Request.QueryString["departmentId"]);
            Contoso.Models.Department department = _departmentervice.GetDepartmentById(_id);
            if (!Page.IsPostBack)
            {
                txtName.Text = department.Name;
                txtBudget.Text = department.Budget.ToString();
                txtStartDate.Text = department.StartDate.HasValue ? department.StartDate.Value.AddMinutes(1).ToString("mm/dd/yyyy") : DateTime.MinValue.ToString();

                var instructors = _instructorService.GetAllInstructors();
                var dataSouce = instructors.Select(p => new { Id = p.Id, Name = p.FirstName + ' ' +p.LastName}).ToList();
                dataSouce.Insert(0, new{Id = 0, Name = "Please Select"});
              
                ddlInstructor.DataSource = dataSouce;
                ddlInstructor.DataTextField = "Name";
                ddlInstructor.DataValueField = "Id";
                ddlInstructor.SelectedValue = department.InstructorId.HasValue ? department.InstructorId.Value.ToString() : "0";
                ddlInstructor.DataBind();

            }
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            Contoso.Models.Department department = new Contoso.Models.Department();
            department.Id = _id;
            department.InstructorId = Convert.ToInt32(ddlInstructor.SelectedValue);
            department.Budget = Convert.ToInt32(txtBudget.Text);
            department.Name = txtName.Text.ToString();
            department.StartDate = Convert.ToDateTime(txtStartDate.Text);
            
            _departmentervice.UpdateDepartment(department);

            Response.Redirect("Index.aspx");

        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}