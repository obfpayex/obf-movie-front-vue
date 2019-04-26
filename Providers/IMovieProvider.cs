using moviejs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moviejs.Providers
{
    public interface IMovieProvider
    {
        Movie GetLatestMovie();
    }
}
