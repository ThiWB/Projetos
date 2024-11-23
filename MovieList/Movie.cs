using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieList
{
    public class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }

        public Movie () {}

        public Movie (string name, string genre, string description, string releaseDate)
        {
            Name = name;
            Genre = genre;
            Description = description;
            ReleaseDate = releaseDate;
        }
    }
}