using System.Data.Entity;
using Domain.Movies;

namespace Persistence
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseService>
    {
        protected override void Seed(DatabaseService database)
        {

            base.Seed(database);

            CreateMovies(database);
        }

        private void CreateMovies(DatabaseService database)
        {
            database.Movies.Add(new Movie(){    Id = 1,
                                                Title = "Old Boy",
                                                Summary = "Dae-Su é raptado e mantido em cativeiro por 15 anos num quarto de hotel, sem qualquer contato com o mundo externo. Quando ele é inexplicavelmente solto, descobre que é acusado pelo assassinato da esposa e embarca numa missão obsessiva por vingança.",
                                                YearReleased = 2005
                                            });


            database.Movies.Add(new Movie(){    Id = 2,
                                                Title = "O grande truque",
                                                Summary = "No século 19, em Londres, dois amigos ilusionistas e mágicos, Alfred Borden e Rupert Angier, acabam construindo uma rivalidade, uma batalha por supremacia, que se estende ao longo dos anos e que se transforma em obsessão, cujos resultados serão inevitavelmente trágicos.",
                                                YearReleased = 2006
                                            });


            database.Movies.Add(new Movie(){    Id = 3,
                                                Title = "Stalker",
                                                Summary = "Três viajantes do futuro atravessam uma zona proibida e encontram um lugar onde as fantasias são realizadas e a verdade é revelada.",
                                                YearReleased = 1979
                                            });


            database.SaveChanges();
        }

    }
}
