using System.Collections.Generic;

namespace Application.Movies.Commands
{
    public class MovieModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public int YearReleased { get; set; }

        //public List<GenreModel> Genres { get; set; }
    }
}
