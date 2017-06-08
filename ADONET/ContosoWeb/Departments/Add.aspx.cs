using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoWeb.Department;
using Contoso.Models;
using ContosoService;

namespace ContosoWeb.Department
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_OnClick(object sender, EventArgs e)
        {
            var department = new Contoso.Models.Department()
            {
                Name = txtName.Text,
                Budget = Convert.ToInt32(txtBudget.Text),
                InstructorId = Convert.ToInt32(txtInstructorId.Text),
                StartDate = DateTime.Now,
                UpdatedBy = 1,
                UpdatedDate = DateTime.Now,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                RowVersion = 2
            };
            Departmentervice Departmentervice = new Departmentervice();
            Departmentervice.SaveDepartment(department);

        }
    }
}