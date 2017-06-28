using Presentation.Helpers;
using Presentation.Models;
using System.Configuration;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class MoviesController : Controller
    {
        string api = ConfigurationManager.AppSettings["ApiUri"];

        // GET: Movies
        public ActionResult Index()
        {

            var model = new ApiHelper().Get<MoviesModel>();

            return View(model);
        }
    }
}