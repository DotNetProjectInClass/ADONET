using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;

namespace ContosoWeb.Departments
{
    public partial class Add : System.Web.UI.Page
    {
        private Departmentervice _departmentervice = new Departmentervice();
        private InstructorService _instructorService = new InstructorService();
        protected void Page_Load(object sender, EventArgs e)
        {
            var value = Session["key1"];
            if (!Page.IsPostBack)
            {
               
                if (!Page.IsPostBack)
                {
                    var instructors = _instructorService.GetAllInstructors();
                    var dataSouce = instructors.Select(p => new { Id = p.Id, Name = p.FirstName + ' ' + p.LastName }).ToList();
                    dataSouce.Insert(0, new { Id = 0, Name = "Please Select" });

                    ddlInstructor.DataSource = dataSouce;
                    ddlInstructor.DataTextField = "Name";
                    ddlInstructor.DataValueField = "Id";
                    ddlInstructor.SelectedValue = "0";
                    ddlInstructor.DataBind();

                }
                ddlInstructor.DataBind();

            }
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            Contoso.Models.Department department = new Contoso.Models.Department();

            department.InstructorId = Convert.ToInt32(ddlInstructor.SelectedValue);
            department.Budget = Convert.ToInt32(txtBudget.Text);
            department.Name = txtName.Text.ToString();
            department.StartDate = Convert.ToDateTime(txtStartDate.Text);

            _departmentervice.CreateDepartment(department);

            Response.Redirect("Index.aspx");
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}