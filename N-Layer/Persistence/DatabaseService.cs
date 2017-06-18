using Application.Interfaces;
using Domain.Movies;
using Persistence.Movies;
using System;
using System.Data.Entity;

namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public IDbSet<Movie> Movies { get;  set; }

        public DatabaseService() : base("N-Layer") {

            Database.SetInitializer(new DatabaseInitializer());
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MovieConfiguration());
        }
    }
}
