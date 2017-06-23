using Application.Interfaces;
using Domain.Movies;
using Persistence.Movies;
using System.Data.Entity;

namespace Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public IDbSet<Movie> Movies { get;  set; }

        public DatabaseService() : base("NLayer") {

            Database.SetInitializer(new DatabaseInitializer());
            Database.Initialize(true);
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
