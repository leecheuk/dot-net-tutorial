using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;
using System.Collections.Generic;
using System.Linq;

namespace webAppTutorial.Controllers
{
    public class ApiController : Controller
    {

        private readonly RazorPagesMovieContext _context;

        public ApiController(RazorPagesMovieContext ctx) {
            _context = ctx;
        }
        
        // GET; /api/
        public string Index()
        {
            return "You are at the api endpoint";
        }

        // GET; /api/Welcome
        public string Welcome(string name, int numTimes = 1) 
        {
            // add query string
            return HtmlEncoder.Default.Encode($"Hello {name}, welcome to api world! NumTimes is: {numTimes}");
        }

        // GET; /api/movies
        [Route("api/movies")]
        public IEnumerable<Movie> GetMovies() {
            IQueryable<Movie> query = _context.Movie;
            return query.ToList();
        }


    }
}