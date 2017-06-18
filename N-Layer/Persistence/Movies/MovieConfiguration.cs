using Domain.Movies;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.Movies
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration() {

            HasKey(p => p.Id);

            Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Summary)
                .IsRequired()
                .HasMaxLength(8000);

            Property(p => p.YearReleased)
                .IsRequired();
            
        }

    }
}
