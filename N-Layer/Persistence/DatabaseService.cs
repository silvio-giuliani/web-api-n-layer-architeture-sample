using Application.Interfaces;
using Domain.Movies;
using System;
using System.Data.Entity;

namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public IDbSet<Movie> Movies { get;  set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
