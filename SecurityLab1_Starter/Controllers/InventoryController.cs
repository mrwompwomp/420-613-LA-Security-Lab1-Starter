using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }
        
    }
    public class UserMvcController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            var ex = Server.GetLastError();
            Models.LogUtil lu = new Models.LogUtil();
            lu.LogToEventViewer(System.Diagnostics.EventLogEntryType.Error, "Inventory Error: " + ex.Message);
            lu.LogToFile("Inventory Error: " + ex.Message);
        }
    }
}