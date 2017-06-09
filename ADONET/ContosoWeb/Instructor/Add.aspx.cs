using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;
using ContosoUtility;

namespace ContosoWeb.Instructor
{
    public partial class Add : System.Web.UI.Page
    {
        private InstructorService _instructorService = new InstructorService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlState.DataSource = Utility.GetAllStates();
                ddlState.DataValueField = "Value";
                ddlState.DataTextField = "StateName";
                ddlState.DataBind();
            }
        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            var instructor = new Contoso.Models.Instructor()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                MiddleName = txtMiddleName.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                Email = txtEmail.Text,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Phone = txtPhone.Text,
                State = ddlState.SelectedValue,
                SSN = txtSSN.Text,
                HireDate = Convert.ToDateTime(txtHireDate.Text),
                Salary = Convert.ToDouble(txtSalary.Text)

            };
            int id = _instructorService.CreateInstructor(instructor);
            Response.Redirect("Index.aspx");
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}