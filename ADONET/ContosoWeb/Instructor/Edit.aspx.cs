using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;

namespace ContosoWeb.Instructor
{

    public partial class Edit : System.Web.UI.Page
    {
        private InstructorService _instructorService = new InstructorService();
        private int _id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(Request.QueryString["departmentId"]);
            var instructors = _instructorService;

        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnCancel_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}