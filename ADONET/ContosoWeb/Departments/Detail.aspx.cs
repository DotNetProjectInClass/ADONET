using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;

namespace ContosoWeb.Departments
{
	public partial class DepartmentDetail1 : System.Web.UI.Page
	{
        private Departmentervice _departmentervice = new Departmentervice();
	    private PeopleService _peopleService = new PeopleService();
        protected void Page_Load(object sender, EventArgs e)
		{
		    var departmentId = Convert.ToInt32(Request.QueryString["departmentId"]);

		    Contoso.Models.Department department = _departmentervice.GetDepartmentById(departmentId);
		    txtName.Text = department.Name;
		    txtInstructor.Text = department.InstructorName;
		    txtCreatedDate.Text = Convert.ToDateTime(department.CreatedDate).ToString("MM/dd/yyyy");
            txtBudget.Text = department.Budget.ToString();
		    if (department.CreatedBy.HasValue)
		    {
		        txtCreatedBy.Text =_peopleService.GetPeopleNameById(department.CreatedBy.Value);
		    }
		    
		    txtStartDate.Text = Convert.ToDateTime(department.StartDate).ToString("MM/dd/yyyy");
		}
	}
}