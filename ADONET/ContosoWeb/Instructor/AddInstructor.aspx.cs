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
    public partial class AddInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlState.DataSource = Utility.GetAllStates();
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateName";
                ddlState.DataBind();
            }
        }
        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            var instructor = new Contoso.Models.Instructor()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
               Email = txtEmail.Text,
               Phone = txtPhone.Text,
               State = ddlState.SelectedValue,
               SSN = txtSSN.Text,
                HireDate = Convert.ToDateTime(txtHireDate.Text),
                Salary = Convert.ToDouble(txtSalary.Text),
                CreatedBy = 1,
                CreatedDate = DateTime.Now
            };
           InstructorService instructorService = new InstructorService();
           instructorService.SaveInstructor(instructor);


        }
        protected void btnCancel_OnClick(object sender, EventArgs e)
        {


        }
    }
}