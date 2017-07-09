namespace Application.Movies.Commands
{
    public interface IAddMovieCommand
    {
        void Execute(CommandMovieModel movie);
    }
}
