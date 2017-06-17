using Domain.Movies;
using System.Data.Entity;


namespace Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<Movie> Movies { get; set; }

        void Save();
    }
}
