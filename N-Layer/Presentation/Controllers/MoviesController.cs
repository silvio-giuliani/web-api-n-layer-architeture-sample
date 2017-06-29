using Presentation.Helpers;
using Presentation.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class MoviesController : Controller
    {
        string api = ConfigurationManager.AppSettings["ApiUri"];

        // GET: Movies
        public async Task<ActionResult> Index()
        {
            var model = await new ApiHelper().Get<List<MoviesModel>>();

            return View(model);
        }
    }
}