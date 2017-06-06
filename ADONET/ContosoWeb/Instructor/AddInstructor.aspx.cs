using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
            

        }
        protected void btnCancel_OnClick(object sender, EventArgs e)
        {


        }
    }
}