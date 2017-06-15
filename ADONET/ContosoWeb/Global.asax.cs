using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using log4net;
using log4net.Appender;
using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "log4net", Watch = true)]

namespace ContosoWeb
{
    public class Global : HttpApplication
    {
        
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            log4net.Config.XmlConfigurator.Configure();


        }
        void Application_Error(object sender, EventArgs e)
        {
            
                       
            // get the exception object
            var exception = Server.GetLastError();
            log.Info("Info logging");
            log.Debug("Debug logging");
            log.Error("Error logging");
            log.Fatal("Fatal logging");
            log.Error("erorr", exception);
            AdoNetAppender adoNetAppender = new AdoNetAppender();
           log.Fatal("fatal??");
            // log the exception using any logging framework like log4net
            // send an email, notify development team and system admins
            // clear the error from the server
            Server.ClearError();


            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //smtpClient.EnableSsl = true;
            //smtpClient.Timeout = 10000;
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new System.Net.NetworkCredential("my email", "password");
            
           
            
          
            //MailMessage mail = new MailMessage("sending mail", "to mail");
            //mail.Body = exception.ToString();
            //mail.BodyEncoding = Encoding.UTF8;
            //mail.Subject = "Exceptions occurred!";
            //mail.SubjectEncoding = Encoding.UTF8;

            //smtpClient.Send(mail);
        }
        void Session_Start(object sender, EventArgs e)
        {
           
        }
        void Session_End(object sender, EventArgs e)
        {
            
        }
    }
}