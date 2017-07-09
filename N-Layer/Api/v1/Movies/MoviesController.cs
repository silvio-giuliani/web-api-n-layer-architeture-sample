using Application.Movies.Commands;
using Application.Movies.Queries;
using System.Web.Http;

namespace Api.v1.Movies
{
    public class MoviesController : ApiController
    {
        private readonly IGetMoviesListQuery _query;
        private readonly IAddMovieCommand _addCommand;
        private readonly IChangeMovieCommand _changeCommand;
        private readonly IRemoveMovieCommand _removeCommand;

        public MoviesController(IGetMoviesListQuery query,
                                IAddMovieCommand addCommand,
                                IChangeMovieCommand changeCommand,
                                IRemoveMovieCommand removeCommand) {
            _query = query;
            _addCommand = addCommand;
            _changeCommand = changeCommand;
            _removeCommand = removeCommand;
        }

        [HttpGet]
        public IHttpActionResult GetAll() {

            var movies = _query.Execute();

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
        public IHttpActionResult Update(int id, MoviesModel movie)
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
        public IHttpActionResult Remove(int id)
        {
            _removeCommand.Execute(id);

            return Ok();

        }

    }
}

