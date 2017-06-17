using System.Collections.Generic;
using System.Web.Http;

namespace Api.v1.Movies
{
    public class MoviesController : ApiController
    {
        public List<MoviesModel> Get() {
            return new List<MoviesModel>();
        }
    }
}
