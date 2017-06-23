using System.Collections.Generic;

namespace Presentation.Models
{
    public class MoviesModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public int YearReleased { get; set; }

        public List<GenresModel> Genres { get; set; }
    }
}