namespace Application.Movies.Queries
{
    public interface IGetMovieQuery
    {
        MovieModel Execute(int id);
    }
}
