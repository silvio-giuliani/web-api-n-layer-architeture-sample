﻿using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    public class Movie : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public int YearReleased { get; set; }

        public List<Genre> Genres { get; set; }

    }
}
