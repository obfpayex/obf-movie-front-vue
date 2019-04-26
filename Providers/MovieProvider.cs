using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using moviejs.Models;

namespace moviejs.Providers
{
    public class MovieProvider : IMovieProvider
    {
        private Movie OneMovie { get; set; }

        public MovieProvider()
        {
            OneMovie = new Movie
            {
                OriginalTitle = "My Movie",
                ProductionYear = 2018,
                Summary = "this is the summary of an life time. A lot of intereasting this happen in this movie"
            };
        }

        public Movie GetLatestMovie()
        {
            return OneMovie;
        }
    }
}
