using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContosoWeb
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        private string _abc = "Hello ";

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            /*
             The entry point of the page life cycle is the pre-initialization phase called “PreInit”. 
             This is the only event where programmatic access to master pages and themes is allowed. 
             You can dynamically set the values of master pages and themes in this event. 
             You can also dynamically create controls in this event 
             */

            /*
             Check the IsPostBack property to determine whether this is the first time the page is being processed.
             Create or re - create dynamic controls.
             Set a master page dynamically.
             Set the Theme property dynamically.
            */

            var nm = HttpContext.Current.Request["txtName"];
            var lbl = HttpContext.Current.Request["lblResult"];
            var btn = HttpContext.Current.Request["btnSubmit"];
            //  txtName.Text

            if (Page.IsPostBack)
            {
                var test = "fgfdgfdg";
                lblResult.Text = "";
            }
        }

        private void CheckPostBack()
        {
            if (Page.IsPostBack)
            {
                var test = "fgfdgfdg";
                lblResult.Text = "";
            }
        }

        protected override void OnInit(EventArgs e)
        {
            /*Raised after all controls have been initialized and any skin settings have been applied. 
            The Init event of individual controls occurs before the Init event of the page.
            Use this event to read or initialize control properties.
            */

            /*
              This event fires after each control has been initialized, each control's UniqueID is set 
              and any skin settings have been applied.
              You can use this event to change initialization values for controls.
              The “Init” event is fired first for the most bottom control in the hierarchy, 
              and then fired up the hierarchy until it is fired for the page itself.
             * */

            base.OnInit(e);
        }

        protected override void OnInitComplete(EventArgs e)
        {
            /*
             Raised once all initializations of the page and its controls have been completed.
             Till now the viewstate values are not yet loaded, hence you can use this event to make changes to view state 
             that you want to make sure are persisted after the next postback 
              
             */

            base.OnInitComplete(e);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            /*
             * Raised after the page loads view state for itself and all controls,
             *  and after it processes postback data that is included with the Request instance
             */

            // (1)Loads ViewState : ViewState data are loaded to controls
            // (2)Loads Postback data : postback data are now handed to the page controls
            // view state will be loaded after init before load.

            /* Use this event if you need to perform processing on your page or control before the Load event.   
             * Before the Page instance raises this event, it loads view state for itself and all controls, 
             * and then processes any postback data included with the Request instance
            */
            base.OnPreLoad(e);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            var txtname = txtName.Text; 
            TextBox txtTextBox = new TextBox();
            txtTextBox.ID = "id";
            txtTextBox.Text = "text";
            // PlaceHolder
            // // This is just an example of control event.. Here it is button click event that caused the postback
            GetValue();
        }

        private void GetValue()
        {
            if (ViewState["myvalue"] != null)
            {
                _abc = _abc + " " + (string) ViewState["myvalue"] + "  " + txtName.Text;
            }

            lblResult.Text = _abc;
            ViewState["myvalue"] = _abc;
        }

        protected override void OnPreRender(EventArgs e)
        {
            /*
            Allows final changes to the page or its control. This event takes place after all 
            regular PostBack events have taken place.
            This event takes place before saving ViewState, so any changes made here are saved.
            For example : After this event, you cannot change any property of a button or change 
            any viewstate value. 
            Because, after this event, SaveStateComplete and Render events are called
            */

            base.OnPreRender(e);
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            /*
             * Prior to this event the view state for the page and its controls is set.
             *  Any changes to the page’s controls at this point or beyond are ignored
             * */

            // Before this event occurs,  ViewState has been saved for the page and for all controls. 
            // Any changes to the page or controls at this point will be ignored.    
            // Use this event perform tasks that require view state to be saved, but that do not make any changes to controls.
            base.OnSaveStateComplete(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            /*
            This is a method of the page object and its controls (and not an event). 
            At this point, ASP.NET calls this method on each of the page’s controls to get its output.
            The Render method generates the client-side HTML, Dynamic Hypertext Markup Language (DHTML),
            and script that are necessary to properly display a control at the browser
            */

            /*
             Note: Right click on the web page displayed at client's browser and view the Page's Source. 
             You will not find any aspx server control in the code. Because all aspx controls are converted 
             to their respective 
             HTML representation. Browser is capable of displaying HTML and client side scripts.
             * */

            base.Render(writer);
        }

        protected override void OnUnload(EventArgs e)
        {
            /*
              This event is used for cleanup code. After the page's HTML is rendered, the objects are disposed of. 
              During this event, you should destroy any objects or references you have created in building the page. 
              At this point, all processing has occurred and it is safe to dispose of any remaining objects, including the Page object.
              Cleanup can be performed on-  
                   (a)Instances of classes i.e. objects
                   (b)Closing opened files
                   (c)Closing database connections. 
            */
            //During the unload stage, the page and its controls have been rendered, so you cannot make further changes to the response stream. 
            //If you attempt to call a method such as the Response.Write method, the page will throw an exception.       

            base.OnUnload(e);
        }
    }
}