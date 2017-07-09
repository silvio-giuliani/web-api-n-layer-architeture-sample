using Application.Interfaces;
using System.Linq;

namespace Application.Movies.Commands
{
    public class RemoveMovieCommand : IRemoveMovieCommand
    {

        private readonly IDatabaseService _database;

        public RemoveMovieCommand(IDatabaseService database)
        {

            _database = database;
        }

        public void Execute(int id)
        {
            var movie = _database.Movies.Where(item => item.Id.Equals(id)).FirstOrDefault();

            _database.Movies.Remove(movie);
            _database.Save();

        }
    }



}
