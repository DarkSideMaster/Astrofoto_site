using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AstroFotoWebSite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult HomePage()
        {
            return View("HomePage");
        }
    }
}