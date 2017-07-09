namespace Application.Movies.Commands
{
    public interface IRemoveMovieCommand
    {
        void Execute(int id);
    }
}
