using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoWeb.HelloReference;
using ContosoWeb.HelloWCF;

namespace ContosoWeb
{
    public partial class ConsumeWebPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     
        protected void btnSubstract_OnClick(object sender, EventArgs e)
        {
            var number1 = Convert.ToInt32(txtNumber1.Text);
            var number2 = Convert.ToInt32(txtNumber2.Text);
             HelloWCF.ContosoServiceClient client = new ContosoServiceClient();
            var result = client.Substract(number1, number2);

        }

        protected void btnAddition_OnClick(object sender, EventArgs e)
        {
            var number1 = Convert.ToInt32(txtNumber1.Text);
            var number2 = Convert.ToInt32(txtNumber2.Text);
           HelloWCF.ContosoServiceClient client = new ContosoServiceClient();
            var result = client.Add(number1, number2);
        }

        protected void CallWCFStudent_OnClick(object sender, EventArgs e)
        {
            HelloWCF.ContosoServiceClient client = new ContosoServiceClient();
            var student =  client.GetStudentById(1);
        }
    }
}