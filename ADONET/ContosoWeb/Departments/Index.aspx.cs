using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;

namespace ContosoWeb.Departments
{
	public partial class Departments1 : System.Web.UI.Page
	{
        private Departmentervice _departmentervice = new Departmentervice();
		protected void Page_Load(object sender, EventArgs e)
		{
		    if (!IsPostBack)
		    {
		        var departments = _departmentervice.GetAllDepartments();
		        repeaterDepartment.DataSource = departments;
                repeaterDepartment.DataBind();
		    }
            //int a = 1;
            //int b = 0;
            //var c = a / b;
        }

	    protected void repeaterDepartment_OnItemCommand(object source, RepeaterCommandEventArgs e)
	    {
	        if (e.CommandName == "Detail")
	        {
	            var departmentId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("Detail.aspx?departmentId="+ departmentId);
	        }
	        if (e.CommandName == "Edit")
	        {
	            var departmentId = Convert.ToInt32(e.CommandArgument);
	            Response.Redirect("Edit.aspx?departmentId=" + departmentId);
	        }
        }

	    protected void OnClick(object sender, EventArgs e)
	    {
	        Session["key1"] = "value1";
	        Response.Redirect("Add.aspx");
	    }
	}
}