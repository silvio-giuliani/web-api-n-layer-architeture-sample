using Application.Movies.Commands;
using Application.Movies.Queries;
using System.Web.Http;

namespace Api.v1.Movies
{
    public class MoviesController : ApiController
    {
        private readonly IGetMoviesListQuery _getMoviesListQuery;
        private readonly IGetMovieQuery _getMovieQuery;
        private readonly IAddMovieCommand _addCommand;
        private readonly IChangeMovieCommand _changeCommand;
        private readonly IRemoveMovieCommand _removeCommand;

        public MoviesController(IGetMoviesListQuery getMoviesListQuery,
                                IGetMovieQuery getMovieQuery,
                                IAddMovieCommand addCommand,
                                IChangeMovieCommand changeCommand,
                                IRemoveMovieCommand removeCommand)
        {
            _getMoviesListQuery = getMoviesListQuery;
            _getMovieQuery = getMovieQuery;
            _addCommand = addCommand;
            _changeCommand = changeCommand;
            _removeCommand = removeCommand;
        }

        [HttpGet]
        public IHttpActionResult GetAll() {

            var movies = _getMoviesListQuery.Execute();

            return Ok(movies);
        }

        [HttpGet]
        [Route("api/{version}/movies/get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var movies = _getMovieQuery.Execute(id);

            return Ok(movies);
        }

        [HttpPost]
        public IHttpActionResult Add(MoviesModel movie) {

            var addMovieModel = new CommandMovieModel()
            {
                Id = movie.Id,
                Summary = movie.Summary,
                Title = movie.Title,
                YearReleased = movie.YearReleased
            };

            _addCommand.Execute(addMovieModel);

            return Ok();

        }

        [HttpPut]
        [Route("api/{version}/movies/update/{id}")]
        public IHttpActionResult Update(int id, [FromBody]MoviesModel movie)
        {

            var addMovieModel = new CommandMovieModel()
            {
                Summary = movie.Summary,
                Title = movie.Title,
                YearReleased = movie.YearReleased
            };

            _changeCommand.Execute(id, addMovieModel);

            return Ok();

        }

        [HttpDelete]
        [Route("api/{version}/movies/remove/{id}")]
        public IHttpActionResult Remove(int id)
        {
            _removeCommand.Execute(id);

            return Ok();

        }

    }
}

