using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Models
{
    public class Movie
    {
        public string Name { get; set; }

        public Guid Id { get; set; }

        public long Budget { get; set; }
    }
}
