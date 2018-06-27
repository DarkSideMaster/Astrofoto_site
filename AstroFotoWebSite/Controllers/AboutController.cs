using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AstroFotoWebSite.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult AboutView()
        {
            return View();
        }
    }
}