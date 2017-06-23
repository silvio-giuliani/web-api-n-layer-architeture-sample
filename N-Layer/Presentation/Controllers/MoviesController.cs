using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class MoviesController : Controller
    {
        string api = ConfigurationManager.AppSettings["ApiUri"];

        // GET: Movies
        public ActionResult Index()
        {
            
            return View();
        }
    }
}