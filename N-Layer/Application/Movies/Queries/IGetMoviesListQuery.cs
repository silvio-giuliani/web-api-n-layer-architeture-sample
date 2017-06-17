using System.Collections.Generic;

namespace Application.Movies.Queries
{
    public interface IGetMoviesListQuery
    {
        List<MovieModel> Execute();
    }
}
