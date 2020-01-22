using SecurityLab1_Starter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error() {
            Exception exception = Server.GetLastError();
            LogUtil lu = new LogUtil();
            lu.LogToEventViewer(System.Diagnostics.EventLogEntryType.Error, exception.Message);
            lu.LogToFile(exception.Message);
            //redirect
            //System.Diagnostics.Debug.WriteLine(exception);
            //Response.Redirect("Home/Error");
        }
    }
}
