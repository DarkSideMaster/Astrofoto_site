using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AstroFotoWebSite.Controllers
{
    public class ObjectController : Controller
    {
        // GET: Object
        [HttpGet]
        public ActionResult ObjectView()
        {
            return View();
        }
    }
}