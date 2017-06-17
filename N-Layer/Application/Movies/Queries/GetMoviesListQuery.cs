using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Movies.Queries
{
    public class GetMoviesListQuery : IGetMoviesListQuery
    {
        private readonly IDatabaseService _database;

        public GetMoviesListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<MovieModel> Execute() {

            var movies = _database.Movies.Select(p => new MovieModel()
            {
                Id = p.Id,
                Summary = p.Summary,
                Title = p.Title,
                YearReleased = p.YearReleased   
            });

            return movies.ToList();

        }
    }
}
