using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AstroFotoWebSite.Controllers
{
    public class MySetupController : Controller
    {
        // GET: MySetup
        [HttpGet]
        public ActionResult MySetupView()
        {
            return View("MySetupView");
        }
    }
}