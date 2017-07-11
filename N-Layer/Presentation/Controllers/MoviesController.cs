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
            var model = await new ApiHelper().GetAll<List<MoviesModel>>();

            return View(model);
        }


        public async Task<ActionResult> Detail(int id)
        {
            var model = await new ApiHelper().Get<MoviesModel>(id);

            return View(model);

        }

        public ActionResult Create(MoviesModel movie)
        {
            //if (ModelState.IsValid)
            //{
            //    new ApiHelper().Add<MoviesModel>(movie);
            //    return RedirectToAction("Index");
            //}

            return View(movie);

        }
    }
}