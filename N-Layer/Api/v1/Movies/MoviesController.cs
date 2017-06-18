using Application.Movies.Queries;
using System.Collections.Generic;
using System.Web.Http;

namespace Api.v1.Movies
{
    public class MoviesController : ApiController
    {
        private readonly IGetMoviesListQuery _query;

        public MoviesController(IGetMoviesListQuery query) {
            _query = query;
        }

        [HttpGet]
        public IEnumerable<MovieModel> GetAll() {

            var movies = _query.Execute();

            return movies;
        }
    }
}
