using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{
    public class Genre : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
