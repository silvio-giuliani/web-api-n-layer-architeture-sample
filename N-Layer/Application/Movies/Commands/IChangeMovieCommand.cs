namespace Application.Movies.Commands
{
    public interface IChangeMovieCommand
    {
        void Execute(int id, CommandMovieModel movie);
    }
}
