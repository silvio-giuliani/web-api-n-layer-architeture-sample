using Application.Interfaces;

namespace Application.Movies.Queries
{
    public class GetMovieQuery : IGetMovieQuery
    {
        private readonly IDatabaseService _database;

        public GetMovieQuery(IDatabaseService database) {
            _database = database;
        }

        public MovieModel Execute(int id)
        {
            var movie = _database.Movies.Find(id);

            var model = new MovieModel()
            {
                Id = movie.Id,
                Summary = movie.Summary,
                Title = movie.Title,
                YearReleased = movie.YearReleased
            };

            return model;
        }
    }
}
