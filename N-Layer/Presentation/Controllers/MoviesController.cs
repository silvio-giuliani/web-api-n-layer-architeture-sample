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
        [OutputCache(Location = System.Web.UI.OutputCacheLocation.None)]
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

        public async Task<ActionResult> Create(MoviesModel movie)
        {
            if (ModelState.IsValid)
            {
               await new ApiHelper().Add<MoviesModel>(movie);

                return RedirectToAction("Index");
            }

            ModelState.Clear();
            
            return View(movie);

        }

        public async Task<ActionResult> Update(int id, MoviesModel movie)
        {
            if (ModelState.IsValid)
            {
                await new ApiHelper().Update<MoviesModel>(id, movie);

                return RedirectToAction("Index");
            }
            else
            {

                var model = await new ApiHelper().Get<MoviesModel>(id);

                ModelState.Clear();

                return View(model);
            }

        }

        public async Task<ActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await new ApiHelper().Delete<MoviesModel>(id);

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}