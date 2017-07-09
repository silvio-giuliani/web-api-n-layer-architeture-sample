using Application.Interfaces;
using Domain.Movies;

namespace Application.Movies.Commands
{
    public class AddMovieCommand : IAddMovieCommand
    {
        private readonly IDatabaseService _database;

        public AddMovieCommand(IDatabaseService database) {

            _database = database;
        }

        public void Execute(CommandMovieModel addMovieModel)
        {
            var movie = new Movie()
            {
                Id = addMovieModel.Id,
                Summary = addMovieModel.Summary,
                Title = addMovieModel.Title,
                YearReleased = addMovieModel.YearReleased
            };

            _database.Movies.Add(movie);
            _database.Save();
        }
    }
}
