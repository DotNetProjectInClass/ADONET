using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;
namespace ContosoWeb.Instructor
{
	public partial class Instructors1 : System.Web.UI.Page
	{
        private InstructorService _instructorService = new InstructorService();
        protected void Page_Load(object sender, EventArgs e)
		{
            
		    if (!IsPostBack)
		    {
		        var departments = _instructorService.GetAllInstructors();
		        repeaterInstructor.DataSource = departments;
		        repeaterInstructor.DataBind();
		    }
        }

	    protected void OnClick(object sender, EventArgs e)
	    {
	       Response.Redirect("Add.aspx");
	    }

	    protected void repeaterInstructor_OnItemCommand(object source, RepeaterCommandEventArgs e)
	    {
	        if (e.CommandName == "Detail")
	        {
	            var instructorId = Convert.ToInt32(e.CommandArgument);
	            Response.Redirect("Detail.aspx?instructorId=" + instructorId);
	        }
	        if (e.CommandName == "Edit")
	        {
	            var instructorId = Convert.ToInt32(e.CommandArgument);
	            Response.Redirect("Edit.aspx?instructorId=" + instructorId);
	        }
        }
	}
}