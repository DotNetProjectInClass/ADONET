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
		protected void Page_Load(object sender, EventArgs e)
		{
		    var departmentId =Request.QueryString["departmentId"];

		    Contoso.Models.Department department = _departmentervice.GetDepartmentById(Convert.ToInt32(departmentId));
		    txtName.Text = department.Name;

            txtBudget.Text = department.Budget.ToString();

		}
	}
}