using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using moviejs.Models;
using moviejs.Providers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace moviejs.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        /*        private readonly IMovieProvider movieProvider;

                public MovieController(IMovieProvider movieProvider)
                {
                    this.movieProvider = movieProvider;
                }
                */
        private static readonly HttpClient client = new HttpClient();

        [HttpGet("[action]")]
        public IActionResult getLatest()
        {
            //return Ok(movieProvider.GetLatestMovie());
            return Ok(new Movie
            {
                OriginalTitle = "My Movie",
                ProductionYear = 2018,
                Summary = "this is the summary of an life time. A lot of intereasting this happen in this movie"
            });
        }


        [HttpGet("[action]")]
        public IActionResult getMovie([FromQuery(Name = "oid")] string oid)
        {
            
            return Ok(getMovieFromAsync(oid));

        }




        [HttpGet("[action]")]
        public IActionResult Search([FromQuery(Name = "searchMovie")] string searchMovie)
        {
            //return Ok(movieProvider.GetLatestMovie());

            Movie NewMovie =new Movie
            {
                OriginalTitle = searchMovie,
                ProductionYear = 2018,
                Summary = "jo jo"
            };

            List<Movie> movieList = new List<Movie>
            {
                createMovie(1, "Movie 1", 1, "Summary movie 1"),
                createMovie(2, "Movie 2", 2, "Summary movie 2"),
                createMovie(3, "Movie 3", 3, "Summary movie 3"),
                createMovie(4, "Movie 4", 4, "Summary movie 4"),
                createMovie(5, "Movie 5", 5, "Summary movie 5"),
                NewMovie
            };





            return Ok(movieList);
        }

        private Movie createMovie(int oid, string originalTitle, int productionYear, string summary)
        {
            return new Movie
            {
                OriginalTitle = originalTitle,
                ProductionYear = productionYear,
                Summary = summary,
                oid = oid
            };
        }


        private async Task<Movie> getMovieFromAsync(string oid)
        {
            await ProcessRepositories();
            return new Movie
            {
                OriginalTitle = "One movie",
                ProductionYear = Int32.Parse(oid),
                Summary = "summary One Movie"
            };
        }


        private static async Task ProcessRepositories()
        {
            //We will make a GET request to a really cool website...

            string baseUrl = "http://localhost:20200/api/movie/10004";
            //The 'using' will help to prevent memory leaks.
            //Create a new instance of HttpClient

                       using (HttpClient client = new HttpClient())


                        using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                Console.WriteLine(data);
                            }
                        }
        }
    }
}
