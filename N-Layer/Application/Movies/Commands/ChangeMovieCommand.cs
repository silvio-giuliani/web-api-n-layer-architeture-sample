using Application.Interfaces;
using System.Linq;

namespace Application.Movies.Commands
{
    public class ChangeMovieCommand : IChangeMovieCommand
    {
        private readonly IDatabaseService _database;

        public ChangeMovieCommand(IDatabaseService database) {

            _database = database;
        }

        public void Execute(int id, CommandMovieModel commandMovie)
        {
            var movie = _database.Movies.Where(item => item.Id.Equals(id)).FirstOrDefault();

            movie.Summary = commandMovie.Summary;
            movie.Title = commandMovie.Title;
            movie.YearReleased = commandMovie.YearReleased;

            //_database.Movies.Add(movie);
            _database.Save();

        }
    }
}
