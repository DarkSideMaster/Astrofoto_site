using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AstroFotoWebSite.Controllers
{
    public class AstroForecastController : Controller
    {
        // GET: AstroForecast
        public ActionResult AstroForecastView()
        {
            return View();
        }
    }
}